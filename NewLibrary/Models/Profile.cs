using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewLibrary.Models
{
    public class Profile
    {
        public int Id { get; set; }
        public string NickName { get; set; }
        public string Password { get; set; }
        public Profile()
        {

        }
        
        public Profile(int id,string Nick, string Pass)
        {
            Id = id;
            NickName = Nick;
            Password = Pass;
        }
    }
}
