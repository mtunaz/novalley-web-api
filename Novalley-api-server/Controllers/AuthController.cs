using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;
using Novalley_api_server.Interfaces;
using Novalley_api_server.DTOs;
using System.Runtime.InteropServices;

namespace Novalley_api_server.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController : ControllerBase
    {
        private readonly IRegisterService _registerService;
        private readonly ILoginService _loginService;

        public AuthController(IRegisterService registerService, ILoginService loginService)
        {
            _registerService = registerService;
            _loginService = loginService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterAsync([FromBody] UserRegistrationDto userRegistrationDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var registerResult = await _registerService.RegisterUserAsync(userRegistrationDto);

            if (!registerResult.Succeeded)
            {
                return BadRequest(registerResult);
            }

            return Ok("Registered successfully.");
        }

        [HttpPost("login")]
        public async Task<IActionResult> LoginAsync([FromBody] LoginCredentialDto loginCredential) // Need parameters
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var loginResult = await _loginService.UserLoginAsync(loginCredential);

            if (!loginResult)
            {
                return BadRequest("Registration failed.");
            }

            return Ok("Login successfully.");
        }

        [HttpPost("logout")]
        public async Task<IActionResult> LogoutAsync() // Need parameters
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _loginService.LogoutAsync();

            return Ok("Registered successfully.");
        }

    }
}
