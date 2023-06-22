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

namespace RelationalOrderDb.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class CustomerController : Controller
    {
        #region Private Attribute
        private readonly ICustomerServices _iCustomerServices;
        #endregion

        #region  Constructor
        public CustomerController(OrderSimpleContext dbcontext, ICustomerServices iCustomerServices)
        {
            _iCustomerServices = iCustomerServices;
            // this._dbContext = dbcontext;

        }
        #endregion

        #region   Crud Operations of Customer Records


        //List of All Customers

        [HttpGet("customers")]
        public async Task<CustomerListResponceDTO> GEtAllCustomers()
        {   
            if(!ModelState.IsValid)
            {
                return null;
            }

            return await _iCustomerServices.GetAllCustomerServices();

        }


        //  Get Single Customer
        [HttpGet("SingleCustomer/{id}")]
        public async Task<CustomerResponceDTO> GEtSingleCustomer([FromRoute] int id)
        {
            if(!ModelState.IsValid)
            {

            }

            return await _iCustomerServices.GetSingleCustomer(id);

        }


        //Add Customer 

        [HttpPost("AddCustomer")]
        public async Task<CustomerResponceDTO> AddCustomer(CustomerDTO customerDTO)
        {

            if(!ModelState.IsValid)
            {
                return null;
            }
            return await _iCustomerServices.AddCustomer(customerDTO);

        }


        // Update Customer Record

        [HttpPut]
        [Route("UpdateCustomer/{id}")]
        public async Task< CustomerResponceDTO> UpdateCustomer([FromRoute] int id, CustomerDTO customerDTO)
        {
            if(!ModelState.IsValid)
            {
                return null;
            }
            return await _iCustomerServices.UpdateCustomer(id, customerDTO);

        }


        // Delete Record of Customer

        [HttpDelete("DeleteCustomer/{id}")]
        public async Task<CustomerResponceDTO> DeleteCustomer([FromRoute] int id)
        {

            if(!ModelState.IsValid)
            {
                return null;
            }
            return await _iCustomerServices.DeleteCustomer(id);

        }


        #endregion



    }

}