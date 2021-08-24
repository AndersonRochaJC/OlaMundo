using System;

namespace OlaMundo
{
    class Program
    {        static void Main(string[] args)
       {     Console.BackgroundColor = ConsoleColor.Green;
             Console.WriteLine("Ola Mundo!!!");  
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Shalom!!!!");
             Console.BackgroundColor = ConsoleColor.Red;
             Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Eu me chamo Anderson Rocha!");
              Console.ResetColor();


        } 
    }
}
