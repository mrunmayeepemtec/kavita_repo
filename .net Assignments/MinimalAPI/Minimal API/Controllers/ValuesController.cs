using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Minimal_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public int Get() => new CalcCoreStandard.CalcCore().Add(2, 3);
    }
}
