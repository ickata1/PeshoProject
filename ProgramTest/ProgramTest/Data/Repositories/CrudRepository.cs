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

        public IQueryable<T> GetAll()
        {
            return _dbSet.AsQueryable(); //Returns everything from the table
        }

        public IQueryable<T> GetAll(Expression<Func<T,bool>> predicate)
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

        public void Remove(T entity)
        {
            _dbSet.Remove(entity);                  //Removes the given entity from the table
            _dbContext.SaveChanges(); 
        }
    }
}
