using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositories.Models;
using Services;

namespace WebAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        IOrderService service;
        public OrderController(IOrderService services)
        {
            this.service = services;
        }

        [HttpGet]
        public ActionResult<List<Order>> GetAll()
        {
            return service.GetList();
        }

        [HttpGet("{id}")]
        public ActionResult<Order> GetById(Guid id)
        {
            var order = service.GetById(id);
            if (order == null)
            {
                return NotFound($"Order with Id = {id} not found");
            }
            return order;
        }

        [HttpPost]
        public ActionResult Post([FromBody] Order order)
        {
            service.Create(order);
            //return CreatedAtAction(nameof(GetById), new { id = order.Id }, order);
            return Ok($"Order with created");
        }

        [HttpPut("{id}")]
        public ActionResult Put(Guid id, [FromBody] Order order)
        {
            var existingOrder = service.GetById(id);
            if (existingOrder == null)
            {
                return NotFound($"order with Id = {id} not found");
            }
            service.Update(id, order);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            var order = service.GetById(id);
            if (order == null)
            {
                return NotFound($"order with Id = {id} not found");
            }
            service.Delete(order.Id);
            return Ok($"order with Id= {id} deleted");
        }
    }
}
