using System;
using System.Text.Json.Serialization;

namespace ExternalApisWithBlazor.Models
{
    public class CommitMeta
    {
        [JsonPropertyName("author")]
        public CommitAuthor Author { get; set; }

        [JsonPropertyName("committer")]
        public CommitAuthor Committer { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("tree")]
        public object Tree { get; set; }

        [JsonPropertyName("url")]
        public Uri Url { get; set; }

        [JsonPropertyName("comment_count")]
        public long CommentCount { get; set; }

        [JsonPropertyName("verification")]
        public object Verification { get; set; }
    }
}
