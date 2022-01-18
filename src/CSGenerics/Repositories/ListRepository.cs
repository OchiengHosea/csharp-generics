using System;
using System.Collections.Generic;
using System.Linq;
using CSGenerics.Entities;
using CSGenerics.Interfaces;
// use of class constraint
namespace CSGenerics
{
    public class ListRepository<T> : IRepository<T> where T: class, IEntity
    {
        private readonly List<T> _items = new();

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
}