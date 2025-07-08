using AntibacterialSilver.ModElements;
using Database;
using HarmonyLib;
using Klei.AI;
using Klei.AI.DiseaseGrowthRules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UtilLibs;
using static AntibacterialSilver.ModAssets;

namespace AntibacterialSilver
{
    internal class Patches
    {
        /// <summary>
        /// add buildings to plan screen
        /// </summary>
        [HarmonyPatch(typeof(GeneratedBuildings))]
        [HarmonyPatch(nameof(GeneratedBuildings.LoadGeneratedBuildings))]
        public static class GeneratedBuildings_LoadGeneratedBuildings_Patch
        {

            public static void Prefix()
            {
                
            }
        }
        /// <summary>
        /// Init. auto translation
        /// </summary>
        [HarmonyPatch(typeof(Localization), "Initialize")]
        public static class Localization_Initialize_Patch
        {
            public static void Postfix()
            {
                LocalisationUtil.Translate(typeof(STRINGS), true);
            }
        }

        // Make food poisoning rapidly die on silver
        [HarmonyPatch(typeof(FoodGerms), "PopulateElemGrowthInfo")]
        public static class FoodGerms_PopulateElemGrowthInfo
        {
            public static void Postfix(FoodGerms __instance)
            {
                var rules = __instance.growthRules;
                rules.Add(GermUtils.DieInElement(ModElementRegistration.Silver.SimHash));
            }
        }

        // Make food poisoning rapidly die on silver
        [HarmonyPatch(typeof(SlimeGerms), "PopulateElemGrowthInfo")]
        public static class SlimeGerms_PopulateElemGrowthInfo
        {
            public static void Postfix(FoodGerms __instance)
            {
                var rules = __instance.growthRules;
                rules.Add(GermUtils.DieInElement(ModElementRegistration.Silver.SimHash));
            }
        }
    }
}
