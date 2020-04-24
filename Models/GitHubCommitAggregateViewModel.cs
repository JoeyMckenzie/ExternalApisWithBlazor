using System.Collections.Generic;

namespace ExternalApisWithBlazor.Models
{
    public class GitHubCommitAggregateViewModel
    {
        public GitHubCommitAggregateViewModel(string repository, IEnumerable<GitHubCommitViewModel> commits) =>
            (Repository, Commits) = (repository, commits);
        public string Repository { get; }

        public IEnumerable<GitHubCommitViewModel> Commits { get; }
    }
}
