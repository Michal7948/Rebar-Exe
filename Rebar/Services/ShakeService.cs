
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

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Shake GetById(Guid id)
        {
            return repo.GetById(id);
            //throw new NotImplementedException();
        }

        public List<Shake> GetList()
        {
            return repo.GetAll();
        }

        public void Update(Guid id,Shake shake)
        {
            throw new NotImplementedException();
        }
    }
}
