using jobdone_backend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace jobdone_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobController : ControllerBase
    {
        [HttpPost("SaveCompletedJob")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult SaveCompletedJob([FromBody] JobSave jobSave)
        {
            if (jobSave == null)
            {
                var errResponse = new ApiResponse
                {
                    StatusCode = StatusCodes.Status400BadRequest,
                    Message = "Job data is null.",
                    IsSuccess = true
                };
                return BadRequest(errResponse);
            }

            //create DB connection to save the data

            var response = new ApiResponse
            {
                StatusCode = StatusCodes.Status200OK,
                Message = "Job saved success.",
                IsSuccess = true
            };

            return Ok(response);
        }

        [HttpGet("GetAllJobs")]
        public IActionResult GetAllJobs()
        {
            return Ok(new JsonResult(new { message = "GetAllJobs API is working..." }));
        }

        [HttpGet("GetAllJobsWithFilter")]
        public IActionResult GetAllJobsWithFilter()
        {
            return Ok(new JsonResult(new { message = "GetAllJobsWithFilter API is working..." }));
        }
    }
}
