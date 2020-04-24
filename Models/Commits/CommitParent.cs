using System;
using System.Text.Json.Serialization;

namespace ExternalApisWithBlazor.Models
{
    public class CommitParent
    {
        [JsonPropertyName("sha")]
        public string Sha { get; set; }

        [JsonPropertyName("url")]
        public Uri Url { get; set; }

        [JsonPropertyName("html_url")]
        public Uri HtmlUrl { get; set; }
    }
}
