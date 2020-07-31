using System;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  
  public class Pastry : Item
  {
    public Pastry()
    {
      Cost = 3;
    }
    public int GetPastryTotalCost(int amount)
    {
      if (amount<=0)
      {
        return 0;
      }
      if (amount < 3)
      {
        return Cost * amount;
      }
      return 5 + GetPastryTotalCost(amount-3);
    }
  }
}