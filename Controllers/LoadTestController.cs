using LoadTestingAPI.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoadTestingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoadTestController : ControllerBase
    {

        private readonly DbHelper _dbHelper;

        public LoadTestController(DbHelper dbHelper)
        {
            _dbHelper = dbHelper;
        }

        [HttpGet("GetResult/{RegistrationNo}")]
        //[HttpGet("GetResult/{rollNumber}")]
        //public IActionResult GetResult(string rollNumber)
        public IActionResult GetResult(string RegistrationNo)
        {
            try
            {
                var result = _dbHelper.GetStudentResult(RegistrationNo);
                //var result = _dbHelper.GetStudentResult(rollNumber);
                if (result == null)
                    return NotFound();
                return Ok(result);
            }
            catch (Exception ex)
            {
               
                throw ex;
            }
        }
    }
}
