using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TaskingBot.Resources.Database
{
    class RegisteredUsers
    {
        [Key]
        public long UserId { get; set; }
        public bool Register { get; set; }
    }
}
