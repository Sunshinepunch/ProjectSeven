using System;
using System.Collections.Generic;



namespace Bakery
{
  public class Pastry
  {

    public int Price {get; set; }

    public int OrderCost(int price)
    {
      Price = price;
      return price;
    }

    public int PastryOrder(int pastry)
    {
      int pastrycost = pastry*2;
      for (int i = 0; i < pastry; i++){
        if(i%3==0){
          pastrycost --;
        }
      } return pastrycost;
    }
  }
}
