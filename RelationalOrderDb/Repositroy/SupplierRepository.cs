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


namespace RelationalOrderDb.Repositroy
{
    public class SupplierRepository : ISupplierRepository
    {
       
         private OrderSimpleContext _dbContext;
       
        public SupplierRepository(OrderSimpleContext dbContext)
        {

           _dbContext = dbContext;
           
        }
        public List<Supplier> GetAllSupplierRepository()
        {
            return _dbContext.Suppliers.ToList();
        }


    }
}