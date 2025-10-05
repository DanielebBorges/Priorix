using Priorix.Core.Entities;
using Priorix.Core.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;

namespace Priorix.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StatusController : ControllerBase
    {
        private IStatusesService _statusService;

        public StatusController(IStatusesService statusService)
        {
            _statusService = statusService;
        }

        [HttpGet(Name = "GetStatuses")]
        public IActionResult GetStatuses()
        {
            var statuses = _statusService.GetAllStatuses();
            return Ok(statuses);
        }

        [HttpGet("{id}", Name = "GetStatusById")]
        public IActionResult GetStatusById(int id)
        {
            var status = _statusService.GetStatusById(id);
            if (status == null)
                return NotFound();
            return Ok(status);
        }

        [HttpPost(Name = "CreateStatus")]
        public IActionResult CreateStatus([FromBody] Statuses status)
        {
            _statusService.CreateStatus(status);
            return Ok();
        }

        [HttpPut(Name = "UpdateStatus")]
        public IActionResult UpdateStatus([FromBody] Statuses status)
        {
            _statusService.UpdateStatus(status);
            return Ok();
        }

        [HttpDelete("{id}", Name = "DeleteStatus")]
        public IActionResult DeleteStatus(int id)
        {
            _statusService.DeleteStatus(id);
            return Ok();
        }
    }
}
