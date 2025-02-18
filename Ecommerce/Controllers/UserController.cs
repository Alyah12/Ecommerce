using Ecommerce.Context;
using Ecommerce.Model;
using Ecommerce.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpGet]
    public IActionResult Login(string email, string password)
    {
        User user = _userService.GetUserByEmail(email);
        if (user == null)
        {
            return NotFound();
        }
        if (user.Password != password)
        {
            return Unauthorized();
        }
        return Ok();
    }


    [HttpPost]
    public IActionResult Register(User user)
    {
        _userService.AddUser(user);
        return Ok();
    }

}