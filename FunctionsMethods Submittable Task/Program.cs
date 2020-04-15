using System;
using System.Linq;


namespace FunctionsMethods_Submittable_Task
{
  class Program
  {
    static void Main(string[] args)
    {
      // ======== 1. Write a program in C# Sharp to create a user define function. ======== 
      //   Console.WriteLine("Expected Output: ");
      //   Console.WriteLine("Welcome Friends! ");
      //   Console.WriteLine("Have a nice day! ");
      //   Console.Read();

      // ======== 2. Write a program in C# Sharp to create a user define function with parameters. ======== 
      //   Console.WriteLine("Test Data: ");
      //   Console.WriteLine("Please input a name: ");
      //   string name = Console.ReadLine();
      //   Console.WriteLine("Welcome friend " + name);
      //   Console.WriteLine("Have a nice day! ");
      //   Console.Read();

      // ======== 3. Write a program in C# Sharp to create a function for the sum of two numbers. ======== 
      //   Console.WriteLine("Test Data: ");
      //   Console.WriteLine("Enter a number:  ");
      //   int number1 = int.Parse(Console.ReadLine());
      //   Console.WriteLine("Enter another number: ");
      //   int number2 = int.Parse(Console.ReadLine());
      //   Console.WriteLine("Expected Output: ");
      //   Console.WriteLine(number1 + number2);
      //   Console.Read();

      // ======== 4. Write a program in C# Sharp to create a function to input a string and count number of spaces are in the string. ========
      //   Console.WriteLine("Test Data: ");
      //   string text = Console.ReadLine();
      //   Console.WriteLine("Expected Output: ");
      //   Console.WriteLine(text + " contain " + text.Length + " spaces.");
      //   Console.Read();

      // ======== 5. Write a program in C# Sharp to calculate the sum of elements in an array. ========
      //   int[] number = { 5, 7, 3, 2, 9 };
      //   int result = 0;
      //   Console.WriteLine("Test Data: ");
      //   Console.WriteLine("Input 5 elements in the array: ");
      //   Console.WriteLine("Expected Output: ");
      //   for (int i = 0; i < number.Length; i++)
      //   {
      //     result += number[i];
      //   }
      //   Console.WriteLine("The sum of the elements of the array is " + result);
      //   Console.Read();

      // ======== 6. Write a program in C# Sharp to create a function to swap the values of two integer numbers. ========
      //   int number1, number2, temp;
      //   Console.WriteLine("Test Data: ");
      //   Console.WriteLine("Enter 1st number:  ");
      //   number1 = int.Parse(Console.ReadLine());
      //   Console.WriteLine("Enter 2nd number: ");
      //   number2 = int.Parse(Console.ReadLine());
      //   temp = number1;
      //   number1 = number2;
      //   number2 = temp;
      //   Console.WriteLine("Expected Output: ");
      //   Console.WriteLine("Not the 1st number is: " + number1 + " ,and the 2nd number is: " + number2);
      //   Console.Read();

      // ======== 7. Write a program in C# Sharp to create a function to calculate the result of raising an integer number to another. ========
      //   double result, baseNum, exponentNum;
      //   Console.WriteLine("Test Data: ");
      //   Console.WriteLine("Input a Base number:  ");
      //   baseNum = int.Parse(Console.ReadLine());
      //   Console.WriteLine("Input the Exponent number:  ");
      //   exponentNum = int.Parse(Console.ReadLine());
      //   Console.WriteLine("Expected Output: ");
      //   result = Math.Pow(baseNum, exponentNum);
      //   Console.WriteLine("So, the result is " + result + ".");
      //   Console.Read();

      // ======== 8. Write a program in C# Sharp to create a function to display the n number Fibonacci sequence. ========
      //   int n1 = 0, n2 = 1, n3, i, numbers;
      //   Console.WriteLine("Test Data: ");
      //   Console.WriteLine("Input number of Fibonacci sequence: ");
      //   numbers = int.Parse(Console.ReadLine());
      //   Console.WriteLine("Expected Output: ");
      //   Console.Write("The Fibonacci series of " + numbers + " numbers is : ");
      //   Console.Write(n1 + " " + n2 + " ");
      //   for (i = 2; i < numbers; ++i)
      //   {
      //     n3 = n1 + n2;
      //     Console.Write(n3 + " ");
      //     n1 = n2;
      //     n2 = n3;
      //   }
      //   Console.Read();

      // ======== 9. Write a program in C# Sharp to create a function to check whether a number is prime or not. ========
      //   int number, i, m = 0, flag = 0;
      //   Console.WriteLine("Test Data: ");
      //   Console.Write("Input a number: ");
      //   number = int.Parse(Console.ReadLine());
      //   m = number / 2;
      //   for (i = 2; i <= m; i++)
      //   {
      //     if (number % i == 0)
      //     {
      //       Console.Write(number + " is not a Prime number");
      //       flag = 1;
      //       break;
      //     }
      //   }
      //   if (flag == 0)
      //     Console.Write(number + " is a Prime number.");
      //   Console.Read();

      // ======== 10. Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number. ========
      string numbers;
      int result = 0;
      Console.WriteLine("Test Data: ");
      Console.Write("Enter a number: ");
      numbers = Console.ReadLine();
      // Convert "string" to "char Array"
      char[] charArr = numbers.ToArray();
      // Convert "char Array" to "int Array"
      int[] intArr = charArr.Select(c => c - 48).ToArray();
      for (int i = 0; i < intArr.Length; i++)
      {
        result += intArr[i];
      }
      Console.WriteLine("The sum of the digits of the number " + numbers + " is: " + result);
      Console.Read();

    }
  }
}
