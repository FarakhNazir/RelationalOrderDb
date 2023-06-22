using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RelationalOrderDb.Models;
using Microsoft.EntityFrameworkCore;
using RelationalOrderDb.DTO.Request;
using RelationalOrderDb.DTO.Responce;
using RelationalOrderDb.DTO;
using System.Net;
using RelationalOrderDb.Services.Abstract;
using RelationalOrderDb.Repositroy;
using RelationalOrderDb.Services;
using System.Diagnostics.Metrics;
using System.Numerics;
using Azure;
using Microsoft.AspNetCore.JsonPatch;
using RelationalOrderDb.Repositroy;
using RelationalOrderDb.Controllers;
using RelationalOrderDb.Repositroy.Abstract;
using RelationalOrderDb.CustomMiddlewareService;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using System;

namespace RelationalOrderDb.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class TokenController : ControllerBase
    {
        public IConfiguration _configuration;
        public IJwtAuthentication _iJwtAuthentication;
        //private readonly OrderSimpleContext _orderSimpleContext;

        //private Dictionary<string,string> userList<

        public TokenController(OrderSimpleContext orderSimpleContext, IConfiguration configuration, IJwtAuthentication iJwtAuthentication)
        {
            //  _orderSimpleContext = orderSimpleContext;
            _configuration = configuration;
            _iJwtAuthentication = iJwtAuthentication;
        }

        [HttpGet("GetUser")]
        public IEnumerable<string> Userss()
        {
            return new string[] { "Farrukh", "Nazir" };
        }
        [AllowAnonymous]
        [HttpPost]
        [Route("Authenticate")]
        public IActionResult Authenticate([FromBody] UserDto userDto)
        {
            var token = _iJwtAuthentication.Authentication(userDto);
            if (token == null)
            {
                return Ok("Farrukh");
                //return Unauthorized();
            }

            return Ok(token);
        }

        /*  public async Task<IActionResult> Post(UserInfo _userData)
         {
             if (_userData != null && _userData.Email != null && _userData.Password != null)
             {
                 var user = await GetUser(_userData.Email, _userData.Password);

                 if (user != null)
                 {
                     //create claims details based on the user information
                     var claims = new[] {
                         new Claim(JwtRegisteredClaimNames.Sub, _configuration["Jwt:Subject"]),
                         new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                         new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                         new Claim("UserId", user.UserId.ToString()),
                         new Claim("DisplayName", user.DisplayName),
                         new Claim("UserName", user.UserName),
                         new Claim("Email", user.Email)
                     };

                     var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
                     var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                     var token = new JwtSecurityToken(
                         _configuration["Jwt:Issuer"],
                         _configuration["Jwt:Audience"],
                         claims,
                         expires: DateTime.UtcNow.AddMinutes(10),
                         signingCredentials: signIn);

                     return Ok(new JwtSecurityTokenHandler().WriteToken(token));
                 }
                 else
                 {
                     return BadRequest("Invalid credentials");
                 }
             }
             else
             {
                 return BadRequest();
             }
         }

         private async Task<UserInfo> GetUser(string email, string password)
         {
             return await _context.UserInfos.FirstOrDefaultAsync(u => u.Email == email && u.Password == password);
         }
     */
    }
}