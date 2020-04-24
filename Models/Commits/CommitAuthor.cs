﻿using System;
using System.Text.Json.Serialization;

namespace ExternalApisWithBlazor.Models
{
    public class CommitAuthor
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("date")]
        public DateTimeOffset Date { get; set; }
    }
}
