using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Change the appearance
            Console.Title = "My first simple interactive program";
            Console.WindowHeight = 40;
            Console.WriteLine("Press any key to enter bar.");  
            //Console is a class, add'.' to access all the Property or Variable and function or methods
            Console.ReadKey();
            Console.WriteLine("What is your name?");

            string userName = Console.ReadLine();

            Console.WriteLine("Hello, " + userName + " Nice to meet you!");

            int num01;     //Declearing a variable
            int num02;     //Same as above, wait for user input and assign the value to it
            int need_to_earn;
            int cash = 30;

            Console.Write("How old are you: ");
            num01 = Convert.ToInt32(Console.ReadLine());     //Readline is user's input default as sting, therefore in order to store in num01 which is
                                                             //int we should convert it to a int. And ToInt32 is a function, so we need to put it in bracket.
            Console.Write("How many money you have: ");
            need_to_earn = Convert.ToInt32(Console.ReadLine());
            if (num01 >= 18) //Condition statement 
            {
                if (need_to_earn >= cash)
                {
                    Console.ForegroundColor = ConsoleColor.Green; //Change the text color to Green when it meet the condition and output a message.
                    Console.WriteLine("Wlecome!");
                }
                else
                {
                    int earn = cash - need_to_earn;
                    Console.WriteLine("You need to get " + earn + " more to get in.");
                }

            }
            else
            {
                num02 = 18 - num01;
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("You are too young to drink alochol, come back in " + num02 + " years.");
            }
            
        }
    }
}

