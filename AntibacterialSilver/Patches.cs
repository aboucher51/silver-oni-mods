using Database;
using HarmonyLib;
using Klei.AI;
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
                ElementLoader.FindElementByHash(SimHashes.Slimelung);
                
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

        [HarmonyPatch(typeof(ElementLoader), "LoadElements")]
        public static class SilverGermGrowthPatch
        {
            public static void Postfix()
            {
                ElementGrowthRule silverGermRule = GermUtils.DieInElement(SimHashes.silver);

                // Find the Slimelung element
                Element slimelungElement = ElementLoader.FindElementByHash(SimHashes.SlimeLung);

                if (slimelungElement != null)
                {
                    // Add the growth rule to Slimelung
                    slimelungElement.growthRules = slimelungElement.growthRules == null
                        ? new System.Collections.Generic.List<Element.GrowthRule>()
                        : new System.Collections.Generic.List<Element.GrowthRule>(slimelungElement.growthRules);

                    slimelungElement.growthRules.Add(silverGermRule);
                }
                else
                {
                    Debug.LogWarning("Slimelung element not found!");
                }

                // Find the foodPoisoning Element
                Element foodPoisoningElement = ElementLoader.FindElementByHash(SimHashes.FoodPoisoning);

                if (foodPoisoningElement != null)
                {
                    // Add the growth rule to Slimelung
                    foodPoisoningElement.growthRules = foodPoisoningElement.growthRules == null
                        ? new System.Collections.Generic.List<Element.GrowthRule>()
                        : new System.Collections.Generic.List<Element.GrowthRule>(foodPoisoningElement.growthRules);

                    foodPoisoningElement.growthRules.Add(silverGermRule);
                }
                else
                {
                    Debug.LogWarning("Foodpoisoning element not found!");
                }
            }
        }
    }
}
