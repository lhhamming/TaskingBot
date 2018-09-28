using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TaskingBot.Dungeoning
{

    public class Encouter : ModuleBase<SocketCommandContext>
    {
        [Command("Search")]
        public async Task Search()
        {
            string Monster;

            string[] Monsters = new string[5];
            Monsters[0] = "Goblin";
            Monsters[1] = "There be Draguns! :dragon:";
            Monsters[2] = "**Nya** <:sadvdw:434803233647624212>";
            Monsters[3] = "**_DU BIST VERRUCKT_** <:ssofficier:464204953309675530>";
            Monsters[4] = "**Jullie gaan zo niet slagen** <:shitleraar:448209296304373762>";

            Random rnd = new Random();
            int ChosenMonster = rnd.Next(1500);

            int SelectedM;

            switch (ChosenMonster)
            {
                case int n when (n <= 599 && n<=600):
                    Monster = Monsters[0];
                    SelectedM = 1;
                    break;

                case int n when (n >= 601 && n <= 1000):
                    Monster = Monsters[1];
                    SelectedM = 2;
                    break;

                case int n when (n >= 1001 && n <= 1200):
                    Monster = Monsters[2];
                    SelectedM = 3;
                    break;

                case int n when (n >= 1201 && n <= 1400):
                     Monster = Monsters[3];
                    SelectedM = 4;
                    break;

                case int n when (n >= 1401 && n <= 1500):
                    Monster = Monsters[4];
                    SelectedM = 5;
                    break;

                default:
                    Monster = "You found nothing";
                    SelectedM = 0;
                    break;
            }

            string lvl;
            int LevelMonster;
            

            Random Lvl = new Random();
            //Word depended van monster
            switch (SelectedM)
            {
                case 0:
                    LevelMonster = 0;
                    break;
                case 1:
                    LevelMonster = Lvl.Next(1, 5);
                    break;
                case 2:
                    LevelMonster = Lvl.Next(6, 10);
                    break;
                case 3:
                    LevelMonster = Lvl.Next(15,30);
                    break;
                case 4:
                    LevelMonster = Lvl.Next(30, 50);
                    break;
                case 5:
                    LevelMonster = Lvl.Next(80, 100);
                    break;
                default:
                    LevelMonster = 0;
                    break;
            }
            

            lvl = LevelMonster.ToString();

            if (lvl.Equals(0))
            {
                await ReplyAsync(Monster + "You pleb. There is more Adventure to be had keep on searching! :map: ");
            }
            else
            {
                await ReplyAsync("You have found: " + Monster + " Level: " + lvl);
            }
            
        }
    }
}
