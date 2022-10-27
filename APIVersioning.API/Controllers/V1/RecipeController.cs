using Microsoft.AspNetCore.Mvc;

namespace APIVersioning.API.Controllers.V1
{
    [ApiController]
    [Route("v{version:apiVersion}/api/recipes")]
    [ApiVersion("1.0")]
    public class RecipeController : ControllerBase
    {
        public RecipeController()
        {

        }

        [MapToApiVersion("1.0")]
        [HttpGet]
        public IActionResult GetV1()
        {
            

            return Ok();
        }
    }
}
