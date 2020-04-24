using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using ExternalApisWithBlazor.Models;
using Microsoft.AspNetCore.Components;

namespace ExternalApisWithBlazor.Services
{
    public class GitHubService
    {
        private const string BaseUrl = "https://api.github.com/";
        private readonly HttpClient _httpClient;

        public GitHubService(HttpClient httpClient) =>
            _httpClient = httpClient;

        public async Task<IEnumerable<GitHubRepositoryViewModel>> GetRepositoriesAsync(string user)
        {
            // Simulate some network traffic
            await Task.Delay(TimeSpan.FromMilliseconds(1000));

            var repositories = await _httpClient.GetJsonAsync<IEnumerable<GitHubRepository>>($"{BaseUrl}/users/{user}/repos");

            if (repositories is null)
            {
                throw new HttpRequestException("Repositories not returned on response");
            }

            // Project each repository resource model from the GitHub API into our view model for the page
            return repositories.Select(r => new GitHubRepositoryViewModel(r.Name, r.UpdatedAt.DateTime, (int)r.StargazersCount));
        }

        public async Task<GitHubCommitAggregateViewModel> GetCommitsAsync(string repositoryName)
        {
            // Simulate some network traffic
            await Task.Delay(TimeSpan.FromMilliseconds(1000));
            List<GitHubCommitViewModel> commits;

            if (string.Equals(repositoryName, _repositories[0].Name))
            {
                commits = new List<GitHubCommitViewModel>
                    {
                        new GitHubCommitViewModel("abc123", "https://github.com", "joey32793", "feat(Core): Add FluentValidation library"),
                        new GitHubCommitViewModel("def456", "https://github.com", "joey32793", "chore(UI): Refactor login screen"),
                    };

                return new GitHubCommitAggregateViewModel(repositoryName, commits);
            }
            else if (string.Equals(repositoryName, _repositories[1].Name))
            {
                commits = new List<GitHubCommitViewModel>
                    {
                        new GitHubCommitViewModel("jkl987", "https://github.com", "user123", "chore(Build): Fix failing Azure Pipelines build"),
                        new GitHubCommitViewModel("qwe678", "https://github.com", "user456", "feat(Infrastructure): Add email service"),
                    };

                return new GitHubCommitAggregateViewModel(repositoryName, commits);
            }
            else
            {
                return new GitHubCommitAggregateViewModel(repositoryName, new List<GitHubCommitViewModel>());
            }
        }
    }
}
