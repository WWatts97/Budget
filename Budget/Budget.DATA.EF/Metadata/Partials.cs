using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget.DATA.EF
{
    [ModelMetadataType(typeof(EventMetadata))]
    public partial class Event { }

    [ModelMetadataType(typeof(EventTypeMetadata))]
    public partial class EventType { }

    [ModelMetadataType(typeof(UserMetadata))]
    public partial class User { }

    [ModelMetadataType(typeof(UserEventMetadata))]
    public partial class UserEvent { }
}
