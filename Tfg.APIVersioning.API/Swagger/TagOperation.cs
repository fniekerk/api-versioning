using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Tfg.APIVersioning.API.Swagger
{
    public class TagOperation : IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            
            //operation.Tags.Add(new OpenApiTag { Name = "Recipe" });

            //if (context.ApiDescription.ActionDescriptor is ControllerActionDescriptor controllerActionDescriptor)
            //{
            //    var areaName = controllerActionDescriptor.ControllerTypeInfo.GetCustomAttributes(typeof(AreaAttribute), true)
            //                    .Cast<AreaAttribute>().FirstOrDefault();
            //    if (areaName != null)
            //    {
            //        operation.Tags = new List<OpenApiTag> { new OpenApiTag { Name = areaName.RouteValue } };
            //    }
            //    else
            //    {
            //        operation.Tags = new List<OpenApiTag> { new OpenApiTag { Name = controllerActionDescriptor.ControllerName } };
            //    }
            //}
        }
    }
}
