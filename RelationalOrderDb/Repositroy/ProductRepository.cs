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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RelationalOrderDb.Repositroy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RelationalOrderDb.Models;
using RelationalOrderDb.Services.Abstract;
using RelationalOrderDb.Controllers;
using RelationalOrderDb.Services;
using RelationalOrderDb.Repositroy.Abstract;

namespace RelationalOrderDb.Repositroy
{
    public class ProductRepository : IProductRepository
    {
       private  OrderSimpleContext _dbContext;

        public ProductRepository(OrderSimpleContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Product> GettAllProductRepository()
        {
            return _dbContext.Products.ToList();
        }
    }
}