﻿using System;
using spaar.ModLoader;
using UnityEngine;
using spaar.Mods.Automatron;
using spaar.Mods.Automatron.Actions;

namespace Sylver.AutomatronExtention
{

    // If you need documentation about any of these values or the mod loader
    // in general, take a look at https://spaar.github.io/besiege-modloader.

    public class AutomatronBlockSpawn : Mod
    {
        public override string Name { get; } = "AutomatronBlockSpawn";
        public override string DisplayName { get; } = "AutomatronBlockSpawn";
        public override string Author { get; } = "Sylver/SSsylver (thank's to wang_w571 and spaar for help and code re-use)";
        public override Version Version { get; } = new Version(0, 1, 0);

        // You don't need to override this, if you leavie it out it will default
        // to an empty string.
        public override string VersionExtra { get; } = "";

        // You don't need to override this, if you leave it out it will default
        // to the current version.
        public override string BesiegeVersion { get; } = "v0.45";

        // You don't need to override this, if you leave it out it will default
        // to false.
        public override bool CanBeUnloaded { get; } = false;

        // You don't need to override this, if you leave it out it will default
        // to false.
        public override bool Preload { get; } = false;


        public override void OnLoad()
        {
            spaar.Mods.Automatron.Action.ActionTypes.Add("Spawn Block", typeof(ActionBlockSpawner));
        }

        public override void OnUnload()
        {
            // Your code here
            // e.g. save configuration, destroy your objects if CanBeUnloaded is true etc
        }
    }
}
