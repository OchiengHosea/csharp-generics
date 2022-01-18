using System;
using System.Collections.Generic;
using System.Linq;
using CSGenerics.Interfaces;

namespace CSGenerics.Repositories
{
    public class GenericRepository<T> where T: class, IEntity
    {
       protected readonly List<T> _items = new();

        public void Add(T item)
        {
            _items.Add(item);
        }
        public T GetById(int id)
        {
            return _items.Single(item => item.Id == id);
        }

        public void Remove(T item)
        {
            _items.Remove(item);
        }

        public void Save()
        {
            foreach(var item in _items)
            {
                System.Console.WriteLine(item);
            }
        }
    }

    // public class GenericRepositoryWithRemove<T> : GenericRepository<T>
    // {
    //     public void Remove(T item)
    //     {
    //         _items.Remove(item);
    //     }
    // }
}