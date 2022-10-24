using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using SubworldLibrary;

namespace SLExampleMod
{
	public class BasicSubworldEnteringItem : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Use to enter the Basic Subworld!");
		}

		public override void SetDefaults()
		{
			Item.maxStack = 1;
			Item.width = 28;
			Item.height = 38;
			Item.rare = ItemRarityID.Blue;
			Item.useStyle = 4;
			Item.useTime = 30;
			Item.useAnimation = 30;
			Item.UseSound = SoundID.Item1;
		}

		public override bool? UseItem(Player player)
		{
			//Enter should be called on exactly one side, which here is either the singleplayer player, or the server
			if (Main.netMode != NetmodeID.MultiplayerClient)
			{
				SubworldSystem.Enter<BasicSubworld>();
			}
			return true;
		}

		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ItemID.DirtBlock, 3)
				.Register();
		}
	}
}
