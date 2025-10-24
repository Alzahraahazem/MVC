using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GymManagementDAL.Entities
{
    public class Booking : BaseEntity
    {
        //CratedAt=> BookingDate
        public bool IsAttended { get; set; }
        public Member Member { get; set; } = null!;
        public int MemberId { get; set; }

        public Session session { get; set; } = null!;
        public int SessionId { get; set; }
    }
}
