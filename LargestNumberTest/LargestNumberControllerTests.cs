using FindLargestNumberAPI.Controllers;
using FindLargestNumberAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Moq;

namespace LargestNumberTest
{
    public class LargestNumberControllerTests
    {
        [Fact]
        public void GetLargestNumber_ReturnOk()
        {
           // Arrange 
            FormLargestIntController a = new FormLargestIntController();
            InputArrayDto input = new InputArrayDto();
            input.Items = new List<int>() { 1, 2, 3 };

            // Act
            var output = a.GetLargestNumber(input);

            // Assert
            var actionResult = Assert.IsType<ActionResult<string>>(output);
            var okObjectResult = Assert.IsType<OkObjectResult>(actionResult.Result);
            Assert.Equal("321", okObjectResult.Value);
            
        }
        [Fact]
        public void GetLargestNumber_ReturnNoInput()
        {
            // Arrange 
            FormLargestIntController a = new FormLargestIntController();
            InputArrayDto input = new InputArrayDto();
            input.Items = new List<int>() {  };

            // Act
            ActionResult<string> output = a.GetLargestNumber(input);

            //Assert
            var actionResult = Assert.IsType<ActionResult<string>>(output);
            var objectResult = Assert.IsType<BadRequestObjectResult>(actionResult.Result);

            Assert.Equal("No Input", objectResult.Value);

        }
        [Fact]
        public void GetLargestNumber_ReturnNegativeValues()
        {
            // Arrange 
            FormLargestIntController a = new FormLargestIntController();
            InputArrayDto input = new InputArrayDto();
            input.Items = new List<int>() { 5, -6};

            // Act
            ActionResult<string> output = a.GetLargestNumber(input);

            // Assert
            var actionResult = Assert.IsType<ActionResult<string>>(output);
            var objectResult = Assert.IsType<BadRequestObjectResult>(actionResult.Result);
            Assert.Equal("Negative numbers in input", objectResult.Value);

        }
    }
}