using MicroElements.Swashbuckle.FluentValidation;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Exceptions;
using Microsoft.OpenApi.Extensions;
using Microsoft.OpenApi.Interfaces;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Tfg.APIVersioning.API.Swagger
{
    public class TagGroups : IDocumentFilter
    {
        public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
        {
            var tagList = new OpenApiArray
            {
                new OpenApiString("recipe_model")
            };

            var genTagList = new OpenApiArray
            {
                new OpenApiString("Recipe")
            };

            swaggerDoc.Extensions = new Dictionary<string, IOpenApiExtension>
            {
                {
                    "x-tagGroups",
                    new OpenApiArray
                    {
                        new OpenApiObject
                        {
                            ["name"] = new OpenApiString("Models"),
                            ["tags"] = tagList
                        },
                        new OpenApiObject
                        {
                            ["name"] = new OpenApiString("General"),
                            ["tags"] = genTagList
                        }
                    }
                }
            };

            swaggerDoc.Tags.Add(
                new OpenApiTag
                {
                    Name = "recipe_model",
                    Description = "<SchemaDefinition schemaRef=\"#/components/schemas/Recipe\" />",
                    Extensions = new Dictionary<string, IOpenApiExtension>
                    { 
                        { "x-displayName", new OpenApiString("The Recipe Model") }
                    }
                }
            );
        }
    }
}
