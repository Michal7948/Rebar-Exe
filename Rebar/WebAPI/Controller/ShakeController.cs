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
        IShakeService service;
        public ShakeController(IShakeService services)
        {
            this.service = services;
        }

        [HttpGet]
        public ActionResult<List<Shake>> GetAll()
        {
            return service.GetList();
        }

        [HttpGet("{id}")]
        public ActionResult<Shake> GetById(Guid id)
        {
            var shake = service.GetById(id);
            if(shake == null)
            {
                return NotFound($"shake with Id = {id} not found");
            }
            return shake;
        }

        [HttpPost]
        public ActionResult Post([FromBody] Shake shake)
        {
            service.Create(shake);
            //return CreatedAtAction(nameof(GetById), new { id = shake.Id }, shake);
            return Ok($"Shake with created");
        }

        [HttpPut("{id}")]
        public ActionResult Put(Guid id ,[FromBody] Shake shake)
        {
            var existingShake = service.GetById(id);
            if (existingShake == null)
            {
                return NotFound($"shake with Id = {id} not found");
            }
            service.Update(id, shake);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            var shake = service.GetById(id);
            if (shake == null)
            {
                return NotFound($"shake with Id = {id} not found");
            }
            service.Delete(shake.Id);
            return Ok($"Shake with Id= {id} deleted");
        }



    }
}
