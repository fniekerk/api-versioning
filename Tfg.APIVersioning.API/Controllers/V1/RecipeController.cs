# region Usings
using APIVersioning.Entities.RecipeV1;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Tfg.APIVersioning.API.Swagger;
#endregion

namespace APIVersioning.API.Controllers.V1
{
    [ApiController]
    [Route("v{version:apiVersion}/api/recipes")]
    [ApiVersion("1.0")]
    [Produces("application/json")]
    [Consumes("application/json")]
    public class RecipeController : ControllerBase
    {
        #region Private Properties
        private ILogger<RecipeController> _logger;
        #endregion

        #region Constructor
        public RecipeController(ILogger<RecipeController> logger)
        {
            _logger = logger;
        }
        #endregion

        /// <summary>
        /// Returns the default recipe
        /// </summary>
        /// <returns>A newly created TodoItem</returns>
        /// <remarks>
        /// Sample request:
        /// </remarks>
        /// <response code="201">Returns the default recipe for Fire Chicken</response>
        /// <response code="500">Problem with the service</response>
        [MapToApiVersion("1.0")]
        [HttpGet]
        [SwaggerResponse(StatusCodes.Status200OK)]
        [SwaggerResponse(StatusCodes.Status400BadRequest)]
        [SwaggerResponse(StatusCodes.Status409Conflict)]
        [SwaggerResponse(StatusCodes.Status500InternalServerError)]
        [SwaggerResponse(StatusCodes.Status503ServiceUnavailable)]
        public Recipe GetV1()
        {
            try
            {
                var recipes = new Recipe
                {
                    Id = Guid.Parse("f81c2dc0-6e5a-4b83-9ca9-4aacb7494fe6"),
                    Ingredients = new List<string>
                {
                    "3 tbsp extra spicy Korean chili pepper flakes",
                    "2 tbsp regular Korean chili pepper flakes (gochugaru)",
                    "1.5 tbsp sugar",
                    "1 tbsp chicken bouillon powder",
                    "1 tbsp Korean beef stock powder (dasida)",
                    "2 tbsp soy sauce",
                    "1 tbsp oyster sauce",
                    "2 tbsp mirin",
                    "4 tbsp light corn syrup",
                    "minced garlic (2 cloves)",
                    "1/4 tsp black pepper",
                    "2 tbsp Sprite"
                },
                    Name = "CHEESE BULDAK"
                };
                ;
                _logger.LogInformation("Get Recipe Requested!", recipes);

                return recipes;
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, "Oops! Something weird happened.");
                return new Recipe();
            }
        }
    }
}
