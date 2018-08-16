using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Graphics;
using Terraria.UI;
using Terraria.DataStructures;
using Terraria.GameContent.UI;
using System;
namespace OnePunch
{
	class OnePunch : Mod
	{
		public OnePunch()
		{	
		}
		public override void Load()
		{
			if (!Main.dedServ)
			{
				// Add certain equip textures
				// Change the vanilla dungeon track
				// Main.music[MusicID.Dungeon] = GetMusic("Sounds/Music/DriveMusic");
				// Register a new music box
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/OPM"), ItemType("OPM"), TileType("OPM"));
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Despacito"), ItemType("Alexa"), TileType("Alexa"));
			}
		}			
	}
}
