using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using take_test.API.Services;
using take_test.API.Domain.Model;
using take_test.API.Domain.Services;
using Newtonsoft.Json;

namespace take_test.Controllers
{
    [Route("/api")]
    [Produces("application/json")]
    [ApiController]
    public class TakeTestController : Controller
    {
        private readonly IGitHubAccessService _gitHubAccessService;

        public TakeTestController (IGitHubAccessService gitHubAccessService){
            _gitHubAccessService = gitHubAccessService;
        }

        [HttpGet]
        [Route("/carousel")]
        public async Task<Carousel> getCarouselData(){
            var carouselData = await _gitHubAccessService.GetCarouselAsync();
            return carouselData;
        }
    }
}