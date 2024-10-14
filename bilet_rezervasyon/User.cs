using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bilet_rezervasyon
{
    internal  abstract class User : Iloginable
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public abstract bool Login(string username, string password);
    }
}
