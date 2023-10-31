
namespace Services
{
    public interface IServices<T>
    {
        List<T> GetList();
        T GetById(Guid id);
        void Create(T shake);
        void Update(Guid id, T shake);
        void Delete(Guid id);
    }
}
