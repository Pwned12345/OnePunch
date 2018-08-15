using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OnePunch.Items
{
	public class LimitBreaker : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Limit Breaker");
			Tooltip.SetDefault("Deal 10x critical damage, lose all defense, health set to 100");
		}

		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 20;
			item.value = 25000000;
			item.rare = 8;
			item.accessory = true;
		}		

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.meleeDamage *= 10.0f;
			player.thrownDamage *= 10.0f;
			player.rangedDamage *= 10.0f;
			player.magicDamage *= 10.0f;
			player.minionDamage *= 10.0f;
			player.magicCrit = 100;
			player.thrownCrit = 100;
			player.meleeCrit = 100;
			player.rangedCrit = 100;
			player.statDefense = 0;
			player.statLifeMax2 = 100;
		}
	}
}