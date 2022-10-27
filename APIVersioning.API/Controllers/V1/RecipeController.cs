﻿using APIVersioning.Models.RecipeV1;
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

            return Ok(recipes);
        }
    }
}
