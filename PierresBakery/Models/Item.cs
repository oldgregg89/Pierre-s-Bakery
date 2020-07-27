using System;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Item
  {
    public int Cost {get; set;}
    public int Quantity {get; set;}
    public int TotalCost {get; set;}
    public int SalesPrice {get; set;}

    public void AddBread(int numberOfBread)
    {
      Quantity += numberOfBread;
    }
    
    public void ClearOrder()
    {
      _instances.Clear();
    }
  }
}