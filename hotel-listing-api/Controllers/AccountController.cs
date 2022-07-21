﻿using hotel_listing_api.Contracts;
using hotel_listing_api.Models.Users;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace hotel_listing_api.Controllers
{
    // Implement controller/route for admin creation

    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAuthManager _authManager;
        private readonly ILogger<AccountController> _loger;

        public AccountController(IAuthManager authManager, ILogger<AccountController> loger)
        {
            _authManager = authManager;
            _loger = loger;
        }

        //POST: api/Account/register
        [HttpPost]
        [Route("register")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> Register([FromBody] UserDTO userDto)
        {
            _loger.LogInformation($"Registration attempt for {userDto.Email}");
            try
            {
                var errors = await _authManager.Register(userDto);

                if (errors.Any())
                {
                    foreach (var error in errors)
                    {
                        ModelState.AddModelError(error.Code, error.Description);
                    }

                    return BadRequest(ModelState);
                }

                return Ok();
            }
            catch (Exception ex)
            {
                _loger.LogError(ex, $"Something went wrong in the {nameof(Register)} - User Registration attempt for {userDto.Email}");

                return Problem($"Something went wrong in the {nameof(Register)}. Please contact support.", statusCode: 500);
            }
            
        }

        //POST: api/Account/login
        [HttpPost]
        [Route("login")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> Login([FromBody] LoginDTO loginDto)
        {
            _loger.LogInformation($"Login attempt for {loginDto.Email}");

            try
            {
                var authResponse = await _authManager.Login(loginDto);

                if (authResponse == null)
                {
                    return Unauthorized();
                }

                return Ok(authResponse);
            }
            catch (Exception ex)
            {
                _loger.LogError(ex, $"Something went wrong in the {nameof(Login)} - User login attempt for {loginDto.Email}");

                return Problem($"Something went wrong in the {nameof(Login)}. Please contact support.", statusCode: 500);
            }
            
        }

        //POST: api/Account/refreshtoken
        [HttpPost]
        [Route("refreshtoken")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> RefreshToken([FromBody] AuthResponseDTO request)
        {
            var authResponse = await _authManager.VerifyRefreshToken(request);

            if (authResponse == null)
            {
                return Unauthorized();
            }

            return Ok(authResponse);
        }
    }
}
