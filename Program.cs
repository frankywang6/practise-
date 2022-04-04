using System;

namespace My_first_program
{
    class Program 
    {
        static void Main(string[] args)
        {
            //Change the appearance
            Console.Title = "My first Programd";
            Console.WindowHeight = 50;
            //Get the conversation going
            Console.WriteLine("A proud knight named...");

            Console.ReadLine();
            Console.WriteLine("...walked into a bar. At the counter he met a...");
            Console.ReadLine();
            Console.WriteLine("...who asked him what he wangted to drink?");
            Console.ReadLine();
            Console.WriteLine("...shouted the knight! The bartender shushed him quickly.");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("But it was too late... a dragon ate them both");
            Console.ReadKey();
        }
    }
}