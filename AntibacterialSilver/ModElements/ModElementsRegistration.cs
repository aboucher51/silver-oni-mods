using ElementUtilNamespace;
using System.Collections.Generic;
using UtilLibs;

namespace Cheese.ModElements
{
	public class ModElementRegistration
	{
		public static ElementInfo
            SilverOre = ElementInfo.Solid("SilverOre", UIUtils.rgb(126, 129, 150)),
            Silver = ElementInfo.Solid("Silver", UIUtils.rgb(126, 129, 150)),
            MoltenSilver = ElementInfo.Solid("MoltenSilver", UIUtils.rgb(126, 129, 150)),
			SilverGas = ElementInfo.Liquid("SilverGas", UIUtils.rgb(126, 129, 150))
			;

		public static void RegisterSubstances(List<Substance> list)
		{
			var newElements = new HashSet<Substance>()
			{
                SilverOre.CreateSubstance(),
                Silver.CreateSubstance(),
                MoltenSilver.CreateSubstance(),
                SilverGas.CreateSubstance(),
			};
			list.AddRange(newElements);
		}
		public static ElementsAudio.ElementAudioConfig[] CreateAudioConfigs(ElementsAudio instance)
		{
			return new[]
			{
				SgtElementUtil.CopyElementAudioConfig(SimHashes.GoldAmalgam, SilverOre),
                SgtElementUtil.CopyElementAudioConfig(SimHashes.Gold, Silver),
            };
		}

	}
}
