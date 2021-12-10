using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProC7.Menus;
using test = ProC7.MJTest.MJlist;
//using CH00 = CH01.CalcMain;
using CH1 = CH01.Hello;

namespace ProC7
{
    class Exe
    {
        static int Main(string[] args)
        {

            OldMenu m = new OldMenu();
            m.Run();
 


            Console.ReadLine();
            return 0;
        }
    }

    class OldMenu 
    {
        // Local variables
        private string menu = "1) Chapter 1.\n2) Chapter 2.\n>> ";
        private int op;
        public void Run()
        {
            this.PrintMenu();
            bool exit = false;
            while (!exit)
            {
                try
                {
                    op = Convert.ToInt32(Console.ReadLine());
                    switch (op)
                    {
                        case 0:
                            exit = true;
                            break;
                            
                        case 1:
                            CH1.Main();
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Warning: {0}", ex.Message);
                }
            }

        }
        public void PrintMenu()
        {
            Console.WriteLine(this.menu);
        }

                
    }

}
