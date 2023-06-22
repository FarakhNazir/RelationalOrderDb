using System;
using System.Collections.Generic;


namespace RelationalOrderDb.DTO
{
    public class OrderDTO
    {
    

    public string? OrderNumber { get; set; }

    public int CustomerId { get; set; }

    public decimal? TotalAmount { get; set; }

    }
}