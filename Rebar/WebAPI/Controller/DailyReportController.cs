using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositories.Models;
using Services;

namespace WebAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class DailyReportController : ControllerBase
    {
        IDailyReportService service;
        public DailyReportController(IDailyReportService services)
        {
            this.service = services;
        }

        [HttpGet]
        public ActionResult<List<DailyReport>> GetAll()
        {
            return service.GetList();
        }


        [HttpGet("{id}")]
        public ActionResult<DailyReport> GetById(Guid id)
        {
            var dailyReport = service.GetById(id);
            if (dailyReport == null)
            {
                return NotFound($"daily report with Id = {id} not found");
            }
            return dailyReport;
        }

        [HttpPost]
        public ActionResult Post([FromBody] DailyReport dailyReport)
        {
            service.Create(dailyReport);
            //return CreatedAtAction(nameof(GetById), new { id = dailyReport.Id }, dailyReport);
            return Ok($"daily report with created");
        }

        [HttpPut("{id}")]
        public ActionResult Put(Guid id, [FromBody] DailyReport dailyReport)
        {
            var existingDailyReport = service.GetById(id);
            if (existingDailyReport == null)
            {
                return NotFound($"daily report with Id = {id} not found");
            }
            service.Update(id, dailyReport);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            var dailyReport = service.GetById(id);
            if (dailyReport == null)
            {
                return NotFound($"daily report with Id = {id} not found");
            }
            service.Delete(dailyReport.Id);
            return Ok($"daily report with Id= {id} deleted");
        }
    }
}
