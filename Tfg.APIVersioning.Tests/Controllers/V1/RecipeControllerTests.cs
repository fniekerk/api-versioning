#region Usings
using APIVersioning.API.Controllers.V1;
using APIVersioning.Entities.RecipeV1;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
#endregion

namespace APIVersioning.Tests.Controllers.V1
{
    public class RecipeControllerTests
    {
        #region Private Properties
        public readonly RecipeController _sut;
        #endregion

        #region Constructor
        public RecipeControllerTests()
        {
            //Arrange
            var _mocklogger = new Mock<ILogger<RecipeController>>();
            _sut = new RecipeController(_mocklogger.Object);
        }
        #endregion

        [Fact]
        public void GetV1_Recipe_Should_Have_Status_Code_200V1_Entity()
        {
            //Act
            var result = (OkObjectResult)_sut.GetV1();

            //Assert
            result.StatusCode.Should().Be(200);
            result.Value.Should().NotBeNull()
                .And.BeOfType<Recipe>();
        }

    }
}