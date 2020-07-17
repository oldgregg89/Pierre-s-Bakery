using System;
using System.Collections.Generic;

namespace Pastry.Models
{
  public class Pastry
  {
    public string InputPastry {get; set;}
    public int Cost {get; set;}
    public Pastry(string pastry)
    {
      InputPastry = pastry;
      Cost = 2;
    }
    public int breadPastry()
    {
      
    }
  }
}