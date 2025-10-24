using GymManagementDAL.Data.Contexts;
using GymManagementDAL.Data.Repositories.Interfaces;
using GymManagementDAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace GymManagementDAL.Data.Repositories.Classes
{
    public class PlanRepository : IPlanRepository
    {
        private readonly GymContext _context;

        public PlanRepository(GymContext context)
        {
            _context = context;
        }
        public IEnumerable<Plan> GetAll() => _context.Set<Plan>().AsNoTracking().ToList();

        public Plan? GetById(int id) => _context.Set<Plan>().Find();

        public int update(Plan plan)
        {
            _context.Set<Plan>().Update(plan);
            return _context.SaveChanges();
        }
    }
}
