using Discord;
using Discord.Commands;
using Discord.Rest;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
    

namespace TaskingBot.Class_Selection
{

    public class SelectClass : ModuleBase<SocketCommandContext>
    {
        private bool selected = false;

        [Command("ClassSelect")]
        public async Task selectAClass()
        {


            string[] Class = new string[4];
            Class[0] = "Warrior";
            Class[1] = "Mage";
            Class[2] = "Hunter";
            Class[3] = "Thief";

            var EmojiWarrior = new Emoji("⚔️");
            var EmojiMage = new Emoji("💦");
            var EmojiHunter = new Emoji("🏹");
            var EmojiRogue = new Emoji("🗡️");

            await ReplyAsync("Please select a class: "+
              "Type 1 for: "  + Class[0] + " , " +
              "Type 2 for: " + Class[1] + " , " +
              "Type 3 for: " + Class[2] + " , " +
              "Type 4 for: " + Class[3] + "."
             );
            while (selected)
            {
                Program._client.MessageReceived += selectedClass;
                break;
            }
            

        }
        public async Task selectedClass(SocketMessage message)
        {
            if (message.Content == "1")
            {
                //Voeg toe aan class 1
            }
            selected = true;
        }
        
    }
}
