using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProC7.Menus;
using test = ProC7.MJTest.MJlist;


namespace ProC7
{
    class Exe
    {
        static int Main(string[] args)
        {
            Menu m = new Menu();
            m.Run();

            Menu explorer = new Menu();
            explorer.Run();
 
            return 0;
        }
    }
}
