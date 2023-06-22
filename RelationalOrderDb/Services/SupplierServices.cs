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
    public class SupplierServices : ISupplierServices
    {
        //private readonly OrderSimpleContext _dbContext;
        private readonly ISupplierRepository _iSupplierRepository;

        public SupplierServices(ISupplierRepository iSupplierRepository)
        {
           // this._dbContext = dbContext;
            _iSupplierRepository = iSupplierRepository;
        }

        public List<Supplier> GetSuppliers()
        {
            return _iSupplierRepository.GetAllSupplierRepository();
        }
    }
}