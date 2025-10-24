using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymManagementDAL.Entities;

namespace GymManagementDAL.Data.Repositories.Interfaces
{
    public interface IMemberShipRepository
    {
        IEnumerable<MemberShip> GetAll();

        MemberShip? GetById(int id);

        int Add(MemberShip MemberShip);
        int update(MemberShip MemberShip);
        int delete(int id);
    }
}
