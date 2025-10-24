using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementDAL.Entities
{
    public class Session : BaseEntity
    {
        public string? Description { get; set; }
        public int Capacity { get; set; }
        public DateTime StartDate { get; set; } // not created at because the start of session not related with the creation of session entity
        public DateTime EndDate { get; set; }


        #region relationship
        public Category? Category{ get; set; }
        public int CategoryId { get; set; }

        public Trainer? Trainer { get; set; }
        public int TrainerId { get; set; }

        public ICollection<Booking>? Booking { get; set; }

        #endregion


    }
}
