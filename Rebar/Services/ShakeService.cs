
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
        public List<Shake> GetList()
        {
            return repo.GetAll();
        }

    }
}
