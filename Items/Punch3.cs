using Terraria.ID;
using Terraria.ModLoader;

namespace OnePunch.Items
{
	public class Punch3 : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Normal Punch");
//			Tooltip.SetDefault("This is a modded sword.");
		}
		public override void SetDefaults()
		{
			item.damage = 1000;
			item.melee = true;
			item.width = 20;
			item.height = 20;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useStyle = 3;
			item.knockBack = 5;
			item.value = 10003;
			item.rare = 10;
			item.UseSound = SoundID.Item14;
			item.autoReuse = true;
			item.axe = 45;
			item.pick = 225;
			item.crit = 75;
			item.value = 12000;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 1);
			recipe.AddIngredient(ItemID.LunarBar, 1);
			recipe.AddIngredient(null, "Punch2");
			recipe.AddTile(null, "OPM");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
