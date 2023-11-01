

namespace Repositories
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        T GetById(string id);
        void Create(T objToCreate);
        void Update( string id,T objToUpdate);
        void Delete(string id);
    }
}
