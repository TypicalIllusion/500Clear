using System.ComponentModel;

using Exiled.API.Interfaces;

using System.Collections.Generic;
using Scp500Clear.Enums;

namespace Scp500Clear
{
    public class Config : IConfig
    {
        [Description("Enable the plugin?")]
        public bool IsEnabled { get; set; } = true;
        [Description("Disable what effects?")]
        public List<PlayerEffects> Effects { get; set; } = new List<PlayerEffects>()
        {
            PlayerEffects.All,
        };
    }
}
