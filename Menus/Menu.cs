using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CH1_CalcMain = CH01.CalcMain;
using CH1_Hello = CH01.Hello;
using CH2_Welcome = ProC7.CH02.Welcome;

namespace ProC7.Menus
{
    class Menu
    {
        // Local variables
        private readonly string menu = "" +
            "\n1) Chapter 1: Example Calc.cs" +
            "\n2) Chapter 1: Hello World." +
            "\n3) Chapter 2: Welcome Message." +
            "\n4) Chapter 3: Can nor run directly, need to change in ProC7 properties." +
            "\n0) Exit.>> ";
        private int op;
        public void Run()
        {
            bool exit = false;
            while (!exit)
            {
                try
                {
                    this.PrintMenu();
                    op = Convert.ToInt32(Console.ReadLine());
                    switch (op)
                    {
                        case 0:
                            exit = true;
                            break;

                        case 1:
                            CH1_CalcMain.Main();
                            break;
                        case 2:
                            CH1_Hello.Main();
                            break;
                        case 3:
                            CH2_Welcome.Main();
                            break;
                    }
                    if (op != 0)
                    {
                        Console.WriteLine("\n-----------------------------------------------\nProgram ended. Press enter to continue...");
                        Console.ReadLine();
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
            Console.Write(this.menu);
        }
    }
}
