using Exiled.Events.EventArgs;
using EPlayer = Exiled.API.Features.Player;

using static Scp500Clear.Scp500Clear;
using Scp500Clear.Enums;

namespace Scp500Clear.Handlers
{
    class Player
    {
        /// <summary>
        /// Disable the effects
        /// </summary>
        public void MedicalItemUsed(UsedMedicalItemEventArgs ev)
        {
            if (ev.Item == ItemType.SCP500)
            {
                if (Singleton.Config.Effects.Contains(PlayerEffects.All))
                {
                    ev.Player.DisableAllEffects();
                }
            }
        }
        public void PlayerEffect(PlayerEffects effects, EPlayer player)
        {
            /// <summary>
            /// Effects
            /// </summary>
            switch (effects)
            {
                case PlayerEffects.All:
                    player.DisableAllEffects();
                    break;
                default:
                    break;
            }
        }

    }
}
