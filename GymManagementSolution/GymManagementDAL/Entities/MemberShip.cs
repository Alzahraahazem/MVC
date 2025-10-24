using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementDAL.Entities
{
    public class MemberShip : BaseEntity
    {
        //CreatedAt=> StartDate
        public DateTime EndDate { get; set; }

        public string status
        {
            get
            {
                if (EndDate >= DateTime.Now)
                    return "Expired";
                else
                    return "Active";
            }
        }
        public Member Member { get; set; } = null!;
        public int  MemberId { get; set; }
        public Plan Plan { get; set; } = null!;
        public int  PlanId { get; set; }


    }
}
