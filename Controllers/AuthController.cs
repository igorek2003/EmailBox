using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EmailBox.Services;
using EmailBox.Models;

namespace EmailBox.Controllers
{
        [ApiController]
        [Route("api/[controller]")]
        public class AuthController : ControllerBase
        {
            private readonly IUserService _userService;

            public AuthController(IUserService userService)
            {
                _userService = userService;
            }

            [HttpPost("signup")]
            public IActionResult SignUp([FromBody] UserRegistrationModel model)
            {
                if (string.IsNullOrEmpty(model.Email) || string.IsNullOrEmpty(model.Name) || string.IsNullOrEmpty(model.Password)) // Пароль добавлен для примера  
                {
                    return BadRequest("Email, name, and password are required.");
                }

                string email = _userService.SignUp(model.Email, model.Name, model.Password); // Пароль добавлен для примера  

                if (email == null)
                {
                    return Conflict("Email already exists.");
                }

                return Ok(new { Email = email, Message = "User registered successfully." });
            }

            [HttpPost("login")]
            public IActionResult Login(string email, string password)
            {
                if (_userService.Login(email, password))
                {
                    return Ok(new { Message = "Logged in successfully." });
                }
                return Unauthorized("Invalid credentials.");
            }
        }
    

}
