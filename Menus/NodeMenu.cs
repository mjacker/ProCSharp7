using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProC7.Menus
{
    public class NodeMenu
    {
        private string title = "";
        private int id = 0;
        private List<Tuple<string, bool>> choise = new List<Tuple< string, bool>>();
        private List<NodeMenu> subMenu = new List<NodeMenu>();

        // initializer
        public NodeMenu(string titlename)
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

        public NodeMenu GetSubMenu(int n) 
        { // falta validar datos // error, el menu se carga en la primera posicion.
            return this.subMenu[n - 1];
        }
   
        public string GetChoiseName(int n)
        {
            if (choise.Count > 0 && n <= this.choise.Count)
            {
                return this.choise[n - 1].Item1;
            }
            else
            {
                return "(void)";
            }
        }
        public bool GetChoiseBool(int n)
        {
            if (choise.Count > 0 && n <= choise.Count && n != 0)
            {
                return this.choise[n - 1].Item2;
            }
            else
            {
                return false;
            }
        }
        public int GetChoiseCount()
        {
            return this.choise.Count;
        }


        // methods 
        public void Add(String s)
        {
            this.choise.Add(new Tuple<string, bool>(s, false));
            this.subMenu.Add(null);
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
            Console.WriteLine("\n0) Exit.");
        }


        // Sub - menu - methods
        public void AddSub (NodeMenu sm)
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
