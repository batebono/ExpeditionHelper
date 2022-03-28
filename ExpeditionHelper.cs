using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ExileCore;
using ExileCore.PoEMemory.Components;
using ExileCore.PoEMemory.MemoryObjects;
using ExileCore.Shared;
using ExileCore.Shared.Abstract;
using ExileCore.Shared.Cache;
using ExileCore.Shared.Enums;
using ExileCore.Shared.Helpers;
using SharpDX;

namespace ExpeditionHelper
{
    public class ExpeditionHelper : BaseSettingsPlugin<ExpeditionHelperSettings>
    {
        public override bool Initialise()
        {
            CanUseMultiThreading = true;
            return base.Initialise();
        }
        public override void Render()
        {
            const string markerPath = "Metadata/MiscellaneousObjects/Expedition/ExpeditionMarker";
            foreach (var e in GameController.EntityListWrapper.ValidEntitiesByType[EntityType.IngameIcon].OrderBy(x => x.Path != markerPath))
            {
                var renderComponent = e?.GetComponent<Render>();
                if (renderComponent == null) continue;
                var expeditionChestComponent = e?.GetComponent<ObjectMagicProperties>();
                if (expeditionChestComponent == null) continue;
                var mods = expeditionChestComponent.Mods;
                DebugWindow.LogError($"{mods}");
            }

        }
    }
}
