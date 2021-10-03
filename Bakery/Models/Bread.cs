using System;
using System.Collections.Generic;



namespace Bakery
{
  public class Bread
  {
    public int Price {get; set; }

    public int OrderCost(int price)
    {
      Price = price;
      return price;
    }

    public int BreadOrder(int loaves)
    {
      int breadprice = 0;
      for(int i = 0; i<=loaves; i++){
        if(i%3 == 0)
        {
          breadprice += 0;
        } else {
          breadprice += 5;
        }
      } return breadprice;
    }
  }
}
