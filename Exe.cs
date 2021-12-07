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
        // item declaration area
            Menu compras = new Menu("compras");
            compras.Add("harina");
            compras.Add("leche");
            compras.Add("azucar");
            //compras.ShowChoises();

            Menu autos = new Menu("Autos");
            autos.Add("Toyota");
            autos.Add("BMW");
            autos.Add("Audi");
            //autos.ShowChoises();

            Menu chapters = new Menu("Chapters");
            chapters.Add("Chapter one.");
            chapters.Add("Chapter two.");
            chapters.Add("Chapter three.");

            Menu languages = new Menu("Languages");
            languages.Add("Spanish");
            languages.Add("English");
            languages.Add("Chinese");

            chapters.AddSub(languages);

            // menu of menus
            Menu m = new Menu("Principal");
            m.AddSub(chapters);
            m.AddSub(compras);
            m.AddSub(autos);

        // testing to add value after sync with menu.
            compras.Add("galleta");

        // printing area:

            //Line("Printing area>");
            m.ShowChoises();
            m.ShowSubMenu();

            // menu conditions test:
            bool exit = false;
            while (!exit)
            {
                Console.Write("Choose option>> ");

                int r = Convert.ToInt32(Console.ReadLine()); // no manage exceptions yet.

                    

                switch (r)
                {
                    case 0:
                        exit = true;
                        break;
                    default:
                        m.ShowSubMenu(r);
                        break;
                }
            }

            return 0;
        }

        static void Line(string s)
        {
            Console.WriteLine("\n-----------------------\n{0}\n-----------------------\n", s);
        }
    }
}
