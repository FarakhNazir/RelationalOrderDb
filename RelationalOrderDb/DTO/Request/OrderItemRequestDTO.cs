using System;
using System.Collections.Generic;

namespace RelationalOrderDb.DTO
{
    public class OrderItemDTO
    {
    public int OrderId { get; set; }

    public int ProductId { get; set; }

    public decimal UnitPrice { get; set; }

    public int Quantity { get; set; }

   
    }
}