using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GetDevTaskPuppies.Cache;
using GetDevTaskPuppies.Services;
using GetDevTaskPuppies.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Refit;

namespace GetDevTaskPuppies.Controllers
{

    [Route("/")]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PlaceholderController : ControllerBase
    {
        
        [Cached(60)]
        [HttpGet("{width?}/{height?}")]
        public async Task<IActionResult> Get(int width =300, int height=300)
        {
            var dogApi = RestService.For<IDogApi>(Constants.BaseUrl);
            var image = await dogApi.Search();
            if (image.Any())
            {
                var imgTrans = ImageTransform.Transform(width, height, image.FirstOrDefault().url);
                return Ok(imgTrans);
            } 
            return Ok();
        }

    }
}