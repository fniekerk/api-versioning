using APIVersioning.Entities.RecipeV1;
using Swashbuckle.AspNetCore.Filters;

namespace Tfg.APIVersioning.API.Swagger
{
    public class RecipeV1ResponseExample : IMultipleExamplesProvider<Recipe>
    {
        public IEnumerable<SwaggerExample<Recipe>> GetExamples()
        {
            yield return SwaggerExample.Create(
                "Example 1",
                new Recipe
                {
                    Id = Guid.NewGuid(),
                    Ingredients = new List<string>
                        {
                            "1 pound of cylinder shaped rice cake (tteok), bought or homemade.",
                            "4 cups of water\r\n7 large size dried anchovies, with heads and intestines removed",
                            "8 inch dried kelp\r\n⅓ cup hot pepper paste (gochujang)",
                            "1 tablespoon Korean hot pepper flakes (gochugaru) aka “Korean chili flakes”",
                            "1 tablespoon sugar\r\n3 green onions (scallions), cut into 3 inch long pieces",
                            "2 hard boiled eggs, shelled (optional)",
                            "½ pound fish cakes (optional)"
                        },
                    Name = "Tteokbokki"
                });

            yield return SwaggerExample.Create(
                "Example 2",
                new Recipe
                {
                    Id = Guid.NewGuid(),
                    Ingredients = new List<string>
                        {
                            "1 pound of cylinder shaped rice cake (tteok), bought or homemade.",
                            "4 cups of water\r\n7 large size dried anchovies, with heads and intestines removed",
                            "8 inch dried kelp\r\n⅓ cup hot pepper paste (gochujang)",
                            "1 tablespoon Korean hot pepper flakes (gochugaru) aka “Korean chili flakes”",
                            "1 tablespoon sugar\r\n3 green onions (scallions), cut into 3 inch long pieces",
                            "2 hard boiled eggs, shelled (optional)",
                            "½ pound fish cakes (optional)"
                        },
                    Name = "Tteokbokki"
                });
        }
    }
}
