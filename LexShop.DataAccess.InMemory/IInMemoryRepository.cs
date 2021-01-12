using LexShop.Core.Models;
using System.Linq;

namespace LexShop.DataAccess.InMemory
{
    public interface IInMemoryRepository<T> where T : BaseEntity
    {
        IQueryable<T> Collection();
        void Commit();
        void Delete(string ID);
        T Find(string ID);
        void Insert(T t);
        void Update(T t);
    }
}