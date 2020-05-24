using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProgramTest.Local_Data.Repo
{
    public abstract class CrudRepository<T> where T : class
    {
        private readonly LocalPresetDbContext _dbContext;
        private readonly DbSet<T> _dbSet;
        public CrudRepository(LocalPresetDbContext dbContext, DbSet<T> dbSet)
        {
            _dbContext = dbContext;
            _dbSet = dbSet;
        }
        /// <summary>
        /// Returns everything
        /// </summary>
        /// <returns></returns>
        public IQueryable<T> GetAll()
        {
            return _dbSet.AsQueryable(); //Returns everything from the table
        }
        /// <summary>
        /// Returns everything, that meets the given predicate
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public IQueryable<T> GetAll(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.Where(predicate).AsQueryable(); //Returns everything,that meets the given predicate, from the table
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id); //Returns the element, with the given id
        }

        public T GetOne(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.FirstOrDefault(predicate); //Returns the first element from the table, that meets the predicate, or null
        }

        public int Count()
        {
            return _dbSet.Count();                  //Returns the amount of elements in the table
        }

        public int Count(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.Where(predicate).Count(); //Returns the amount of elements, that meet the certain predicate
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);                     //Adds the given entity to the table
            _dbContext.SaveChanges();
        }

        public void Update(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified; //idk about this one rly gotta research
            _dbContext.SaveChanges();
        }
        /// <summary>
        /// Removes the given entity from the table.
        /// </summary>
        /// <param name="entity"></param>
        public void Remove(T entity)
        {
            _dbSet.Remove(entity);                  
            _dbContext.SaveChanges();
        }
        /// <summary>
        /// Removes all entities that match the given predicate.
        /// </summary>
        /// <param name="predicate"></param>
        public void Remove(Expression<Func<T, bool>> predicate)
        {
            _dbSet.RemoveRange(_dbSet.Where(predicate));
            _dbContext.SaveChanges();
        }
        public void RemoveById(params int[] ids)
        {
            foreach (var id in ids)
            {
                _dbSet.Remove(_dbSet.Find(id));        //TODO: There should be another way with remove range
            }
            _dbContext.SaveChanges();
        }
    }
}
