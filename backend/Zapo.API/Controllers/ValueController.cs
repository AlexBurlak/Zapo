using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Zapo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValueController : ControllerBase
    {
        [Authorize]
        [HttpGet("getlogin")]
        public IActionResult GetLogin()
        {
            return Ok($"Your login {User.Identity.Name} ");
        }
    }
}