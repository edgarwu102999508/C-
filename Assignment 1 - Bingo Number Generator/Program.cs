using System;
using System.Collections.Generic;


namespace Assignment_1___Bingo_Number_Generator
{
  class Program
  {
    static void Main(string[] args)
    {
      List<int> bingoNums = new List<int>();
      List<int> numList = new List<int>();

      // Main Menu
      string userChoice = string.Empty;
      do
      {
        System.Console.WriteLine("Welcome to the Swinburne Bingo Club");
        System.Console.WriteLine("1. Draw next number");
        System.Console.WriteLine("2. View all drawn numbers");
        System.Console.WriteLine("3. Check specific number");
        System.Console.WriteLine("4. Exit");
        userChoice = Console.ReadLine();
        if (userChoice.Contains("1"))
        {
          System.Console.WriteLine("1. Draw numbers");
          System.Console.WriteLine("2. Back");
          userChoice = Console.ReadLine();
          if (userChoice.Contains("2"))
          {
            continue;
          }
          else
          {
            drawNumber(bingoNums, numList);
            Console.WriteLine("\n");
            Console.Write("Press any key to continue...");
            Console.ReadLine();
            continue;
          }
        }
        else if (userChoice.Contains("2"))
        {
          System.Console.WriteLine("1. View all drawn numbers");
          System.Console.WriteLine("2. Sort drawn numbers");
          System.Console.WriteLine("3. Back");
          userChoice = Console.ReadLine();
          if (userChoice.Contains("3"))
          {
            continue;
          }
          else if (userChoice.Contains("2"))
          {
            sortList(bingoNums);
            Console.WriteLine("\n");
            Console.Write("Press any key to continue...");
            Console.ReadLine();
            continue;
          }
          else
          {
            foreach (var x in numList)
            {
              System.Console.Write(x);
            }
            Console.WriteLine("\n");
            Console.Write("Press any key to continue...");
            Console.ReadLine();
            continue;
          }
        }
        else if (userChoice.Contains("3"))
        {
          System.Console.WriteLine("1. Check specific number");
          System.Console.WriteLine("2. Back");
          userChoice = Console.ReadLine();
          if (userChoice.Contains("2"))
          {
            continue;
          }
          else
          {
            System.Console.WriteLine("\n");
            continue;
          }
        }

      } while (!userChoice.Contains("4"));


      static void drawNumber(List<int> bingoNums, List<int> numList)
      {
        int Min = 0;
        int Max = 10;
        Random randomNum = new Random();
        System.Console.Write("\n" + "Input the Max number: ");
        Max = int.Parse(Console.ReadLine());
        while (Max <= 0)
        {
          System.Console.WriteLine("The number can not be a Negative Number or Zero, Please try again.");
          Max = int.Parse(Console.ReadLine());
        }

        System.Console.Write("> ");
        for (int i = 0; i < Max; i++)
        {
          bingoNums.Add(Max);
          Console.Write(randomNum.Next(Min, Max));
          System.Console.Write(" ");
        }

        numList.AddRange(bingoNums);
      }
    }

    static void sortList(List<int> bingoNums)
    {
      bingoNums.Sort();
      foreach (int x in bingoNums)
      {
        System.Console.Write(x);
      }
    }
  }

}
