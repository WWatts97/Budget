using System;
using System.Collections.Generic;

namespace Budget.DATA.EF.Models
{
    public partial class Event
    {
        public Event()
        {
            UserEvents = new HashSet<UserEvent>();
        }

        public int EventId { get; set; }
        public int? EventTypeId { get; set; }
        public string EventName { get; set; } = null!;
        public string? EventDesc { get; set; }
        public DateTime? RecurringDate { get; set; }
        public decimal? Amount { get; set; }
        public int? PaymentsRemaining { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? PaidDate { get; set; }
        public bool? Paid { get; set; }
        public decimal? BalanceRemaining { get; set; }

        public virtual EventType? EventType { get; set; }
        public virtual ICollection<UserEvent> UserEvents { get; set; }
    }
}
