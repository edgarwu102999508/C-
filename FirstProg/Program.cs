using System;

namespace FirstProg
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("What's your firstname?");
            string firstname = Console.ReadLine();          
            
            Console.WriteLine("What's your lastname?");
            string lastname = Console.ReadLine();

            string fullname = firstname + lastname;
            
            Console.Write(fullname); */
            
            // CALCULATE AGE
            // int birthYear;
            // birthYear = 1984;            
            // var currentYear = DateTime.Now;
            // var age = currentYear.Year - birthYear;
            // System.Console.WriteLine(age);

            // SIMPLE CALCULATOR
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter a operator: ");
            string op = Console.ReadLine();
            
            Console.Write("Enter a number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (op == "+") 
            {
                Console.WriteLine(num1 + num2);
            }else if ( op == "-") 
            {
                Console.WriteLine(num1 - num2);
            }else if ( op == "*")
            {
                Console.WriteLine(num1 * num2);
            }else if ( op == "/")
            {
                Console.WriteLine(num1 / num2);
            }else
            {
                Console.WriteLine("Invalid operation!!!");
            } 
        }
    }
}

