using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OnePunch.Items
{
	public class Weights : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Weights");			
			Tooltip.SetDefault("You feel vulnerable holding this.");
		}

		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 20;
			item.value = 1;
			item.rare = -1;
			item.accessory = true;
			item.defense = -50000;
		}		
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 1);
			recipe.AddIngredient(ItemID.StoneBlock, 1);
			recipe.AddTile(null, "OPM");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}