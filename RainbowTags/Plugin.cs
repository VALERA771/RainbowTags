using System;
using System.Collections.Generic;
using System.Linq;
using Exiled.API.Extensions;
using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;
using Object = UnityEngine.Object;

namespace RainbowTags
{
    public class Plugin : Plugin<Config>
    {
        public static Plugin Instance { get; private set; }
        public override string Author => "valera771 : (Ported From Build & xNexus-ACS & NotIntense)";
        public override string Name => "RainbowTags";
        public override string Prefix => "rainbow_tags";
        public override Version Version { get; } = new(2, 0, 0);
        public override Version RequiredExiledVersion { get; } = new(7, 0, 0);

        public static string[] AvailableColors { get; } =
        {
            "pink",
            "red",
            "brown",
            "silver",
            "light_green",
            "crimson",
            "cyan",
            "aqua",
            "deep_pink",
            "tomato",
            "yellow",
            "magenta",
            "blue_green",
            "orange",
            "lime",
            "green",
            "emerald",
            "carmine",
            "nickel",
            "mint",
            "army_green",
            "pumpkin"
        };
        public static List<Player> PlayersWithoutRTags { get; } = new();

        public override void OnEnabled()
        {
            Instance = this;
            Exiled.Events.Handlers.Player.ChangingGroup += OnChangingGroup;
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Player.ChangingGroup -= OnChangingGroup;
            base.OnDisabled();
            Instance = null;
        }
        
        private string GetGroupKey(UserGroup group)
        {
            if (group == null)
                return string.Empty;

            return ServerStatic.PermissionsHandler._groups.FirstOrDefault(g => g.Value.EqualsTo(group)).Key ??
                   string.Empty;
        }
        
        private void OnChangingGroup(ChangingGroupEventArgs ev)
        {
            if (!PlayersWithoutRTags.Contains(ev.Player) && ev.NewGroup != null && ev.Player.Group == null)
            {
                Log.Debug("RainbowTags: Added to " + ev.Player.Nickname);
                var rtController = ev.Player.GameObject.AddComponent<TagController>();
                rtController.Badge = Config.GroupSequences.Find(x => x.Group == GetGroupKey(ev.NewGroup));
                return;
            }
            
            Object.Destroy(ev.Player.GameObject.GetComponent<TagController>());
        }
    }
}