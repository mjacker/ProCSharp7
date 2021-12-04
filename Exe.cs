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
            Menu m = new Menu("compras");

            m.Add("harina");
            m.Add("leche");
            m.Add("azucar");

            m.Name = "hola";

            m.ShowName();

            m.ShowChoises();

            test.Main();

            Console.ReadLine();

            return 0;
        }
    }
}
