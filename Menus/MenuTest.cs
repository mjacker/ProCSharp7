using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProC7.Menus;
using test = ProC7.MJTest.MJlist;

namespace ProC7.Menus
{
    class MenuTest
    {
        static int Main(string[] args)
        {
            try
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

                Menu ProC7CH = new Menu("Book ProC#7");
                ProC7CH.Add("Calc.exe");
                ProC7CH.Call(1);

                // menu of menus
                Menu m = new Menu("Principal");
                m.Add("Welcome.txt");
                m.AddSub(chapters);
                m.AddSub(compras);
                m.AddSub(autos);


                // testing to add value after sync with menu.
                compras.Add("galleta");

                // Menu choose option logic
                List<Menu> contenedor = new List<Menu>();
                contenedor.Add(m);
                contenedor[0].ShowChoises();
                Console.Write("\n\nChoose option>> ");
                int r = UserChoise(); // manage  format exeptions
                int level = 0;
                while (true)
                {
                    if (contenedor[level].GetChoiseBool(r))
                    {
                        Console.Write("TEMP: intercambio next nodo.");
                        contenedor.Add(contenedor[level].GetSubMenu(r));
                        level++;
                    }
                    else if (r > 0 && r <= contenedor[level].GetChoiseCount())
                    {
                        Console.WriteLine("OPEN FILE: {0}\n\n Press enter to continue...", contenedor[level].GetChoiseName(r));
                        Console.ReadLine();
                    }
                    else if (r == 0)
                    {
                        Console.Write("Going back!.");
                        contenedor.RemoveAt(contenedor.Count - 1);
                        level--;
                    }

                    Console.Clear();
                    Console.Write("Level: {0}", level);
                    if (level < 0)
                    {
                        System.Environment.Exit(0);
                    }
                    contenedor[level].ShowChoises();
                    Console.Write("\n\nChoose option>> ");
                    r = UserChoise();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Warning: {0}", e.Message);
                Console.ReadLine();
            }
                return 0;
        }

        static void Line(string s)
        {
            Console.WriteLine("\n-----------------------\n{0}\n-----------------------\n", s);
        }

        static int UserChoise()
        {
            while (true)
            {
                try
                {
                    return Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException Fe)
                {
                    Console.WriteLine("Warning: {0}\nPlease try again...", Fe.Message);
                }
            }
        }
    }
}
