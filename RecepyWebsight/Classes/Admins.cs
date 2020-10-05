using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecepyWebsight.Classes
{
    public class Admins
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public Admins(string name, string password, string email)
        {
            this.Name = name;
            this.Password = password;
            this.Email = email;
        }


    }
}
