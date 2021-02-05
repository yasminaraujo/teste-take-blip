using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.Extensions.Caching.Memory;
using take_test.API.Domain.Services;
using take_test.API.Domain.Model;

namespace take_test.API.Services
{
    public class GitHubAccessService : IGitHubAccessService
    {
        private static readonly HttpClient client = new HttpClient();
        public GitHubAccessService(){}
        public async Task<List<Repository>> getGitHubRepositoriesData()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");
            
            var task = client.GetStreamAsync("https://api.github.com/orgs/takenet/repos?sort=created&direction=asc");

            var repositories = await JsonSerializer.DeserializeAsync<List<Repository>>(await task);

            var total = repositories.Count;
            repositories.RemoveRange(5,total-5);
            
            return repositories;
        }
    }
}