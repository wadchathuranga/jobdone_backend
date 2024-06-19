using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace jobdone_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobController : ControllerBase
    {
        [HttpPost(Name = "SaveCompletedJob")]
        public IEnumerable<Any> SaveCompletedJob()
        {
            return [];
        }

        [HttpGet(Name = "GetAllJobs")]
        public IEnumerable<Any> GetAllJobs()
        {
            return [];
        }

        [HttpGet(Name = "GetAllJobsWithFilter")]
        public IEnumerable<Any> GetAllJobsWithFilter()
        {
            return [];
        }
    }
}
