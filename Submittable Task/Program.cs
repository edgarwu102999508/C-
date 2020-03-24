using System;

namespace Submittable_Task
{
  class Program
  {
    static void Main(string[] args)
    {
      // ------ Exercises 1 ------
      string userName = "Edgar";
      int count = 0;
      int printTimes = 0;
      Console.Write("Please enter a number of times you want to print out " + "===>" + " ");
      printTimes = int.Parse(Console.ReadLine());
      while (count < printTimes)
      {
        Console.Write(userName);
        count++;
      }
      Console.Write(" <<<< Finished");


      // ------ Exercises 2-1 ------
      // string userName = "Edgar";
      // Console.Write("Please enter a number of times you want to print out " + "===>" + " ");
      // for (int printTimes = int.Parse(Console.ReadLine()); printTimes >= 1; printTimes--)
      // {
      //   for (int col = 1; col <= printTimes; col++)
      //   {
      //     Console.Write(userName);
      //   }
      //   Console.WriteLine();
      // }

      // ------ Exercises 2-3 ------
      // string userName = "Edgar";
      // Console.Write("Please enter a number of times you want to print out " + "===>" + " ");
      // int printTimes = int.Parse(Console.ReadLine());
      // for (int row = 1; row <= printTimes; row++)
      // {
      //   for (int col = 1; col <= row; col++)
      //   {
      //     Console.Write(userName);
      //   }
      //   Console.WriteLine();
      // }

      // ------ Advanced Exercises 1 ------
      // int number, i, k, count;
      // Console.Write("Please enter a number of times you want to print out " + "===>" + " ");
      // number = int.Parse(Console.ReadLine());
      // count = number - 1;
      // for (k = 1; k <= number; k++)
      // {
      //   for (i = 1; i <= count; i++)
      //     Console.Write(" ");
      //   count--;
      //   for (i = 1; i <= 2 * k - 1; i++)
      //     Console.Write("x");
      //   Console.WriteLine();
      // }
      // count = 1;
      // Console.WriteLine();

      // ------ Advanced Exercises 2 ------
      // int number, i, k, count;
      // Console.Write("Please enter a number of times you want to print out " + "===>" + " ");
      // number = int.Parse(Console.ReadLine());
      // count = number - 1;
      // for (k = 1; k <= number; k++)
      // {
      //   for (i = 1; i <= count; i++)
      //     Console.Write(" ");
      //   count--;
      //   for (i = 1; i <= 2 * k - 1; i++)
      //     Console.Write("x");
      //   Console.WriteLine();
      // }
      // count = 1;
      // Console.WriteLine();
    }
  }
}
