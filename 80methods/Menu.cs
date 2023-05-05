using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _80methods
{
    public delegate double OperaGX(double x, double y);
    internal class Menu
    {
        private enum Alpha { sum, exit};
        int button_count;
        private Alpha current_Button;

        private string[] button_Name;



        public Menu()
        {


            button_count = Enum.GetValues(typeof(Alpha)).Length;
            button_Name = new string[button_count];

            button_Name[0] = " HashSet ";
            button_Name[1] = " Выход ";
        }

        public void ini()
        {
            current_Button = (int)Alpha.sum;
            Choise();
        }

        private void Start()
        {
            Console.Clear();

            int down = button_count;

            for (int i = 0; i < button_count; i++)
            {

                int centerX = (Console.WindowWidth / 2) - (button_Name[i].Length / 2);
                int centerY = (Console.WindowHeight / 2) - down;

                int eValue = (int)current_Button;

                Console.SetCursorPosition(centerX, centerY);
                if (eValue == i)
                {
                    Console.Write(button_Name[i], Console.BackgroundColor = ConsoleColor.White,
                    Console.ForegroundColor = ConsoleColor.Black);
                }
                else
                {
                    Console.Write(button_Name[i], Console.BackgroundColor = ConsoleColor.Black,
                    Console.ForegroundColor = ConsoleColor.White);
                }

                down -= 2;
            }
            Console.ResetColor();
        }

       


        private void Choise()
        {
            Start();
            ConsoleKeyInfo chose_Button;

            Console.ResetColor();
            do
            {
                chose_Button = Console.ReadKey();

                if (chose_Button.Key == ConsoleKey.UpArrow)
                {

                    if (current_Button > 0)
                    {
                        current_Button--;
                        Start();
                    }
                }

                if (chose_Button.Key == ConsoleKey.DownArrow)
                {
                    if ((int)current_Button < button_count - 1)
                    {
                        current_Button++;
                        Start();
                    }
                }

                if (chose_Button.Key == ConsoleKey.Enter)
                {

                    switch (current_Button)
                    {
                        case Alpha.sum: Controller.switch_to_ArrList(); break;
                        case Alpha.exit: Environment.Exit(1); break;
                    }
                }



            } while (chose_Button.Key != ConsoleKey.Escape);

        }


    }
}
