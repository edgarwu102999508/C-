using System;

namespace Bee_Keeping
{
  class Program
  {
    static void Main(string[] args)
    {
      Bee bee1 = new Bee("John", 3.2f);
      Bee bee2 = new Bee("Paul", 2.7f);
      Bee bee3 = new Bee("George", 1.1f);
      Bee bee4 = new Bee("Ringo", 2.0f);
      Bee bee5 = new Bee("Kurt", 2.3f);
      Bee bee6 = new Bee("Dave", 7.4f);
      Bee bee7 = new Bee("Krist", 1.5f);


      BeeList bees1 = new BeeList();
      bees1.AddBee(bee1);
      bees1.AddBee(bee2);
      bees1.AddBee(bee3);
      bees1.AddBee(bee4);
      BeeList bees2 = new BeeList();
      bees2.AddBee(bee5);
      bees2.AddBee(bee6);
      bees2.AddBee(bee7);

      System.Console.WriteLine(bees2);










    }
  }
}
