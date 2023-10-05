using System;
using System.Collections.Generic;

namespace Budget.DATA.EF.Models
{
    public partial class EventType
    {
        public EventType()
        {
            Events = new HashSet<Event>();
        }

        public int EventTypeId { get; set; }
        public string EventTypeName { get; set; } = null!;
        public string? EventTypeDesc { get; set; }

        public virtual ICollection<Event> Events { get; set; }
    }
}
