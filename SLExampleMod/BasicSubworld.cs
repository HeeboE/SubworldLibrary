using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using SubworldLibrary;
using System.Collections.Generic;
using Terraria.WorldBuilding;

namespace SLExampleMod
{
	public class BasicSubworld : Subworld
	{
		public override int Width => 1000;
		public override int Height => 1000;
		public override bool ShouldSave => false;
		public override bool NoPlayerSaving => true;

		public override List<GenPass> Tasks => new List<GenPass>()
		{
			new BasicGenPass()
		};

		// Sets the time to the middle of the day whenever the subworld loads
		public override void OnLoad()
		{
			Main.dayTime = true;
			Main.time = 27000;
		}
	}
}
