using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _80methods
{
    internal class Controller
    {

        static private Menu menu;
        static private Stacks stack;

        public Controller()
        {
            menu = new Menu();
            stack = new Stacks();

            switch_to_Main();
        }

        static public void switch_to_Main() { menu.ini(); }
        static public void switch_to_ArrList() { stack.ini(); }
    }
}
