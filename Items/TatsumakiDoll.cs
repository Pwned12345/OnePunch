using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OnePunch.Items
{
	public class TatsumakiDoll : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Tatsumaki Doll");			
			Tooltip.SetDefault("Occasionally damages all enemies, reduces all damage dealt by 5%");
		}

		public override void SetDefaults()
		{
			item.width = 14;
			item.height = 18;
			item.value = 10000000;
			item.rare = 5;
			item.accessory = true;
			item.defense = 10;
		}		
		
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.meleeDamage *= 0.95f;
			player.thrownDamage *= 0.95f;
			player.rangedDamage *= 0.95f;
			player.magicDamage *= 0.95f;
			player.minionDamage *= 0.95f;			
			if (Main.rand.Next(250) == 0) //On a 1/250 chance every tick
			{			
				Projectile.NewProjectile(player.position.X, player.position.Y, 0f, 0f, mod.ProjectileType("DollHit"), 5, 0f, player.whoAmI, 0f, 0f);		
			}
		}
	}
}