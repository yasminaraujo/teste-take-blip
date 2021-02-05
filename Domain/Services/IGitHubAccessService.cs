using System.Collections.Generic;
using System.Threading.Tasks;
using take_test.API.Domain.Model;

namespace take_test.API.Domain.Services
{
    public interface IGitHubAccessService
    {
        Task<List<Repository>> getGitHubRepositoriesData();
    }
}