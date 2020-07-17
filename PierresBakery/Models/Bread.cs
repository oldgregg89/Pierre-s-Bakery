using System;
using System.Collections.Generic;

namespace Bread.Models
{
  public class Bread
  {
    public string InputBread {get; set;}
    public int Cost {get; set;}
    public Bread(string bread)
    {
      InputBread = bread;
      Cost = 5;
    }
    public int breadDeal()
    {

    }
  }
}