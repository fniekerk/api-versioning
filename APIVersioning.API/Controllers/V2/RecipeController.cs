using Microsoft.AspNetCore.Mvc;

namespace APIVersioning.API.Controllers.V2
{
    [ApiController]
    [Route("v{version:apiVersion}/api/recipes")]
    [ApiVersion("2.0")]
    public class RecipeController : ControllerBase
    {
        public RecipeController()
        {

        }

        [MapToApiVersion("2.0")]
        [HttpGet]
        public IActionResult GetV2()
        {


            return Ok();
        }
    }
}
