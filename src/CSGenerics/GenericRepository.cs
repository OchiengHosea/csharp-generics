using System;
using System.Collections.Generic;

// use of class constraint
namespace CSGenerics
{
    public class GenericRepository<T> where T: EntityBase, new()
    {
        private readonly List<T> _items = new();
        public T GetById(int id)
        {
            return _items.Find(item => item.Id == id);
        }

        public void Remove(T item)
        {
            _items.Remove(item);
        }
    }
}