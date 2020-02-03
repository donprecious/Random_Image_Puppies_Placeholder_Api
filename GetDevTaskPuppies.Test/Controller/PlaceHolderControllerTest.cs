using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using GetDevTaskPuppies.Controllers;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace GetDevTaskPuppies.Test.Controller
{
   public class PlaceHolderControllerTest
   {
       private readonly PlaceholderController _controller;

       public PlaceHolderControllerTest()
       {
           _controller = new PlaceholderController();
       }

       [Theory]
       [InlineData(200, 200)]
       [InlineData(100, 150)]
       public async Task ShouldReturnNewImageString(int width, int height)
       {
           //Arrange 

           //Act 
           var result = await _controller.Get(width, height);

           //Assert
           var okResult = Assert.IsType<OkObjectResult>(result);
           Assert.True(!string.IsNullOrEmpty(okResult.Value.ToString()));

       }
    }
}
