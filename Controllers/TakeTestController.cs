using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using take_test.API.Services;
using take_test.API.Domain.Model;
using take_test.API.Domain.Services;

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
        [ProducesResponseType(typeof(List<Repository>), 200)]
        public async Task<List<Repository>> GetRepositories()
        {
            var repositories = await _gitHubAccessService.getGitHubRepositoriesData();
            return repositories;
        }
    }
}