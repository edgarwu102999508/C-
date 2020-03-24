using System;

namespace IntroProgSelection2020
{
  class Program
  {
    static void Main(string[] args)
    {
        // Algorithm Tasks
        // Exercise 1
        // int age = 16;
        // int legalAge = 17;

        // if (age >= legalAge) {
        //     Console.WriteLine("Legally adult age.");
        // }else {
        //     Console.WriteLine("Legally not adult age.");
        // }
        // Console.WriteLine("Terminated");


        // Selection Task
        string username = "EdgarWu";
        string password = "123456";
        
        Console.WriteLine("Your Username: ");
        username = Console.ReadLine();
        if (username == "EdgarWu") {
            Console.WriteLine("Your Password: ");
            password = Console.ReadLine();
            if (password == "123456")
            {
                Console.WriteLine("login successful");
            }else
            {
                Console.WriteLine("login unsuccessful");
            }
        }
        else
        {
            Console.WriteLine("login unsuccessful");
        }
    }
  }
}
