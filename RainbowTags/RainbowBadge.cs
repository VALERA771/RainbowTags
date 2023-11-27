using System.Linq;
using Exiled.API.Features;

namespace RainbowTags
{
    public struct RainbowBadge
    {
        public string Group { get; }
        
        public float ChangeTime { get; }
        
        public string[] Colors { get; }

        public RainbowBadge(string group, float changeTime, string[] colors)
        {
            Group = group;

            if (changeTime < 0.5f)
            {
                Log.Error($"{nameof(ChangeTime)} is smaller that 0.5f. Setting to 0.5f. Group: {Group}");
                changeTime = 0.5f;
            }

            ChangeTime = changeTime;

            if (colors.Any(x => !Plugin.AvailableColors.Contains(x.ToLower())))
            {
                Log.Error($"{nameof(Colors)} contains non-available colors. Setting to default. Group: {Group}");
                colors = Plugin.AvailableColors;
            }

            Colors = colors;
        }
    }
}