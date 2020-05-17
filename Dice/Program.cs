using System;
using System.Collections.Generic;

namespace Dice
{
  class Program
  {
    static void Main(string[] args)
    {
      Die d1 = new Die();
      Die d2 = new Die(12);
      Die d3 = new Die(24);
      List<Die> diceList1 = new List<Die>();
      diceList1.Add(d1);
      diceList1.Add(d2);
      diceList1.Add(d3);

      List<Die> diceList2 = new List<Die>();
      diceList2.Add(d2);
      Person p1 = new Person("Edgar", diceList1);
      Person p2 = new Person("Claudia", diceList2);

      System.Console.WriteLine(p1.Name);
      System.Console.WriteLine(p1.Dice.Count);

      System.Console.WriteLine(p2.Name);
      System.Console.WriteLine(p2.Dice.Count);
      p2.AddNewDie(18);
      System.Console.WriteLine(p2.Dice.Count);

      for (int i = 0; i < 20; i++)
      {
        System.Console.WriteLine(d1.Roll());
      }
    }
  }

  public class Die
  {
    public int NumOfSides;

    public Die(int NumOfSides)
    {
      this.NumOfSides = NumOfSides;
    }

    public Die()
    {
      this.NumOfSides = 6;
    }

    public int Roll()
    {
      Random rand = new Random();
      int roll = rand.Next(1, this.NumOfSides + 1);
      return roll;
    }
  }

  public class Person
  {
    public string Name;
    public List<Die> Dice;

    public Person(string Name, List<Die> Dice)
    {
      this.Name = Name;
      this.Dice = Dice;
    }


    public int RollDie(int Die)
    {
      int Roll = Dice(die).Roll();
      return 0;
    }

    public int RollAllDie()
    {
      return 0;
    }

    public void AddNewDie(int sides)
    {
      Die d = new Die(sides);
      this.Dice.Add(d);
    }
  }
}
