using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OnePunch.Items
{
	public class GenosDoll : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Genos Doll");			
			Tooltip.SetDefault("50% bonus magic damage, significantly reduced non magic damage, +100 mana");
		}

		public override void SetDefaults()
		{
			item.width = 14;
			item.height = 18;
			item.value = 10000000;
			item.rare = 5;
			item.accessory = true;
			item.defense = 15;
		}		
		
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.meleeDamage *= 0.0f;
			player.thrownDamage *= 0.0f;
			player.rangedDamage *= 0.0f;
			player.magicDamage *= 1.5f;
			player.minionDamage *= 0.0f;
			player.statManaMax2 += 100;
		}
	}
}