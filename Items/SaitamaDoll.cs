using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OnePunch.Items
{
	public class SaitamaDoll : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Saitama Doll");			
			Tooltip.SetDefault("50% bonus melee damage, deal 0% non melee damage");
		}

		public override void SetDefaults()
		{
			item.width = 14;
			item.height = 18;
			item.value = 10000000;
			item.rare = 5;
			item.accessory = true;
			item.defense = 25;
		}		
		
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.meleeDamage *= 1.5f;
			player.thrownDamage *= 0.0f;
			player.rangedDamage *= 0.0f;
			player.magicDamage *= 0.0f;
			player.minionDamage *= 0.0f;
		}
	}
}