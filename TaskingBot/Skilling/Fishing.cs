using Discord;
using Discord.Commands;
using Discord.Rest;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace TaskingBot.Skilling
{
    public class Fishing : ModuleBase<SocketCommandContext>
    {

        [Command("Fish")]
        public async Task taskFishing()
        {
            //Add items to fishing list
            string[] Items = new string[10];
            Items[0] = "fish";
            Items[1] = "shrimp";
            Items[2] = "Cray Fish";
            Items[3] = "Haring";
            Items[4] = "Sardine";
            Items[5] = "Anchovies";
            Items[6] = "Salmon";
            Items[7] = "Bass";
            Items[8] = "Tuna";
            Items[9] = "Sharks";

        //Check level

        //Do fishing
        
        }
    }
}
