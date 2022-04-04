using System;

namespace My_first_program
{
    class Program 
    {
        static void Main(string[] args)
        {
            // //Change the appearance
            // Console.Title = "My first Programd";
            // Console.WindowHeight = 50;
            // //Get the conversation going
            // Console.WriteLine("A proud knight named...");

            // Console.ReadLine();
            // Console.WriteLine("...walked into a bar. At the counter he met a...");
            // Console.ReadLine();
            // Console.WriteLine("...who asked him what he wangted to drink?");
            // Console.ReadLine();
            // Console.WriteLine("...shouted the knight! The bartender shushed him quickly.");
            // Console.ForegroundColor = ConsoleColor.Red;
            // Console.WriteLine("But it was too late... a dragon ate them both");
            // Console.ReadKey();
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine("Hello,"+userName+"nice to meet you!");
            int num01;
            int num02;
            Console.Write("Input an number: ");
            num01 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input an number: ");
            num02 = Convert.ToInt32(Console.ReadLine());
            int result = num01 * num02;
            Console.WriteLine("The result is " + result);
            Console.ReadKey();
        }
    }
}