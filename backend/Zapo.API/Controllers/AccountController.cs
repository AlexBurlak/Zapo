using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Zapo.Domain.Common.Authentication;
using Zapo.Domain.Entities;

namespace Zapo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : Controller
    {
        private List<User> _users = new List<User>
        {
            new User {Email = "admin@email.com", Password = "12345", UserName = "Admin"},
            new User {Email = "guest@email.com", Password = "11111", UserName = "Guest"}
        };

        [HttpPost("/token")]
        public IActionResult Token(string email, string password)
        {
            var identity = GetIdentity(email, password);
            if (identity == null)
            {
                return BadRequest(new {errorText = "Invalid username or password."});
            }
            var now = DateTime.UtcNow;
            var jwt = new JwtSecurityToken(
                issuer:AuthOptions.Issuer,
                audience:AuthOptions.Audience,
                notBefore:now,
                claims:identity.Claims,
                expires:now.Add(TimeSpan.FromMinutes(AuthOptions.Lifetime)),
                signingCredentials:new SigningCredentials(AuthOptions.GetSymmetricSecurityKey(),
                    SecurityAlgorithms.HmacSha256));
            var encodedJWT = new JwtSecurityTokenHandler().WriteToken(jwt);
            var responde = new
            {
                access_token = encodedJWT,
                username = identity.Name
            };
            return Json(responde);
        }

        private ClaimsIdentity GetIdentity(string email, string password)
        {
            User user = _users.FirstOrDefault(x => x.Email == email && x.Password == password);
            if (user != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimsIdentity.DefaultNameClaimType, user.Email)
                };
                ClaimsIdentity claimsIdentity =
                    new ClaimsIdentity(claims, "Token", ClaimsIdentity.DefaultNameClaimType,
                        ClaimsIdentity.DefaultRoleClaimType);
                return claimsIdentity;
            }

            return null;
        }
    }
}