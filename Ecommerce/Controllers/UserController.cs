using Ecommerce.Model;
using Ecommerce.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;


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
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult Login(string? email, string? password)
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
    [ProducesResponseType(StatusCodes.Status201Created)]
    public IActionResult Register(User user)
    {
        _userService.AddUser(user);
        return Ok();
    }

}