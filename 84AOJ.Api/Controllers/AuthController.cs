using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using _84AOJ.Application.Interface;
using _84AOJ.Application.Request;
using _84AOJ.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace _84AOJ.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthenticationService _service;

        public AuthController(IAuthenticationService service)
        {
            _service = service;
        }

        [HttpPost("authenticate")]
        public async Task<IActionResult> Authenticate([FromBody] Login request)
        {

            var ret = await _service.AuthenticateAsync(request);

            if (ret == null)
                return BadRequest(new JsonResult("Usuário invalido!"));

            return Ok(ret);
        }
       
    }
}
