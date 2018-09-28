using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace TaskingBot.Dungeoning
{
    public class Run : ModuleBase<SocketCommandContext>
    {
        [Command("Run")]
        public async Task taskRun()
        {
            //Check level van monster
            Random run = new Random();
            int RunValue = run.Next(100);
            
            //Check hoelang het nog duurt of hoe vaak de gebruiker nog moet aan vallen totdat de gebruiker weer mag runnen.
            if(RunValue <= 10)
            {
                await ReplyAsync("You ran away succesfully... Chicken :hatching_chick: ");
            }
            else
            {
                await ReplyAsync("Try again later...");
            }

            
        }    
        
    }
}
