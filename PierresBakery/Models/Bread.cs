using System;
using System.Collections.Generic;

namespace Bread.Models
{
  public class Bread
  {
    private static int cost;

    public string InputBread {get; set;}
    public int Cost {get; set;}
    public Bread(string bread)
    {
      InputBread = bread;
      Cost = 5;
    }
    public static void TwoforOne()
    {
      
    }
  }
}