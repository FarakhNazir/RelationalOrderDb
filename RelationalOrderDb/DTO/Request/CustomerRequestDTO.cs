using System;
using System.Collections.Generic;

namespace RelationalOrderDb.DTO
{
    public class CustomerDTO
    {
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string? Country { get; set; }
    public string? City { get; set; }
    public string? Phone { get; set; }
    }
}