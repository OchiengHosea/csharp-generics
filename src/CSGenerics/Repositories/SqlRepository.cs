using System;
using System.Collections.Generic;
using System.Linq;
using CSGenerics.Interfaces;
using Microsoft.EntityFrameworkCore;


// use of class constraint
namespace CSGenerics
{
    public class SqlRepository<T>: IRepository<T> where T: class, IEntity
    {
        private readonly DbContext _dbContext;
        private readonly DbSet<T> _dbSet;

        public SqlRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
        }

        public void Add(T item)
        {
            _dbSet.Add(item);
        }
        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public void Remove(T item)
        {
            _dbSet.Remove(item);
        }

        public void Save()
        {
           _dbContext.SaveChanges();
        }
    }
}