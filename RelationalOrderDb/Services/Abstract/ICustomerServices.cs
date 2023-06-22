using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
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
    public interface ICustomerServices
    {
        public Task<CustomerListResponceDTO> GetAllCustomerServices();
        public Task <CustomerResponceDTO> GetSingleCustomer(int id);
        public Task <CustomerResponceDTO> AddCustomer(CustomerDTO customerDTO);
        public Task <CustomerResponceDTO> UpdateCustomer(int id, CustomerDTO customerDTO);
        public Task <CustomerResponceDTO> DeleteCustomer(int id);


    }
}