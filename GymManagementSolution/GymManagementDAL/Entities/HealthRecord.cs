using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementDAL.Entities
{
    public class HealthRecord : BaseEntity
    {
        //UpdatedAt=>LastUpdate from member bacause 1 to 1 relationship
        public decimal Height { get; set; }
        public decimal weight { get; set; }
        public string? BloodType { get; set; }

        public string? Note {get; set;}

        #region relationship
        public Member Member { get; set; } = null!;

        #endregion

    }
}
