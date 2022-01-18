using CSGenerics.Entities;
namespace CSGenerics.Interfaces
{
    public interface IRepository<T> where T: class, IEntity
    {
        void Add(T item);
        T GetById(int id);
        void Remove(T item);
        void Save();
    }
}