using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TaskingBot.Class_Selection
{
    public class TestSelect : ModuleBase<SocketCommandContext>
    {
        int counter;
        [Command("Select")]
        public async Task testSelect()
        {
            await ReplyAsync("Type maar wat");

            Program._client.MessageReceived += selectedClass;
        }

        public async Task selectedClass(SocketMessage message)
        {
            int Item = Int32.Parse(message.Content);

            switch (Item)
            {
                case 1:
                    await ReplyAsync("Selected item is 1");
                    counter++;
                    break;
                case 2:
                    if (counter >= 1)
                    {
                        await ReplyAsync("The counter was higher then 2");
                        break;
                    }
                    else
                    {
                    await ReplyAsync("Selected item is 2");
                    counter++;
                    break;
                    }
                default:
                    await ReplyAsync("Type een nummer tussen 1 en 2 plox baus");
                    break;
            }
        }
    }
}
