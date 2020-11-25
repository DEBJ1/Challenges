using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreeterConsole
{
    class Greeter
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

                string name = Console.ReadLine();

                Console.Clear();
                Console.WriteLine("Hi there " + (name) + "!");



                Console.WriteLine("Press any key to leave...");
                Console.ReadKey();


                Console.Clear();



                

                TimeOfDay(name);

            }
        }


        public void Goodbye(string name)
        {
            Greeter_02 Parting = new Greeter_02();

            Console.WriteLine("Goodbye " + (name) + "!");




        }



        public void TimeOfDay(string name)

        {
            Greeter_02 Relative = new Greeter_02();

            if (DateTime.Now.Hour >= 6 && DateTime.Now.Hour < 12)
            {
                Console.WriteLine("Good Morning " + (name) + "!");
            }
            else if (DateTime.Now.Hour >= 12 && DateTime.Now.Hour < 18)
            {
                Console.WriteLine("Good Afternoon" + (name) + "!");
            }
            else if (DateTime.Now.Hour >= 18 && DateTime.Now.Hour < 20)
            {
                Console.WriteLine("Good Evening " + (name) + "!");
            }
            else if (DateTime.Now.Hour >= 20 && DateTime.Now.Hour < 24)
            {
                Console.WriteLine("Have a good night " + (name) + "!");
            }
        }
    }
}


