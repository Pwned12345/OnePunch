using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace OnePunch.Items
{
	public class GenosLaser1 : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Genos Laser Alpha");
			Tooltip.SetDefault("A prototype.");
		}

		public override void SetDefaults()
		{
			item.damage = 1;
			item.noMelee = true;
			item.magic = true;
			item.channel = true; //Channel so that you can held the weapon [Important]
			item.mana = 1;
			item.rare = 5;
			item.width = 28;
			item.height = 30;
			item.useTime = 20;
			item.UseSound = SoundID.Item13;
			item.useStyle = 5;
			item.shootSpeed = 14f;
			item.useAnimation = 20;
			item.shoot = mod.ProjectileType("Laser1");
			item.value = 100000;
		}
	}
}
