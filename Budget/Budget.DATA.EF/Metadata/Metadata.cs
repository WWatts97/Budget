using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget.DATA.EF
{
    public class EventMetadata
    {

    }

    public class EventTypeMetadata
    {
        
    }

    public class UserMetadata
    {
        public int UserId { get; set; }

        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;

		[DisplayFormat(DataFormatString = "{0:c}", ApplyFormatInEditMode = true, NullDisplayText = "[N/A]")]
		[Range(0, (double)decimal.MaxValue)]
		[DataType(DataType.Currency)]
		public decimal? Balance { get; set; }

        [DisplayFormat(DataFormatString = "{0:c}", ApplyFormatInEditMode = true, NullDisplayText = "[N/A]")]
        [Range(0, (double)decimal.MaxValue)]
        [DataType(DataType.Currency)]
        public decimal? Salary { get; set; }
    }

    public class UserEventMetadata
    {

    }
}
