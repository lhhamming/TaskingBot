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

            Random gfish = new Random();

            string GottenFish;

            int gottenfish = gfish.Next(5000);

            switch (gottenfish)
            {
                case int n when (n <= 599 && n <= 600):
                    GottenFish = Items[0];
                    break;

                case int n when (n >= 601 && n <= 1000):
                    GottenFish = Items[1];
                    break;

                case int n when (n >= 1001 && n <= 1200):
                    GottenFish = Items[2];
                    break;

                case int n when (n >= 1201 && n <= 1400):
                    GottenFish = Items[3];
                    break;

                case int n when (n >= 1401 && n <= 1500):
                    GottenFish = Items[4];
                    break;

                default:
                    GottenFish = "You found nothing";
                    break;
            }

            await ReplyAsync("");

            //Check level

            //Do fishing

        }
    }
}
