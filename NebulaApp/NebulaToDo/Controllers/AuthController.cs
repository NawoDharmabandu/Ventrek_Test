using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using NebulaToDo.Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace NebulaToDo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private NebulaDbContext _dbContext;

        public AuthController(NebulaDbContext dbcontext)
        {
            _dbContext = dbcontext;
        }

        [AllowAnonymous]
        [HttpPost("Token")]
        public IActionResult Auth([FromBody] USERS model)
        {
            var userbyid = _dbContext.USER.Where(x => x.USER_ID == model.USER_ID && x.USER_PASSWORD == model.USER_PASSWORD).FirstOrDefault();

            if (userbyid != null)
            {
                if (model.USER_ID == userbyid.USER_ID && model.USER_PASSWORD == userbyid.USER_PASSWORD)
                {
                    var claims = new[]
                    {
                    new Claim(JwtRegisteredClaimNames.Sub, model.USER_ID),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
                };
                    var signinkey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("NebulaSuperSecureKey"));
                    var token = new JwtSecurityToken(
                        issuer: "Nebula.lk",
                        audience: "Nebula.lk",
                        expires: DateTime.UtcNow.AddHours(1),
                        claims: claims,
                        signingCredentials: new SigningCredentials(signinkey, SecurityAlgorithms.HmacSha256)
                        );
                    return Ok(new
                    {
                        token = new JwtSecurityTokenHandler().WriteToken(token),
                        expiration = token.ValidTo
                    });
                };
            }

            return Unauthorized();
        }

    }
}
