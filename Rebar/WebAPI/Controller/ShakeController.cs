using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositories.Models;
using Services;

namespace WebAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShakeController : ControllerBase
    {
        IShakeService services;
        public ShakeController(IShakeService services)
        {
            this.services = services;
        }

        [HttpGet]
        public List<Shake> GetAll()
        {
            return services.GetList();
        }

        
    }
}
