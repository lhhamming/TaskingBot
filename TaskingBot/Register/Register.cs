using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TaskingBot.Data;

namespace TaskingBot.Register
{
    public class Register : ModuleBase<SocketCommandContext>
    {
        [Command("Register")]
        public async Task RegisterUser(IUser User = null)
        {
            var result = UsersDao.SaveUser(Context.User.Id);
            await Context.Channel.SendMessageAsync(result);
        }

        [Command("Userlist")]
        public async Task UserList(IUser User = null)
        {
            var result = UsersDao.GetUserList();
            foreach(var user in result)
            {
                var discorduser = Program._client.GetUser(Convert.ToUInt64(user.UserId));
                await Context.Channel.SendMessageAsync($"{discorduser.Username} is in tha list");
            }
        }
    }
}
