using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBooking.Models.Common
{
    /// <summary>
 /// काय: सर्व Entities (Hotel, Room, Booking...) चा सामायिक पालक class.
 /// का: Id, CreatedOn, IsDeleted हे प्रत्येक class मध्ये पुन्हा लिहू नये (DRY).
 /// कुठे: Hotel : BaseEntity अशा प्रकारे वारसा घेतला जातो.
 /// संकल्पना: Inheritance, Abstract class (याचा थेट object बनत नाही).
 /// </summary>
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; } 
    }
}
