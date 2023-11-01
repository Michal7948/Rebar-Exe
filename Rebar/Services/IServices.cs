
namespace Services
{
    public interface IServices<T>
    {
        List<T> GetList();
        T GetById(string id);
        void Create(T shake);
        void Update(string id, T shake);
        void Delete(string id);
    }
}
