
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

namespace RelationalOrderDb.Services
{
    public class CustomerServices : ICustomerServices
    {

        private ICustomerRepository _iCustomerRepository;

        public CustomerServices(ICustomerRepository iCustomerRepository)
        {

            _iCustomerRepository = iCustomerRepository;
        }


        public async Task<CustomerListResponceDTO> GetAllCustomerServices()
        {
            try
            {
                var list = await _iCustomerRepository.GetAllCustomer();

                if (list.Count > 0)
                {
                    var customerResponceDtO = new CustomerListResponceDTO()
                    {
                        message = "Request Successfully Compelete",
                        isError = false,
                        data = list

                    };
                    return customerResponceDtO;
                }

                return new CustomerListResponceDTO()
                {
                    message = "No Record Found",
                    isError = true,
                    data = null

                };

            }
            catch (System.Exception e)
            {

                throw e;
            }


        }
        public async Task <CustomerResponceDTO> GetSingleCustomer(int id)
        {
            try
            {
                var sinlgecustomer = await _iCustomerRepository.GetSinlgeCustomer(id);
                if (sinlgecustomer != null)
                {
                    var customerResponceDtO = new CustomerResponceDTO()
                    {
                        message = "Request Successfully Compelete",
                        isError = false,
                        data = sinlgecustomer

                    };
                    return customerResponceDtO;
                }

                return new CustomerResponceDTO()
                {
                    message = "No Recored Found!",
                    isError = true,
                    data = null

                };



            }
            catch (System.Exception e)
            {

                throw e;
            }

        }
        public async Task<CustomerResponceDTO> AddCustomer(CustomerDTO _customerDTO)
        {
            try
            {
                var customer = new Customer()
                {

                    FirstName = _customerDTO.FirstName,
                    LastName = _customerDTO.LastName,
                    City = _customerDTO.City,
                    Country = _customerDTO.Country,
                    Phone = _customerDTO.Phone
                };
                var addcustomer = await _iCustomerRepository.AddCustomer(customer);
                    if (addcustomer != null)
                    {
                        var customerResponceDtO = new CustomerResponceDTO()
                        {
                            message = "Add Customer Successfully",
                            isError = false,
                            data = addcustomer

                        };
                        return customerResponceDtO;
                    }
                    return new CustomerResponceDTO()
                    {
                        message = "Add Customer Request not Succefully Complete. ",
                        isError = true,
                        data = null
                    };
            }

            catch (System.Exception e)
            {

                throw e;
            }

        }

        public async Task<CustomerResponceDTO> UpdateCustomer(int id, CustomerDTO customerDTO)
        {
            try
            {

                var updatedCustomer =  await _iCustomerRepository.GetSinlgeCustomer(id); ;

                if (updatedCustomer != null)
                {
                    updatedCustomer.FirstName = customerDTO.FirstName;
                    updatedCustomer.LastName = customerDTO.LastName;
                    updatedCustomer.Country = customerDTO.Country;
                    updatedCustomer.City = customerDTO.City;
                    updatedCustomer.Phone = customerDTO.Phone;
                    await _iCustomerRepository.UpdateCustomer();

                    var customerResponceDto = new CustomerResponceDTO()
                    {
                        message = "Record Update Successfully",
                        isError = false,
                        data = updatedCustomer
                    };
                    return customerResponceDto;
                }
                return new CustomerResponceDTO()
                {
                    message = "Customer Instance not found that we would update",
                    isError = true,
                    data = null
                };
            }
            catch (System.Exception e)
            {

                throw e;
            }

        }
        public async Task< CustomerResponceDTO> DeleteCustomer(int id)
        {
            try
            {
                var getRecord = await _iCustomerRepository.GetSinlgeCustomer(id);
                if (getRecord != null)
                {

                    var deletedCustomer = await _iCustomerRepository.DeleteCustomer(getRecord);
                    var customerResponceDto = new CustomerResponceDTO()
                    {
                        message = "Record Delete Successfully",
                        isError = false,
                        data = deletedCustomer
                    };
                    return customerResponceDto;

                }
                return new CustomerResponceDTO()
                {
                    message = "Record not Found",
                    isError = true,
                    data = null
                };
            }
            catch (System.Exception e)
            {

                throw e;
            }

        }


    }
}