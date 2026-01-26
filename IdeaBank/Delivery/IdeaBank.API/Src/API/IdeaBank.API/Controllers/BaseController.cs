using Asp.Versioning;

namespace IdeaBank.API.Controllers
{

    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [Authorize]
    public class BaseController : ControllerBase
    {
       
    }
}
