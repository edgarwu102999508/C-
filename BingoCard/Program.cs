using System;
using System.Collections.Generic;

namespace BingoCard
{
  class Program
  {
    static void Main(string[] args)
    {
      int Min = 0;
      int Max = 10;
      int[] bingoNum = new int[Max]
      Random randomNum = new Random();

      for (int i = 0; i < bingoNum.length; i++)
      {
        bingoNum[i] = randomNum.Next(Min, Max)
        System.Console.WriteLine(i);
      }




      foreach (int numList in bingoNum)
      {
        System.Console.WriteLine(numList);
      }

      Main Menu
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
          System.Console.WriteLine("1. Menu 1");
          System.Console.WriteLine("2. Back");
          userChoice = Console.ReadLine();
          if (userChoice.Contains("2"))
          {
            continue;
          }
          else
          {
            System.Console.WriteLine("Bingo!!");
            break;
          }
        }
        else if (userChoice.Contains("2"))
        {
          System.Console.WriteLine("1. Menu 2");
          System.Console.WriteLine("2. Back");
          userChoice = Console.ReadLine();
          if (userChoice.Contains("2"))
          {
            continue;
          }
          else
          {
            System.Console.WriteLine("Bingo!!");
            break;
          }
        }
        else if (userChoice.Contains("3"))
        {
          System.Console.WriteLine("1. Menu 3");
          System.Console.WriteLine("2. Back");
          userChoice = Console.ReadLine();
          if (userChoice.Contains("2"))
          {
            continue;
          }
          else
          {
            System.Console.WriteLine("Bingo!!");
            break;
          }
        }

      } while (userChoice != "4");



    }
  }
}
