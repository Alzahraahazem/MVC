using GymManagementDAL.Data.Contexts;
using GymManagementDAL.Data.Reposetries.Interfaces;
using GymManagementDAL.Data.Repositories.Classes;
using GymManagementDAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymManagementDAL.Entities;

namespace GymManagementDAL.Data.Reposetries.Classes
{
    public class MemberRepository : GenericRepository<Member>,     IMemberRepository
    {
        private readonly GymContext _context;

        public MemberRepository(GymContext context) : base(context) 
        {
            _context = context;
        }
    
    }
}
