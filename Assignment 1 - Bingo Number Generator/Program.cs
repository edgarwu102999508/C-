using System;


namespace Assignment_1___Bingo_Number_Generator
{
  class Program
  {
    static void Main(string[] args)
    {

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
            DrawNumber();
            Console.WriteLine("\n");
            continue;
          }
        }
        else if (userChoice.Contains("2"))
        {
          System.Console.WriteLine("1. View all drawn numbers");
          System.Console.WriteLine("2. Back");
          userChoice = Console.ReadLine();
          if (userChoice.Contains("2"))
          {
            continue;
          }
          else
          {
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

    }


    public static Array DrawNumber()
    {
      int Min = 0;
      int Max = 0;
      int[] bingoNum;
      Random randomNum = new Random();

      System.Console.Write("Input the Max number: ");
      Max = int.Parse(Console.ReadLine());
      while (Max <= 0)
      {
        System.Console.WriteLine("The number can not be a Negative Number or Zero, Please try again.");
        Max = int.Parse(Console.ReadLine());
      }

      bingoNum = new int[Max];
      for (int i = 0; i < bingoNum.Length; i++)
      {
        int Num = bingoNum[i];
        Console.Write(randomNum.Next(Min, Max));
        System.Console.Write(" ");
      }
      return bingoNum;
    }
  }
}
