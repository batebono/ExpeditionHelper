using ExileCore.Shared.Attributes;
using ExileCore.Shared.Interfaces;
using ExileCore.Shared.Nodes;

namespace ExpeditionHelper
{
    public class ExpeditionHelperSettings : ISettings
    {
        public ToggleNode Enable { get; set; } = new ToggleNode(true);

        [Menu("Draw Monster")]
        public ToggleNode DrawMonsters { get; set; } = new ToggleNode(true);
    }
}
