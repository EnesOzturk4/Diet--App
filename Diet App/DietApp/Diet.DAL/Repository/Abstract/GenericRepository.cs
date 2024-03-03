using Diet.DAL.Context.EF;
using Diet.DAL.Entites.Abstract;
using Diet.DAL.Entites.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Diet.DAL.Repository.Abstract
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {

        private DiyetDbContext _dbContext;
        private DbSet<T> _dbSet;
        public GenericRepository(DiyetDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();


        }
        public void Add(T entity)
        {
            entity.DataStatus = Common.DataStatus.Inserted;
            entity.Created = DateTime.Now.Date;
            using (var dbContext = new DiyetDbContext())
            {
                dbContext.Add(entity);
                dbContext.SaveChanges();
            }
        }

        public void Delete(T entity)
        {
            entity.DataStatus = Common.DataStatus.Deleted;
            entity.Deleted = DateTime.Now;
            this.Update(entity);
        }

        public List<T> GetAll()
        {

            return _dbSet.AsNoTracking().Where(c => c.DataStatus != Common.DataStatus.Deleted).ToList();
        }

        public T GetById(int id)
        {
            return _dbSet.AsNoTracking().Single(t => t.Id == id);
        }

        public void Remove(T entity)
        {
            using (var dbContext = new DiyetDbContext())
            {
                var existingEntity = dbContext.Set<T>().Find(entity.Id);
                if (existingEntity != null)
                {
                    dbContext.Set<T>().Remove(existingEntity);
                    dbContext.SaveChanges();
                }
            }
        }
        public List<T> Search(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.Where(predicate).Where(c => c.DataStatus != Common.DataStatus.Deleted).ToList();
        }

        public void Update(T entity)
        {
            entity.DataStatus = entity.DataStatus != Common.DataStatus.Deleted
                          ? Common.DataStatus.Updated : Common.DataStatus.Deleted;

            entity.Modified = DateTime.Now;

            using (var dbContext = new DiyetDbContext())
            {
                var existingEntity = dbContext.Set<T>().Find(entity.Id);
                if (existingEntity != null)
                {
                    dbContext.Entry(existingEntity).CurrentValues.SetValues(entity);
                    //dbContext.Update(existingEntity);
                    dbContext.SaveChanges();
                }
            }
        }
    }
}
