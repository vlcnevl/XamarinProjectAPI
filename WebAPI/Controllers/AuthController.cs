using Business.Abstract;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public IActionResult Login(UserForLoginDto userForLoginDto)
        {
            var userCheckToLogin = _authService.Login(userForLoginDto);
            if (!userCheckToLogin.Success)
            {
                return BadRequest(userCheckToLogin);
            }
            var result = _authService.CreateAccessToken(userCheckToLogin.Data);
            if (!result.Success)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

        [HttpPost("register")]
        public IActionResult Register(UserForRegisterDto userForRegisterDto)
        {
            var userExistsCheck = _authService.UserExists(userForRegisterDto.Email);
            if (!userExistsCheck.Success)
            {
                return BadRequest(userExistsCheck);
            }
            var userToRegister = _authService.Register(userForRegisterDto).Data;
            var result = _authService.CreateAccessToken(userToRegister);
            if (!result.Success)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
    }
}