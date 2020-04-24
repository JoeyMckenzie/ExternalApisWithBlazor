using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ExternalApisWithBlazor.Models
{
    public class GitHubCommit
    {
        [JsonPropertyName("sha")]
        public string Sha { get; set; }

        [JsonPropertyName("node_id")]
        public string NodeId { get; set; }

        [JsonPropertyName("commit")]
        public CommitMeta Commit { get; set; }

        [JsonPropertyName("url")]
        public Uri Url { get; set; }

        [JsonPropertyName("html_url")]
        public Uri HtmlUrl { get; set; }

        [JsonPropertyName("comments_url")]
        public Uri CommentsUrl { get; set; }

        [JsonPropertyName("author")]
        public GitHubCommitAuthor Author { get; set; }

        [JsonPropertyName("committer")]
        public GitHubCommitAuthor Committer { get; set; }

        [JsonPropertyName("parents")]
        public IEnumerable<CommitParent> Parents { get; set; }
    }
}
