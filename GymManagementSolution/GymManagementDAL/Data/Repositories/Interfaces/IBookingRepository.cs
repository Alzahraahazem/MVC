using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymManagementDAL.Entities;

namespace GymManagementDAL.Data.Repositories.Interfaces
{
    public interface IBookingRepository 
    {
        IEnumerable<Booking> GetAll();

        Booking? GetById(int id);

        int Add(Booking Booking);
        int update(Booking Booking);
        int delete(int id);
    }
}
