using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Data.Repositories
{
    public abstract class CrudRepository<T> where T:class
    {
        private readonly PresetDbContext _dbContext;
        private readonly DbSet<T> _dbSet;
        
        public CrudRepository(PresetDbContext dbContext, DbSet<T> dbSet)
        {
            _dbContext = dbContext;
            _dbSet = dbSet;
        }

        //Returns everything from the table
        public IQueryable<T> GetAll()
        {
            return _dbSet.AsQueryable(); 
        }

        //Returns everything that meets the given predicate from the table
        public IQueryable<T> GetAll(Expression<Func<T,bool>> predicate)
        {
            return _dbSet.Where(predicate).AsQueryable(); 
        }

        //Returns the element with the given id
        public T GetById(int id)
        {
            return _dbSet.Find(id); 
        }

        //Returns the first element from the table that meets the predicate, or null
        public T GetOne(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.FirstOrDefault(predicate); 
        }

        //Returns the amount of elements from the table
        public int Count()
        {
            return _dbSet.Count();                  
        }

        //Returns the amount of elements that meet the given predicate
        public int Count(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.Where(predicate).Count(); 
        }

        //Adds the given entity to the table
        public void Add(T entity)
        {
            _dbSet.Add(entity);                     
            _dbContext.SaveChanges();
        }

        //Updates the given entity
        public void Update(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        //Removes the given entity from the table
        public void Remove(T entity)
        {
            _dbSet.Remove(entity);                  
            _dbContext.SaveChanges(); 
        }
    }
}
