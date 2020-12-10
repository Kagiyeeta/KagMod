/* using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using KagMod.Projectiles;

namespace KagMod.Buffs
{
	public class MiniParallaxBuff : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Mini-Parallax");
			Description.SetDefault("The Mini-Parallax will fight for you");
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			ModPlayer modPlayer = player.GetModPlayer<ModPlayer>();
			if (player.ownedProjectileCounts[ProjectileType<MiniParallax>()] > 0)
			{
				modPlayer.MiniParallax = true;
			}
			if (!modPlayer.MiniParallax)
			{
				player.DelBuff(buffIndex);
				buffIndex--;
			}
			else
			{
				player.buffTime[buffIndex] = 18000;
			}
		}
	}
} */