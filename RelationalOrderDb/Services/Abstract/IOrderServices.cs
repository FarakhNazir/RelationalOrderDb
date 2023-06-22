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
namespace RelationalOrderDb.Services.Abstract
{
    public interface IOrderServices
    {
        public List<Order> GetAllOrderServices();
        public List<OrderItem> GetAllOrderItemsServices();

    }
}