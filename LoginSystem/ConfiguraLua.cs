using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LoginSystem
{
    class ConfiguraLua
    {
        public static void GuardaDefenicoes(string Rank, string Name, string Champion, string Side, string SkinNumber, string Ribbon, string Icon) //Side = PURPLE OR BLUE
        {
           string Text = @"players = {
	[""player1""] = {
        [""rank""] = """+ Rank + @""",
        [""name""] = """ + Name +@""",
		[""champion""] = """+ Champion +@""",
		[""team""] = """+ Side +@""", -- BLUE or PURPLE
[""skin""] = "+ SkinNumber +@",
		[""summoner1""] = ""HEAL"",
		[""summoner2""] = ""FLASH"",
		[""ribbon""] = "+ Ribbon +@", -- [ 1 = Leader(Yellow)] [ 2 = Mentor(Blue)] [ 4 = Cooperative(Green)]
        [""icon""] = "+ Icon +@" -- Summoner Icon ID
    },
   
	--[[-- uncomment this for more players! you can also add more, up to 12!
    [""player2""] = {
		[""rank""] = ""DIAMOND"",
		[""name""] = ""Amin Caramelo"",
		[""champion""] = ""Ezreal"",
		[""team""] = ""PURPLE"",
		[""skin""] = 7,
		[""summoner1""] = ""FLASH"",
		[""summoner2""] = ""IGNITE"",
		[""ribbon""] = 2,
      [""icon""] = 0
	},
   --]]

   --[[
    [""player3""] = {
		[""rank""] = ""DIAMOND"",
		[""name""] = ""Test3"",
		[""champion""] = ""Caitlyn"",
		[""team""] = ""BLUE"",
		[""skin""] = 3,
		[""summoner1""] = ""CLEANSE"",
		[""summoner2""] = ""TELEPORT"",
		[""ribbon""] = 2,
      [""icon""] = 0
	}--]]
}
game = {
--[[
1 	- 	Summoners Rift
6 	- 	Crystal Scar
8 	- 	Twisted Treeline
12 	- 	Howling Abyss
11 	- 	New Summoners Rift (only on the PBE client)
--]]
	[""map""] = 1
}";
            File.WriteAllText(Directory.GetCurrentDirectory() + "\\lua\\config.lua", Text);
            
        }
    }
}
