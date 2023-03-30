using ApiAuthentication.Interfaces;
using ApiAuthentication.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApiAuthentication.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly ILogger<WeatherForecastController> _logger;
    private readonly IUserService _userService;

    public WeatherForecastController(
        ILogger<WeatherForecastController> logger,
        IUserService userService)
    {
        _logger = logger;
        _userService = userService;
    }

    [HttpGet]
    [Route("weather")]
    public IActionResult Get()
    {
        return Ok();
    }

    [HttpGet]
    [Route("weather/protected")]
    [Authorize]
    public IActionResult GetProtected()
    {
        return Ok();
    }

    [HttpGet]
    [Route("weather/generatetoken")]
    public IActionResult GenerateToken()
    {
        var user = _userService.Find("alexandre@infnet.edu.br");
        return Ok(TokenService.GenerateToken(user));
    }
}

