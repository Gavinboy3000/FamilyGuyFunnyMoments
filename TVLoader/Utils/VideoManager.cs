using BepInEx;

using System.Collections.Generic;
using System.IO;

namespace TVLoader.Utils
{
	internal static class VideoManager
	{
		public static List<string> Videos = new List<string>();

		public static void Load()
		{
			// Family guy funny moments
			string myPath = Path.Combine(Paths.PluginPath, "Gavinboy3000-FamilyGuyFunnyMoments", "Videos");

			if (!Directory.Exists(myPath))
				Directory.CreateDirectory(myPath);

			var myVideos = Directory.GetFiles(myPath, "*.mp4");

			Videos.AddRange(myVideos);
			TVLoaderPlugin.Log.LogInfo($"There are {myVideos.Length} videos.");
			TVLoaderPlugin.Log.LogInfo($"Loaded {Videos.Count} total.");
		}
	}
}
