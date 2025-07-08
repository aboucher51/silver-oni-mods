using HarmonyLib;
using KMod;
using System;
using UtilLibs;
using System.Collections.Generic;

namespace AntibacterialSilver
{
    public class Mod : UserMod2
    {
        public override void OnLoad(Harmony harmony)
        {
            base.OnLoad(harmony);
            SgtLogger.LogVersion(this, harmony);
            //ModAssets.LoadAll();
        }

        public override void OnAllModsLoaded(Harmony harmony, IReadOnlyList<KMod.Mod> mods)
        {
            base.OnAllModsLoaded(harmony, mods);
            CompatibilityNotifications.FlagLoggingPrevention(mods);
            CompatibilityNotifications.FixBrokenTimeout(harmony);
        }
    }
}
