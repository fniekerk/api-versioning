#region Usings
using APIVersioning.API.Controllers.V3;
using APIVersioning.Entities.RecipeV3;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
#endregion

namespace APIVersioning.Tests.Controllers.V3
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
        public void GetV3_Recipe_Should_Have_Status_Code_200_And_V3_Entity()
        {
            //Act
            var result = (OkObjectResult)_sut.GetV3();

            //Assert
            result.StatusCode.Should().Be(200);
            result.Value.Should().NotBeNull()
                .And.BeOfType<Recipe>();
        }
    }
}