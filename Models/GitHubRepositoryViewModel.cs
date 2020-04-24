using System;

namespace ExternalApisWithBlazor.Models
{
    public class GitHubRepositoryViewModel
    {
        public GitHubRepositoryViewModel(string name, DateTime updatedAt, int stars) =>
            (Name, UpdatedAt, Stars) = (name, updatedAt, stars);

        public string Name { get; set; }

        public DateTime UpdatedAt { get; set; }

        public int Stars { get; set; }
    }
}
