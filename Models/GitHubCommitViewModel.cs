using System;

namespace ExternalApisWithBlazor.Models
{
    public class GitHubCommitViewModel
    {
        public GitHubCommitViewModel(string sha, string htmlUrl, string commitUser, string commitMessage) =>
            (Sha, HtmlUrl, CommitUser, CommitMessage) = (sha, htmlUrl, commitUser, commitMessage);

        public string Sha { get; }

        public string HtmlUrl { get; }

        public string CommitUser { get; }

        public string CommitMessage { get; }
    }
}
