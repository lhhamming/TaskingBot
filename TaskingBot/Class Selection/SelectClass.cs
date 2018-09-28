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
        private bool done = false;
        int counter = 0;

        [Command("ClassSelect")]
        public async Task selectAClass()
        {


            string[] Class = new string[4];
            Class[0] = "Warrior";
            Class[1] = "Mage";
            Class[2] = "Hunter";
            Class[3] = "Thief";

            await ReplyAsync("Please select a class: "+
              "Type 1 for: "  + Class[0] + " , " +
              "Type 2 for: " + Class[1] + " , " +
              "Type 3 for: " + Class[2] + " , " +
              "Type 4 for: " + Class[3] + "."
             );

            while (!selected)
            {
                if (done == true)
                {
                    break;
                }
                else
                {
                Program._client.MessageReceived += selectedClass;
                break;
                }
            }
            

        }
        public async Task selectedClass(SocketMessage message)
        {
            
            int Class = Int32.Parse(message.Content);
                switch (Class)
                {
                    case 1:
                        //Voeg toe aan class 1
                        counter++;
                        await ReplyAsync("Hoo-ah! Welcome to the Fighters guild! :crossed_swords: ");
                        break;
                    case 2:
                    if (counter >= 1)
                    {
                        break;
                    }
                    else
                    {
                        //Voeg toe aan class 2
                        counter++;
                        await ReplyAsync("Smart choises are made by smart people. Welcome. :sweat_drops: ");
                        break;
                    }
                    case 3:
                    if (counter >= 1)
                    {
                        break;
                    }
                    else
                    {
                        //Voeg toe aan class 3
                        counter++;
                        await ReplyAsync("Trusting your senses. Great choice! Welcome. :bow_and_arrow: ");
                        break;
                    }
                    case 4:
                    if (counter >= 1)
                    {
                        //Hij werd vaker dan 1 keer geprint
                        break;
                    }
                    else
                    {
                        //Voeg toe aan class 4
                        counter++;
                        await ReplyAsync("Choosing the Quick and Silent Side... Smart Choise... Welcome.. :dagger: ");
                        break;
                    }
                    default:
                        await ReplyAsync("Please choose a Valid number");
                        selected = false;
                        done = false;
                        break;
                }
            selected = true;
            done = true;
        }
        
    }
}
