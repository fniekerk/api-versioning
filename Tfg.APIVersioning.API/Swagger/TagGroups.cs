using MicroElements.Swashbuckle.FluentValidation;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Exceptions;
using Microsoft.OpenApi.Extensions;
using Microsoft.OpenApi.Interfaces;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Diagnostics;

namespace Tfg.APIVersioning.API.Swagger
{
    public class TagGroups : IDocumentFilter
    {
        public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
        {
            var recipeTagList = CreateTagArr(new List<string> { "recipe_model" });
            var genTagList = CreateTagArr(new List<string> { "Recipe" });
            var xTagGroups = CreateCustomTag(new Dictionary<string, OpenApiArray>
            {
                { "General", genTagList },
                { "Models", recipeTagList }
            });

            swaggerDoc.Extensions = CreateExtension(new Dictionary<string, OpenApiArray> { { "x-tagGroups",  xTagGroups } });

            swaggerDoc.Tags.Add(CreateGlobalTag("recipe_model",
                   "<SchemaDefinition schemaRef=\"#/components/schemas/Recipe\" />",
                    new Dictionary<string, IOpenApiExtension>
                    {
                        { "x-displayName", new OpenApiString("The Recipe Model") }
                    })
            );
        }

        private OpenApiTag CreateGlobalTag(string tagName, string tagDescription, Dictionary<string, IOpenApiExtension> tagExt)
        {
            var globalTag = new OpenApiTag
            {
                Name = tagName,
                Description = tagDescription,
                Extensions = tagExt
            };

            return globalTag;
        }

        private static OpenApiArray CreateTagArr(List<string> tagList)
        {
            var tagArr = new OpenApiArray();
            foreach(var tag in tagList)
            {
                tagArr.Add(new OpenApiString(tag));
            }

            return tagArr;
        }


        private static OpenApiArray CreateCustomTag (Dictionary<string, OpenApiArray> tags)
        {
            OpenApiArray customTag = new OpenApiArray();

            foreach(var tag in tags)
            {
                customTag.Add(new OpenApiObject
                {
                    ["name"] = new OpenApiString(tag.Key),
                    ["tags"] = tag.Value
                });
            }

            return customTag;
        }

        private static IDictionary<string, IOpenApiExtension> CreateExtension(Dictionary<string, OpenApiArray> customExts)
        {
            var customExtCreated = new Dictionary<string, IOpenApiExtension>();

            foreach(var customExt in customExts)
            {
                customExtCreated.Add(customExt.Key, customExt.Value);
            }

            return customExtCreated;
        }
    }
}
