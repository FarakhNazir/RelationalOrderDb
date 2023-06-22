using System;
using System.Collections.Generic;



namespace RelationalOrderDb.DTO
{
    public class ProductDTO
    {
    
    public string ProductName { get; set; } = null!;

    public int SupplierId { get; set; }

    public decimal? UnitPrice { get; set; }

    public string? Package { get; set; }

    public bool IsDiscontinued { get; set; }

    
    }
}