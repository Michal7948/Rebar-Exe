

namespace Repositories
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        T GetById(Guid id);
        void Create(T objToCreate);
        void Update( Guid id,T objToUpdate);
        void Delete(Guid id);
    }
}
