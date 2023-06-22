using System;
using System.Collections.Generic;

namespace RelationalOrderDb.Models;

public partial class Customer
{
    public int Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string? Country { get; set; }
    public string? City { get; set; }
    public string? Phone { get; set; }
    public virtual ICollection<Order> Orders { get; } = new List<Order>();
}
