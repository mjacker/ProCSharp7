using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProC7.Menus
{
    public class Menu
    {
        private string name = "";
        private int id = 0;
        private List<string> choise = new List<string>();
        private Menu subMenu = new Menu("vacio - test 001");

        // initializer
        public Menu(string name)
        {
            this.name = name;
        }

        // properties 
        public string Name {
            get { return this.name; }
            set { name = value; }
        }

        public int GetId()
        {
            return this.id;
        }

        public void SetId(int n)
        {
            if (n <= 100)
            {
                this.id = n;
            }
            else
            {
                Console.WriteLine("Only available 100 records.");
            }
        }


        // methods 
        public void ShowName()
        {
            Console.WriteLine(this.name);
        }

        public void ShowChoises()
        {
            Console.WriteLine("Menu: {0}\n----------------------------------", this.name);
            for (int i = 0; i < this.choise.Count; i++)
            {
                Console.WriteLine("\n{0}) {1}", i + 1, this.choise[i]);
            }
        }

        public void Add(String s)
        {
            this.choise.Add(s);
        }
    }
}
