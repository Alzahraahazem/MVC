using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymManagementDAL.Data.Repositories.Interfaces;
using GymManagementDAL.Entities;
namespace GymManagementDAL.Data.Reposetries.Interfaces
{
    public interface IMemberRepository : IGenericRepository<Member>
    {
      //لو عايز اضيف حاجه مش موجوده ف ال  generic repository
    }
}
