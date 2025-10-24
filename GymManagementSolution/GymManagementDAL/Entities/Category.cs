using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementDAL.Entities
{
    public class Category : BaseEntity
    {
        public string? Name { get; set; }

        #region relationship
        public ICollection<Session>? sessions { get; set; }

        #endregion
    }
}
