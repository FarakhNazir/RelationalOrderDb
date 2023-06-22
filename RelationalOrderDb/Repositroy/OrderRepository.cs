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
    public class OrderRepository : IOrderRepository
    {
       private readonly OrderSimpleContext _dbContext;

        public OrderRepository(OrderSimpleContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Order> GetAllOrderRepository()
        {
            return _dbContext.Orders.ToList();
        }

         public List<OrderItem> GetAllOrderItemRepository()
        {
            return _dbContext.OrderItems.Take(50).ToList();
        }



        
    }
}