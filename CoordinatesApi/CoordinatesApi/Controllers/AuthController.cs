using System.Threading.Tasks;
using CoordinatesApi.Core.Models.Auth;
using CoordinatesApi.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace CoordinatesApi.WebApi.Controllers;

[ApiController]
public class AuthController : ControllerBase
{
    private readonly IUserService _userService;

    public AuthController(IUserService userService)
    {
        _userService = userService;
    }
    
    [HttpPost("api/v1/auth/register")]
    public async Task<IActionResult> RegisterAsync([FromBody] RegisterModel registerModel)
    {
        await _userService.CreateUserAsync(registerModel);
        return Ok();
    }
}