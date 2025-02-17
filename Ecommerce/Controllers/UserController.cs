using Ecommerce.Context;
using Ecommerce.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Controllers;

public class UserController : ControllerBase
{
    readonly AppDbContext _context;

    public UserController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<User>> Get()
    {
        var getUsers = "SELECT * from User where User.Id = 1";
        var getUser = await _context.User.FromSqlRaw(getUsers).ToListAsync();

        if (getUser is null)
        {
            BadRequest("Users not found");
        }

        return Ok(getUser);
    }

    [HttpPost]

    public ActionResult Post([FromBody] User user)
    {
        _context.User.AddAsync(user);
        _context.SaveChangesAsync();

        return Ok(user);
    }
}