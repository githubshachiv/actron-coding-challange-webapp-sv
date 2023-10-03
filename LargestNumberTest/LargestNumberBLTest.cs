using FindLargestNumberAPI;
using FindLargestNumberAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestNumberTest
{
    public class LargestNumberBLTest
    {
        [Fact]
        public void LargestNumberBLTest_LargestNumberMethod_ReturnsCorrectValue()
        {
            //Arrange
            InputArrayDto input = new InputArrayDto();
            input.Items = new List<int>() { 11, 21, 34 };

            //Act
            string output = LargestNumberClass.LargestNumberMethod(input.Items);

            //Assert
            Assert.Equal("342111", output);
        }

        [Fact]
        public void LargestNumberBLTest_LargestNumberMethod_ReturnsEmptyValue()
        {
            //Arrange
            InputArrayDto input = new InputArrayDto();
            input.Items = new List<int>() { -11, 21, 34 };

            //Act
            string output = LargestNumberClass.LargestNumberMethod(input.Items);

            //Assert
            //Should Return Empty string if negative number is passed
            Assert.Equal("", output);
        }

        [Fact]
        public void LargestNumberBLTest_LargestNumberMethod_ReturnsNothing()
        {
            //Arrange
            InputArrayDto input = new InputArrayDto();
            input.Items = new List<int>() {  };

            //Act
            string output = LargestNumberClass.LargestNumberMethod(input.Items);

            //Assert
            //Should Return Empty string if  no  number is passed
            Assert.Equal("", output);
        }
    }
}
