using Ecommerce.Context;
using Ecommerce.Model;
using Ecommerce.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Controllers;

public class UserController : ControllerBase
{
    readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpPost]

    public IActionResult Register(User user)
    {
        _userService.AddUser(user);
        return Ok();
    }

}