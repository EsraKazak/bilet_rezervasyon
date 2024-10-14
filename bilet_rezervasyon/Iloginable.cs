using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bilet_rezervasyon
{
    internal interface Iloginable
    {
        bool Login(string username, string password);
    }
}
