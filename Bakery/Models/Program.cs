using System;
using System.Collections.Generic;
using Bakery;




namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      Bread theBread = new Bread();
      Pastry thePastry = new Pastry();
      Console.WriteLine("Welcome to Fresh Dawn Bakery! \n Our bread is priced as following: \n 1 loaf : $5 \n 2 loaves : $10 \n Buy 2 loaves and receive a third free!");
      Console.WriteLine("Our pastries are priced as follows: \n 1 pastry : $2 \n 3 pastries : $5 \n 4 pastries : $7 \n 5 pastries $9 \n 6 pastries : $10");
      Console.WriteLine("Please enter the number of loaves you would like to order: ");
      string breadpls = Console.ReadLine();
      int breadOrderNum = Convert.ToInt32(breadpls);
      Console.WriteLine("Please enter the number of pastries you would like to order: ");
      string pastrypls = Console.ReadLine();
      int pastryOrderNum = Convert.ToInt32(pastrypls);
      int totalprice = thePastry.OrderCost(thePastry.PastryOrder(pastryOrderNum)) + theBread.OrderCost(theBread.BreadOrder(breadOrderNum));
      Console.WriteLine("Your total is " + totalprice + " dollars. Thanks for choosing Fresh Dawn!");
    }
  }
}