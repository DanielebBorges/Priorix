using Microsoft.AspNetCore.Mvc;
using Priorix.Core.Services;
using Priorix.Core.Interfaces;

namespace Priorix.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaskHistoryController : ControllerBase
    {
        private readonly TaskHistoryService _historyService;

        public TaskHistoryController(ITaskHistoryRepository historyRepository)
        {
            _historyService = new TaskHistoryService(historyRepository);
        }

        [HttpGet("{taskId}")]
        public IActionResult GetHistory(int taskId)
        {
            var history = _historyService.GetHistory(taskId);
            return Ok(history);
        }
    }
}

