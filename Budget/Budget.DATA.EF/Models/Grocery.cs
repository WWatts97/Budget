using System;
using System.Collections.Generic;

namespace Budget.DATA.EF.Models
{
    public partial class Grocery
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Store { get; set; }
        public decimal? Price { get; set; }
        public string? Unit { get; set; }
        public decimal? Amount { get; set; }
    }
}
