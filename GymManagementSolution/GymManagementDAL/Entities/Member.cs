using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementDAL.Entities
{
    public class Member : GymUser
    {
      
        //CreatedAt=>JoinDate
        public string? photo {  get; set; }

        #region relationship
        public required HealthRecord HealthRecord { get; set; } = null!;

        public ICollection<MemberShip>? MemberShip { get; set; }

        public ICollection<Booking>? Booking { get; set; }

        #endregion
      
    }
}
