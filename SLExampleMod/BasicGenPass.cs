using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.IO;
using Terraria.WorldBuilding;

namespace SLExampleMod
{
	public class BasicGenPass : GenPass
	{
		public BasicGenPass() : base("Terrain", 1) { }

		protected override void ApplyPass(GenerationProgress progress, GameConfiguration configuration)
		{
			progress.Message = "Generating terrain"; // The message that will show while the subworld is generating

			// These lines are necessary if you want to have a small world
			Main.worldSurface = Main.maxTilesY - 42; // Hides the underground layer just out of bounds
			Main.rockLayer = Main.maxTilesY; // Hides the cavern layer way out of bounds

			// Makes all the blocks dirt blocks
			for (int i = 0; i < Main.maxTilesX; i++)
			{
				for (int j = 0; j < Main.maxTilesY; j++)
				{
					progress.Set((j + i * Main.maxTilesY) / (float)(Main.maxTilesX * Main.maxTilesY)); // Controls the progress bar, should only be set between 0f and 1f
					Tile tile = Main.tile[i, j];
					tile.HasTile = true;
					tile.TileType = TileID.Dirt;
				}
			}
		}
	}
}
