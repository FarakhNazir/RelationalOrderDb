using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
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
using RelationalOrderDb.Repositroy.Abstract;
namespace RelationalOrderDb.Services
{
    public class ProductServices : IProductServices
    {
        //private  OrderSimpleContext _dbContext;

        private readonly IProductRepository _iProductRepository;
        public ProductServices( IProductRepository iProductRepository)
        {
          //  _dbContext = dbContext;
            _iProductRepository = iProductRepository;
        }

        public List<Product> GetAllProductServices()
        {
            return _iProductRepository.GettAllProductRepository();
        }
    }
}