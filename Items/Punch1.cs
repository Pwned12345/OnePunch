using Terraria.ID;
using Terraria.ModLoader;

namespace OnePunch.Items
{
	public class Punch1 : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Mini Punch");
//			Tooltip.SetDefault("This is a modded sword.");
		}
		public override void SetDefaults()
		{
			item.damage = 20;
			item.melee = true;
			item.width = 20;
			item.height = 20;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 3;
			item.knockBack = 1;
			item.value = 10003;
			item.rare = 1;
			item.UseSound = SoundID.Item14;
			item.autoReuse = false;
			item.axe = 12;
			item.pick = 60;
			item.crit = 30;
			item.value = 10000;
		}
	}
}
