using Terraria.ID;
using Terraria.ModLoader;

namespace OnePunch.Items
{
	public class Punch2 : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Small Punch");
//			Tooltip.SetDefault("This is a modded sword.");
		}
		public override void SetDefaults()
		{
			item.damage = 100;
			item.melee = true;
			item.width = 20;
			item.height = 20;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useStyle = 3;
			item.knockBack = 5;
			item.value = 10003;
			item.rare = 13;
			item.UseSound = SoundID.Item14;
			item.autoReuse = true;
			item.axe = 40;
			item.pick = 200;
			item.crit = 50;
			item.value = 4000;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 1);
			recipe.AddIngredient(ItemID.HallowedBar, 1);
			recipe.AddIngredient(null, "Punch1");
			recipe.AddTile(null, "OPM");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
