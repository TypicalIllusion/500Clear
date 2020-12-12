using System;

using Exiled.API.Features;
using Exiled.API.Enums;

using PPlayer = Exiled.Events.Handlers.Player;

namespace Scp500Clear
{
    public class Scp500Clear : Plugin<Config>
    {
        private Handlers.Player player = new Handlers.Player();
        public override string Name { get; } = "Scp500Clear";
        public override string Author { get; } = "TypicalIllusion";
        public override Version Version { get; } = new Version(1, 0, 0);
        public override Version RequiredExiledVersion { get; } = new Version(2, 1, 19);
        public override string Prefix { get; } = "Scp500Clear";

        public override PluginPriority Priority { get; } = PluginPriority.Low;

        public static Scp500Clear Singleton;

        public void RegisterEvents()
        {
            PPlayer.MedicalItemUsed += player.MedicalItemUsed;
            Singleton = this;
        }
        public void UnregisterEvents()
        {
            PPlayer.MedicalItemUsed -= player.MedicalItemUsed;
            player = null;
            Singleton = null;
        }

        public override void OnEnabled()
        {
            base.OnEnabled();
            RegisterEvents();
        }
        public override void OnDisabled()
        {
            base.OnDisabled();
            UnregisterEvents();
        }
        public override void OnReloaded()
        {
            base.OnReloaded();
        }
    }
}
