using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget.DATA.EF.Models
{
    [ModelMetadataType(typeof(EventMetadata))]
    public partial class Event { }

    [ModelMetadataType(typeof(EventTypeMetadata))]
    public partial class EventType { }

    [ModelMetadataType(typeof(UserMetadata))]
    public partial class User { }

    [ModelMetadataType(typeof(UserEventMetadata))]
    public partial class UserEvent { }

    [ModelMetadataType(typeof(GroceryMetadata))]
    public partial class Grocery 
    {
        [NotMapped]
        [DisplayFormat(DataFormatString = "{0:c}", ApplyFormatInEditMode = false, NullDisplayText = "[N/A]")]
        public decimal? PricePerUnit { get { return Price / Amount; } }
    }
}
