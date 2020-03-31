using System;
using System.Collections.Generic;
using System.Linq;

namespace Arrays_and_Lists
{
  class Program
  {
    static void Main(string[] args)
    {
      // ========= Using Array 1 =========
      // string[] name = { "Edgar", "Claudia", "Hunter", "Luna", "Stella" };
      // foreach (string i in name)
      // {
      //   Console.WriteLine("Hello" + " " + "<" + i + ">");
      // }


      // ========= Using Arrays 2 =========
      // int[] num = { 34, 5, 67, 1, 99, 34, 44, 78, 34, 0 };
      // int total = 0;
      // for (int i = 0; i < num.Length; i++)
      // {
      //   total += num[i];
      // }
      // System.Console.WriteLine("Total: " + total);


      // ========= Using Lists 1 =========
      // int listCapacity = 5;
      // var list = new List<int>(listCapacity);
      // System.Console.WriteLine("Enter " + listCapacity + " numbers: ");
      // for (int i = 0; i < list.Capacity; i++)
      // {
      //   int input = int.Parse(Console.ReadLine());
      //   list.Add(input);
      //   list[i] = input;
      // }

      // System.Console.WriteLine("=========== Output ===========");

      // for (int i = 0; i < listCapacity; i++)
      // {
      //   System.Console.WriteLine(list[i]);
      // }

      // System.Console.WriteLine("=========== Check a number ===========");

      // System.Console.WriteLine("Enter a new number: ");
      // int extraInput = int.Parse(Console.ReadLine());

      // if (list.Contains(extraInput))
      // {
      //   System.Console.WriteLine("The number exist in the list.");
      // }
      // else
      // {
      //   System.Console.WriteLine("This number doesn't exist.");
      // }


      // ========= Using Lists 2 =========
      // int listCapacity = 5;
      // int element = 0;
      // int rpTimes = 1;
      // var list = new List<int>(listCapacity);
      // System.Console.WriteLine("Enter " + listCapacity + " numbers: ");
      // for (int i = 0; i < list.Capacity; i++)
      // {
      //   int input = int.Parse(Console.ReadLine());
      //   list.Add(input);
      //   list[i] = input;
      // }

      // for (int i = 0; i < list.Capacity - 1; i++)
      // {
      //   for (int j = i + 1; j < list.Capacity - 1; j++)
      //   {
      //     if (list[i] == list[j])
      //     {
      //       element = list[i];
      //       rpTimes++;
      //       break;
      //     }
      //   }
      // }
      // Console.WriteLine("the repeat element is {0} and it's appears {1} times ", element, rpTimes);


      // ========= Using Lists 3 =========
      System.Console.WriteLine("Enter words: ");
      List<String> listWords = new List<String>();
      while (!listWords.Contains("STOP"))
      {
        string input = Console.ReadLine();
        listWords.Add(input);
      }

      listWords.Reverse();
      System.Console.WriteLine("\n > Reversed List < \n");
      foreach (string i in listWords)
      {
        System.Console.WriteLine(i);
      }
      System.Console.WriteLine("\n ========== End ========== \n");
    }
  }
}
