using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using ExternalApisWithBlazor.Models;

namespace ExternalApisWithBlazor.Services
{
    public class GitHubService
    {
        private const string BaseUrl = "https://api.github.com/";
        private static readonly List<GitHubRepositoryViewModel> _repositories = new List<GitHubRepositoryViewModel>
            {
                new GitHubRepositoryViewModel("My Super Cool API", DateTime.Today, 1337),
                new GitHubRepositoryViewModel("My Other Super Cool API", DateTime.Today, 9000),
                new GitHubRepositoryViewModel("My Not So Super Cool API", DateTime.Today, 1)
            };

        private readonly HttpClient _httpClient;

        public GitHubService(HttpClient httpClient) =>
            _httpClient = httpClient;

        public async Task<IEnumerable<GitHubRepositoryViewModel>> GetRepositoriesAsync(string user)
        {
            // Simulate some network traffic
            await Task.Delay(TimeSpan.FromMilliseconds(1000));

            return _repositories;
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
