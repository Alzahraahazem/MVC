using GymManagementDAL.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementDAL.Entities
{
    public class Trainer : GymUser
    {
        //CreatedAt=>HireDate
        public Specialties specialties {  get; set; }

        #region relationship
        public ICollection<Session> ?Sessions { get; set; }

        #endregion
    }
}
