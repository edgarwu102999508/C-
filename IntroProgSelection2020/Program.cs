using System;

namespace IntroProgSelection2020
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 16;
            int legalAge = 16;
            if (age >= legalAge) {
                Console.WriteLine("You can leave school.");
            }else {
                System.Console.WriteLine("Must stay at school.");
            }
            System.Console.WriteLine("Terminated");            
        }
    }
}
