using System.Collections.Generic;

namespace Bee_Keeping
{
  public class Beehive
  {
    Bee bee;

    public List<Bee> Bees;
    public int MaxAmountOfBees;

    public Beehive(List<Bee> bees)
    {
      Bees = bees;
    }

    public float CollectHoney(int days)
    {
      float Amount = days * bee.Size * 0.2f;
      return Amount;
    }
  }
}