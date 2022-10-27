using Microsoft.AspNetCore.Mvc;

namespace APIVersioning.API.Controllers.V3
{
    [ApiController]
    [Route("v{version:apiVersion}/api/recipes")]
    [ApiVersion("3.0")]
    public class RecipeController : ControllerBase
    {
        public RecipeController()
        {

        }

        [MapToApiVersion("3.0")]
        [HttpGet]
        public IActionResult GetV3()
        {


            return Ok();
        }
    }
}
