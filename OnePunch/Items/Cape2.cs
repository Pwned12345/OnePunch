using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OnePunch.Items
{
	[AutoloadEquip(EquipType.Wings)]	
	public class Cape2 : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Saitama's Cape");			
			Tooltip.SetDefault("Fly Fast");
		}

		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 20;
			item.value = 5;
			item.rare = 13;
			item.accessory = true;
			item.defense = 10000;
		}
		//these wings use the same values as the solar wings
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.wingTimeMax = 180;
		}

		public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising,
			ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
		{
			ascentWhenFalling = 0.85f;
			ascentWhenRising = 0.15f;
			maxCanAscendMultiplier = 1f;
			maxAscentMultiplier = 3f;
			constantAscend = 0.135f;
		}

		public override void HorizontalWingSpeeds(Player player, ref float speed, ref float acceleration)
		{
			speed = 10000f;
			acceleration *= 10000.0f;
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