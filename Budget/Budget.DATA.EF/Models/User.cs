using System;
using System.Collections.Generic;

namespace Budget.DATA.EF.Models
{
    public partial class User
    {
        public User()
        {
            UserEvents = new HashSet<UserEvent>();
        }

        public int UserId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public decimal? Balance { get; set; }
        public decimal? Salary { get; set; }

        public virtual ICollection<UserEvent> UserEvents { get; set; }
    }
}
