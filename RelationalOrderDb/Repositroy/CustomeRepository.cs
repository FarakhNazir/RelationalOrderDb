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

namespace RelationalOrderDb.Repositroy
{
    public class CustomeRepository : ICustomerRepository
    {
        private readonly OrderSimpleContext _dbContext;

        public CustomeRepository(OrderSimpleContext dbContext)
        {
            _dbContext = dbContext;
        }



        public async Task <List<Customer>> GetAllCustomer()
        {

            return await _dbContext.Customers.ToListAsync();

        }

        public async Task<Customer> GetSinlgeCustomer(int id)
        {
            return await _dbContext.Customers.FindAsync(id);

        }

        public async Task<Customer> AddCustomer(Customer customer)
        {
            _dbContext.Customers.Add(customer);
           await  _dbContext.SaveChangesAsync();
            return (customer);
        }

        public async Task<bool> UpdateCustomer()
        {

           await  _dbContext.SaveChangesAsync();
           return true;

        }


        public async Task< Customer> DeleteCustomer(Customer customer)
        {
            _dbContext.Customers.Remove(customer);
            await _dbContext.SaveChangesAsync();
            return customer;
        }

    }


}