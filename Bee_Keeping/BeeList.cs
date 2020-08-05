using System.Collections.Generic;

namespace Bee_Keeping
{
  public class BeeList
  {
    public List<Bee> beeList;

    public BeeList()
    {
      this.beeList = new List<Bee>();
    }

    public int Count { get; internal set; }

    public void AddBee(Bee newBee)
    {
      this.beeList.Add(newBee);
    }
  }
}