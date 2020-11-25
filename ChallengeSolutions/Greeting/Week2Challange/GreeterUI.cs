using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Challange
{
    class GreeterUI
    {
        public void Run()
        {
            Menu();
        }

        public void Menu()
        {
            bool keeprunning = true;
            while (keeprunning)
            {
                Console.WriteLine("Enter your Name");

                string input = Console.ReadLine();

                Console.WriteLine("Hello (input)");
            }
        }

    }
}
