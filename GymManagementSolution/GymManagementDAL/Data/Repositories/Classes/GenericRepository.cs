using GymManagementDAL.Data.Contexts;
using GymManagementDAL.Data.Repositories.Interfaces;
using GymManagementDAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//new() =>  علشان اقوله انك  entity  فعليه ف الداتابيز مش مجرد  abstract model class
//A concrete class in C# is a standard, non-abstract class that can be directly instantiated to create objects.
namespace GymManagementDAL.Data.Repositories.Classes 
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity
    {


        private readonly GymContext _context;

        public GenericRepository(GymContext context)
        {
            _context = context;
        }
        public int Add(TEntity TEntity)
        {
            _context.Set<TEntity>().Add(TEntity);
            return _context.SaveChanges();


        }

        public int delete(TEntity TEntity)
        {
            _context.Set<TEntity>().Remove(TEntity);
            return _context.SaveChanges();
        }

        public IEnumerable<TEntity> GetAll()=> _context.Set<TEntity>().AsNoTracking().ToList();

        public TEntity? GetById(int id)=> _context.Set<TEntity>().Find();

        public int update(TEntity TEntity)
        {
            _context.Set<TEntity>().Update(TEntity);
            return _context.SaveChanges();
        }
    }
}
