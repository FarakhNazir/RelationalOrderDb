using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RelationalOrderDb.Repositroy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RelationalOrderDb.DTO;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using RelationalOrderDb.Models;
using RelationalOrderDb.Services.Abstract;
using RelationalOrderDb.Controllers;
using RelationalOrderDb.Services;
using RelationalOrderDb.Repositroy.Abstract;

namespace RelationalOrderDb.Repositroy.Abstract
{
    public interface IProductRepository
    {
         public List<Product> GettAllProductRepository();
    }
}