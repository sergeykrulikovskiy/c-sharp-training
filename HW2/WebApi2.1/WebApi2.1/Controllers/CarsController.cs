using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace WebApi2._1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarsController : ControllerBase
    {
        [HttpGet(Name = "GetCarInfo")]
        public IEnumerable<CarsInfo> Get(int resultsCount = 2)
        {
            return Enumerable.Range(1, resultsCount).Select(index => new CarsInfo()).ToArray();
        }
    }
}
