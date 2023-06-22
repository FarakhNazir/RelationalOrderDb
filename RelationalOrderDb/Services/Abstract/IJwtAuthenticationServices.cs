using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RelationalOrderDb.DTO.Request;
namespace RelationalOrderDb.Services.Abstract
{
    public interface IJwtAuthentication
    {
        public string Authentication (UserDto userDto);
        
    }
}