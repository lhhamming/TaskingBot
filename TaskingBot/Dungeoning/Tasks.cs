using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TaskingBot.Dungeoning
{
    public class Tasks : ModuleBase<SocketCommandContext>
    {
        [Command("get")]
        public async Task getTasks()
        {
            //Check of de persoon al een monster klaar heeft staan of niet
            string[] Tasks = new string[10];
            Tasks[0] = "Kill 5 Goblins :japanese_goblin:";
            Tasks[1] = "Get 5 :watermelon:";
            Tasks[2] = "Kill a All **mighty Dragon** :dragon:";
            Tasks[3] = "Collect 10 **bottles** :baby_bottle:";
            Tasks[4] = "Slay **Van de Woord** :sadvdw:";
            Tasks[5] = "Collect some **Fish** :fish:";
            Tasks[6] = "Slay the **Officer** :ssofficier:";
            Tasks[7] = "Make some **Beer** :beer:";
            Tasks[8] = "Defeat the **uttermost shitiest Teacher** :shitleraar:";
            Tasks[9] = "Get some **Eggplants** my dude :eggplant:";

            Random rnd = new Random();
            int ChosenTask = rnd.Next(Tasks.Length);

            await ReplyAsync("Your Chosen task is: " + Tasks[ChosenTask]);

            //Voeg hiernaa de gebruiker die deze monster gevonden heeft toe aan de database

        }
    }
}
