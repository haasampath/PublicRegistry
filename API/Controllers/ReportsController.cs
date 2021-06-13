using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReportsController : ControllerBase
    {
        public ReportsController()
        {
        }

        [HttpGet]
        public string GetReport() 
        {
            return "aaaaaa";
        }
    }
}