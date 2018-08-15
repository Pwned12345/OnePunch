using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace OnePunch.Items
{
	public class GenosLaser2 : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Genos Laser Beta");
			Tooltip.SetDefault("Requires mana flower to use");
		}

		public override void SetDefaults()
		{
			item.damage = 300;
			item.noMelee = true;
			item.magic = true;
			item.channel = true; //Channel so that you can held the weapon [Important]
			item.mana = 50;
			item.rare = 5;
			item.width = 28;
			item.height = 30;
			item.useTime = 20;
			item.UseSound = SoundID.Item13;
			item.useStyle = 5;
			item.shootSpeed = 14f;
			item.useAnimation = 20;
			item.shoot = mod.ProjectileType("Laser2");
			item.value = 100000;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 1);
			recipe.AddIngredient(null, "GenosLaser1");			
			recipe.AddIngredient(ItemID.LunarBar, 1);
			recipe.AddTile(null, "OPM");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}		
	}
}
