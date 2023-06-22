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
using RelationalOrderDb.Services;
using RelationalOrderDb.Repositroy.Abstract;


namespace RelationalOrderDb.DTO.Responce
{
    public class CustomerResponceDTO
    {
        public string message { get; set; }

        public bool isError { get; set; }

        public dynamic data { get; set; } = null;

    }
}