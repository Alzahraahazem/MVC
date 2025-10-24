using GymManagementDAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymManagementDAL.Entities;

namespace GymManagementDAL.Data.Repositories.Interfaces
{
    //new() =>  علشان اقوله انك  entity  فعليه ف الداتابيز مش مجرد  abstract model class
    //A concrete class in C# is a standard, non-abstract class that can be directly instantiated to create objects.
    public interface  IGenericRepository<TEntity>  where TEntity : BaseEntity
    {
        IEnumerable<TEntity> GetAll();

        TEntity? GetById(int id);

        int Add(TEntity TEntity);
        int update(TEntity TEntity);
        int delete(TEntity TEntity);

    }
}
