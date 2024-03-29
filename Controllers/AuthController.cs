﻿using System.Threading.Tasks;
using DataEnteringQuality.Models;
using DataEnteringQuality.Services;
using Microsoft.AspNetCore.Mvc;

namespace DataEnteringQuality.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost]
        public async Task<IActionResult> Authenticate(AuthenticateModel model)
        {
            var user = await _authService.Authenticate(model.Username, model.Password);

            if (user == null)
                return BadRequest(new { message = "Nazwa użytkownika lub hasło niepoprawne" });

            return Ok(user);
        }
    }
}
