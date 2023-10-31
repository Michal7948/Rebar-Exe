
using Repositories;
using Repositories.Models;

namespace Services
{
    public class ShakeService : IShakeService
    {
        IShakeRepository repo;
        public ShakeService(IShakeRepository repo)
        {
            this.repo = repo;
        }

        public void Create(Shake shake)
        {
            repo.Create(shake);
            
        }

        public void Delete(string id)
        {
            repo.Delete(id);
        }

        public Shake GetById(string id)
        {
            return repo.GetById(id);
        }

        public List<Shake> GetList()
        {
            return repo.GetAll();
        }

        public void Update(string id,Shake shake)
        {
            repo.Update(id, shake);
        }
    }
}
