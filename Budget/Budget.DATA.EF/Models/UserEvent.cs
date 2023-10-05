using System;
using System.Collections.Generic;

namespace Budget.DATA.EF.Models
{
    public partial class UserEvent
    {
        public int UserEventsId { get; set; }
        public int UserId { get; set; }
        public int EventId { get; set; }

        public virtual Event Event { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
