using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProC7.Menus
{
    public class Menu
    {
        private string title = "";
        private int id = 0;
        private List<Tuple<string, bool>> choise = new List<Tuple< string, bool>>();
        private List<Menu> subMenu = new List<Menu>();

        // initializer
        public Menu(string titlename)
        {
            this.title = titlename;
        }

        // properties 
        public string Title { //Forma abreviada get set.
            get { return this.title; }
            set { title = value; }
        }

        public int GetId() {return this.id;} // Forma expandida get set.
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
        public void Add(String s)
        {
            this.choise.Add(new Tuple<string, bool>(s, false));
        }
        public void ShowTitle()
        {
            Console.WriteLine("\n----------------------------------\nMenu: {0}\n----------------------------------", this.title);
        }

        public void ShowChoises()
        {
            ShowTitle();
            for (int i = 0; i < this.choise.Count; i++)
            {
                if (this.choise[i].Item2 == false)
                    Console.WriteLine("\n{0}) {1}", i + 1, this.choise[i].Item1);
                else
                {
                    Console.WriteLine("\n{0}) {1}\t\t>>", i + 1, this.choise[i].Item1);
                }
            }
        }


        // Sub - menu - methods
        public void AddSub (Menu sm)
        {
            this.choise.Add(new Tuple<string, bool>(sm.title, true));
            this.subMenu.Add(sm);
            this.id += 1;
        }
        public void ShowSubMenu()
        {
            for (int i = 0; i < this.subMenu.Count; i++)
            {
                //Console.WriteLine("\n{0}) {1}", i + 1, this.subMenu[i]);
                this.subMenu[i].ShowChoises();
            }
        }

        public void ShowSubMenu(int n)
        {
                //Console.WriteLine("\n{0}) {1}", i + 1, this.subMenu[i]);
                this.subMenu[n - 1].ShowChoises();
        }
    }
}
