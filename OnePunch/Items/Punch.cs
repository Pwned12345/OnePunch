using Terraria.ID;
using Terraria.ModLoader;

namespace OnePunch.Items
{
	public class Punch : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("One Punch");
//			Tooltip.SetDefault("This is a modded sword.");
		}
		public override void SetDefaults()
		{
			item.damage = 500000000;
			item.melee = true;
			item.width = 800;
			item.height = 800;
			item.useTime = 5;
			item.useAnimation = 5;
			item.useStyle = 3;
			item.knockBack = 20;
			item.value = 10000;
			item.rare = 13;
			item.UseSound = SoundID.Item14;
			item.autoReuse = true;
			item.axe = 100;
			item.pick = 500;
			item.hammer = 500;
			item.crit = 100;
			item.value = 5;
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
