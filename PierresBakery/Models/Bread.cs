using System;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Bread : Item
  {
    public Bread()
    {
    Cost = 5;
    }

    public int GetBreadTotalCost(int amount)
    {
      if (amount < 3)
      {
        return Cost * amount;
      }
      return (amount - (amount/3)) * Cost;
    }
  }
}