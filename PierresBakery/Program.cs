using PierresBakery.Models;
using System;
using System.Collections.Generic;

namespace PierresBakery
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Pierres Wonderful Bakery!");
      Console.WriteLine("We have Bread & Pastys.");
      int choice = 0;
      do
      {
        DisplayIntroduction();
        Console.Write("Please Choose an option: ");
        choice = Convert.ToInt32(Console.ReadLine());
        if (choice == 1)
        {
          DisplayDeals(); 
        } 
        else if (choice == 2)
        {
          PlaceOrder();
        }
      } 
      while (choice != 3);
    }
    static void DisplayIntroduction()
    {
      Console.WriteLine("1. See all of our deals!!!");
      Console.WriteLine("2. Place an order.");
      Console.WriteLine("3. Exit");
    }
    static void DisplayDeals()
    {
      Console.WriteLine("The following deals are available.");
      Console.WriteLine("Bread: Buy 2 get 1 FREE!");
      Console.WriteLine("Pastry: Buy 1 for $3 or 3 for $5");
    }
    static void PlaceOrder()
    {
      Console.Write("How many loafs of bread would you like to order?: ");
      int breadAmount = Convert.ToInt32(Console.ReadLine());
      Console.Write("How many orders of pastries would you like to Get?: ");
      int pastryAmount = Convert.ToInt32(Console.ReadLine());
      Receipt(breadAmount, pastryAmount);
    }
    static void Receipt(int breadAmount, int pastryAmount)
    {
      Bread bread = new Bread();
      Pastry pastry = new Pastry();
      int orderTotal = bread.GetBreadTotalCost(breadAmount) + pastry.GetPastryTotalCost(pastryAmount);
      Console.WriteLine("Your Order is as follows:");
      Console.WriteLine($"You ordered {pastryAmount} Pastries");
      Console.WriteLine($"You ordered {breadAmount} Loafs of Bread");
      Console.Write($"Your total is: ${orderTotal} ");
      Console.WriteLine("Thank you for Ordering with PierresBakery");
      Console.WriteLine("You may pick up your order at the other counter");
    }
  }
}