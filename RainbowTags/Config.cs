using System.Collections.Generic;
using System.ComponentModel;
using Exiled.API.Interfaces;

namespace RainbowTags
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;

        [Description("Tags Configuration")]
        public List<RainbowBadge> GroupSequences { get; set; } = new()
        {
            new("owner", 0.5f, new[] { "red", "orange", "yellow", "green", "blue_green", "magenta", "silver", "crimson" }),
            new("moderator", 0.5f, new[] { "red", "orange", "yellow", "green", "blue_green", "magenta", "silver", "crimson" }),
            new("admin", 0.5f, new[] { "red", "orange", "yellow", "green", "blue_green", "magenta", "silver", "crimson" }),
        };
    }
}