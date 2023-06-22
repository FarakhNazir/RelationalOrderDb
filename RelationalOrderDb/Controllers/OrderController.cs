using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RelationalOrderDb.Models;
using RelationalOrderDb.DTO;
using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RelationalOrderDb.Services.Abstract;
using RelationalOrderDb.Repositroy;
using RelationalOrderDb.Controllers;
using RelationalOrderDb.Services;

namespace RelationalOrderDb.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class OrderController : Controller
    {
        #region Private Attribute
        //public readonly OrderSimpleContext _dbcontext;
        private readonly IOrderServices _iOrderServices;
        #endregion

        #region  Constructor
        public OrderController(OrderSimpleContext orderSimpleContext, IOrderServices iOrderServices)
        {
           // this._dbcontext = orderSimpleContext;
            _iOrderServices = iOrderServices;
        }
        #endregion

       // #region  Orders
        #region  Get Orders Records

        [HttpGet("orders")]
        public IEnumerable<Order> GetAllOrders()
        {
            return _iOrderServices.GetAllOrderServices();
            // try
            // {
            //     return Ok(await _dbcontext.Orders.ToListAsync());
            // }
            // catch (Exception e)
            // {
            //     return Problem(e.Message);
            // }

        } 
#endregion
#region 
        // [HttpGet("SingleOrder/{id}")]
        //  public async Task<IActionResult> GetSingleOreder([FromRoute] int id)
        // {
        //     try
        //     {
        //         var varOrder = await _dbcontext.Orders.FindAsync(id);
        //         if (varOrder != null)
        //         {
        //             return Ok(varOrder);

        //         }
        //         return NotFound();


        //     }
        //     catch (Exception e)
        //     {
        //         return Problem(e.Message);
        //     }
        // }
        // #endregion

        // #region Add New Order
        // [HttpPost("AddOrder")]
        // public async Task<IActionResult> AddOrder(OrderDTO  orderdto)
        // {
        //     try
        //     {
        //         var addOrder = new Order()
        //         {
        //             OrderDate = DateTime.Now,
        //             OrderNumber = orderdto.OrderNumber,
        //             CustomerId = orderdto.CustomerId,
        //             TotalAmount = orderdto.TotalAmount
        //         };
        //         await _dbcontext.Orders.AddAsync(addOrder);
        //         await _dbcontext.SaveChangesAsync();
        //         return Ok(addOrder);
        //     }
        //     catch (Exception e)
        //     {
        //         return Problem(e.Message);
        //     }
        // }
        // #endregion

        // #region Update Order Record
        // [HttpPut("Update Record/{id}")]
        // public async Task<IActionResult> UpdateOrder([FromRoute] int id, OrderDTO _orderdto)
        // {
        //     try
        //     {

        //         var updateorder = await _dbcontext.Orders.FindAsync(id);
        //         if(updateorder != null)
        //         {
        //             updateorder.OrderDate = DateTime.Now;
        //             updateorder.OrderNumber = _orderdto.OrderNumber;
        //             updateorder.CustomerId = _orderdto.CustomerId;
        //             updateorder.TotalAmount = _orderdto.TotalAmount;

        //             await _dbcontext.SaveChangesAsync();
        //             return Ok(updateorder);

        //         }
        //         return NotFound();
        //     }
        //     catch (Exception e)
        //     {
        //         return Problem(e.Message);
        //     }

        // }
        // #endregion

        // #region Delete Order Record
        // [HttpDelete("DeleteOrder/{id}")]
        // public async Task<IActionResult> DeleteOrder([FromRoute] int id)
        // {
        //     try
        //     {
        //         var deleteOrder = await _dbcontext.Orders.FindAsync(id);
        //         if(deleteOrder !=null)
        //         {
        //             _dbcontext.Orders.Remove(deleteOrder);
        //             await _dbcontext.SaveChangesAsync();
        //             return Ok(deleteOrder);

        //         }

        //         return NotFound();
        //     }

        //     catch (Exception e)
        //     {
        //         return Problem(e.Message);
        //     }
        // }
        // #endregion

    #endregion

    #region  Order Items
        #region  Get OrderItems Records

        [HttpGet("Get Top 50 OrderItems")]
        public IEnumerable<OrderItem> GetAllOrderItems()
        {
            return _iOrderServices.GetAllOrderItemsServices();
            // try
            // {
            //     return Ok(await _dbcontext.OrderItems.ToListAsync());
            // }
            // catch (Exception e)
            // {
            //     return Problem(e.Message);
            // }

        }

        // [HttpGet("Get Top 50 OrderItems")]
        // public async Task<IActionResult> GEttop50orderitem()
        // {
        //     try
        //     {
        //         return Ok(await _dbcontext.OrderItems.Take(50).ToListAsync());
        //     }
        //     catch (Exception e)
        //     {
        //         return Problem(e.Message);
        //     }

        // }

        // [HttpGet("GetSingleOrderItem/{id}")]
        // public async Task<IActionResult> GetSingleOrderItem([FromRoute] int id)
        // {
        //     try
        //     {
        //         var singleorderitem = await _dbcontext.OrderItems.FindAsync(id);
        //         if(singleorderitem != null)
        //         {
        //             return Ok(singleorderitem);
        //         }
        //         return NotFound();
        //     }
        //     catch (Exception e)
        //     {
        //         return Problem(e.Message);
        //     }

        // }

        // [HttpGet("Get OrderItem with same order number/{id}")]
        // public async Task<IActionResult> GetsameorderOrderItem([FromRoute] int id)
        // {
        //     try
        //     {
        //         // var q=(from pd in dataContext.tblProducts 
        //         // join od in dataContext.tblOrders on pd.ProductID equals od.ProductID 
        //         // join ct in dataContext.tblCustomers on od.CustomerID equals ct.CustID 
        //         // orderby od.OrderID 
        //         // select new { 
        //         // od.OrderID,
        //         // pd.ProductID,
        //         // pd.Name,
        //         // pd.UnitPrice,
        //         // od.Quantity,
        //         // od.Price,
        //         // Customer=ct.Name //define anonymous type Customer
        //         // }).ToList(); 
        //         var sameorderOrderItem = await (from oi in _dbcontext.OrderItems
        //         join od in _dbcontext.Orders on oi.OrderId equals id
        //         join pd in _dbcontext.Products on oi.ProductId equals pd.Id
        //         select new {
        //             oi.OrderId,
        //             oi.ProductId,
        //             oi.UnitPrice,
        //             oi.Quantity,
        //             od.CustomerId,
        //             pd.ProductName,
        //             pd.Package,
        //             pd.IsDiscontinued
        //         }).Take(50).ToListAsync();
                
        //         if(sameorderOrderItem != null)
        //         {
        //             return Ok(sameorderOrderItem);
        //         }
        //         return NotFound();
        //     }

        //     catch (Exception e)
        //     {
        //         return Problem(e.Message);
        //     }

        // }



        // #endregion
  
        // #region Add New Order Item

        // [HttpPost("Add New Order Record")]
        // public async Task<IActionResult> AddOrderItem(OrderItemDTO _orderItemdto)
        // {
        //     try
        //     { 
        //         var addOrderitem = new OrderItem()
        //         {
        //              OrderId   = _orderItemdto.OrderId,
        //              ProductId = _orderItemdto.ProductId,
        //              UnitPrice = _orderItemdto.UnitPrice,
        //              Quantity  = _orderItemdto.Quantity
        //         };
        //        await _dbcontext.OrderItems.AddAsync(addOrderitem);
        //        await _dbcontext.SaveChangesAsync();
        //        return Ok(addOrderitem);
                
        //     }
        //     catch(Exception e)
        //     {
        //         return Problem(e.Message);
        //     }
        // }
        // #endregion

        // #region  Update Order Item Record

        // [HttpPut("UpdateOrderItem/{id}")]
        // public async Task<IActionResult> UpdateOrderItem([FromRoute] int id, OrderItemDTO _orderItemdto)
        // {
        //     try
        //     {
        //         var updateorderitem = await _dbcontext.OrderItems.FindAsync(id);
        //         if(updateorderitem != null)
        //         {
        //             updateorderitem.OrderId   = _orderItemdto.OrderId;
        //             updateorderitem.ProductId = _orderItemdto.ProductId;
        //             updateorderitem.UnitPrice = _orderItemdto.UnitPrice;
        //             updateorderitem.Quantity  = _orderItemdto.Quantity;

        //             await _dbcontext.SaveChangesAsync();
        //             return Ok(updateorderitem);
        //         }
        //         return NotFound();

        //     }
        //     catch(Exception e)
        //     {
        //         return Problem(e.Message);
        //     }
        // }
        // #endregion

        // #region Delete Order Item Record

        // [HttpDelete("DeleteOrderItemRecord/{id}")]

        // public async Task<IActionResult> DeleteOrderItem([FromRoute] int id)
        // {
        //     try
        //     {
        //         var deleteOrderItem = await _dbcontext.OrderItems.FindAsync(id);
        //         if(deleteOrderItem != null)
        //         {
        //             _dbcontext.OrderItems.Remove(deleteOrderItem);
        //             await _dbcontext.SaveChangesAsync();
        //             return Ok(deleteOrderItem);
        //         }
        //         return NotFound();
        //     }
        //     catch(Exception e)
        //     {
        //         return Problem(e.Message);
        //     }
        // }


        #endregion
        
    #endregion

    }
}