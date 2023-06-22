using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

namespace RelationalOrderDb.Services.Abstract
{
    public interface ICustomerRepository
    {
        public Task <List<Customer>> GetAllCustomer();
        public Task<Customer> GetSinlgeCustomer(int id);
        public Task<Customer> AddCustomer(Customer customer);
        public Task<bool> UpdateCustomer();
        public Task<Customer> DeleteCustomer(Customer cu);


        
    }
}