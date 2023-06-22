using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RelationalOrderDb.DTO;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using RelationalOrderDb.Models;
using RelationalOrderDb.Services.Abstract;
using RelationalOrderDb.Repositroy;
using RelationalOrderDb.Controllers;
using RelationalOrderDb.DTO.Responce;
using System.IdentityModel.Tokens.Jwt;
using System.IdentityModel.Tokens;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.Text;
using RelationalOrderDb.DTO.Request;
namespace RelationalOrderDb.Services
{
    public class JwtAuthenticationServices : IJwtAuthentication
    {  
        
         Dictionary<string,string> user = new Dictionary<string, string>
        {
            {"test1", "password1"}, {"test2", "password2"}
        };
        private readonly IConfiguration _iconfiguration;

        public JwtAuthenticationServices( IConfiguration iconfiguration)
        {
         
            _iconfiguration = iconfiguration;
        }

        

        public string Authentication(UserDto userDto)
        {
           
            if(!user.Any(x => x.Key == userDto.Name && x.Value == userDto.Password))
            {
                return null;
            }
            
            var tokenhandler = new JwtSecurityTokenHandler();
            var tokenkey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_iconfiguration["Jwt:Key"])); 
            var tokenDescription = new SecurityTokenDescriptor()
            {
                
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, userDto.Name)

                }),
                Expires = DateTime.UtcNow.AddDays(1),
                SigningCredentials = new SigningCredentials(tokenkey, SecurityAlgorithms.HmacSha256)
                
            };  

            var token = tokenhandler.CreateToken(tokenDescription);
            var jwttoken = tokenhandler.WriteToken(token);
            return jwttoken;
        }
       

    }
}