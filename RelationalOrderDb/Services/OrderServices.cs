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

namespace RelationalOrderDb.Services
{
    public class OrderServices : IOrderServices
    {
       // private OrderSimpleContext _dbContext;
       public IOrderRepository _iOrderRepository;

        public OrderServices(IOrderRepository iOrderRepository)
        {
           // _dbContext = dbContext;
            _iOrderRepository = iOrderRepository;
        }

        public List<Order> GetAllOrderServices()
        {
            return _iOrderRepository.GetAllOrderRepository();
        }
         public List<OrderItem> GetAllOrderItemsServices()
         {
            return _iOrderRepository.GetAllOrderItemRepository();
         }

       
    }
}