using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace jobdone_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobController : ControllerBase
    {
        [HttpPost("SaveCompletedJob")]
        public IActionResult SaveCompletedJob()
        {
            return Ok(new JsonResult(new { message = "SaveCompletedJob API is working..." }));
        }

        [HttpGet(Name = "GetAllJobs")]
        public IActionResult GetAllJobs()
        {
            return Ok(new JsonResult(new { message = "GetAllJobs API is working..." }));
        }

        [HttpGet(Name = "GetAllJobsWithFilter")]
        public IActionResult GetAllJobsWithFilter()
        {
            return Ok(new JsonResult(new { message = "GetAllJobsWithFilter API is working..." }));
        }
    }
}
