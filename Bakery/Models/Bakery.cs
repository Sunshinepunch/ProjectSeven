// using System;



namespace Bakery
{
  public class Bread
  {
    public static void Main()
    {
       Console.WriteLine("Welcome to Fresh Dawn Bakery! \n Our bread is priced as following: \n 1 loaf : $5 \n 2 loaves : $10 \n Buy 2 loaves and receive a third free!");
       Console.WriteLine("Our pastries are priced as follows: \n 1 pastry : $2 \n 3 pastries : $5 \n 4 pastries : $7 \n 5 pastries $9 \n 6 pastries : $10");
       Console.WriteLine("Please enter the number of loaves you would like to order: ");
       int breadOrder = Console.ReadLine();
      //  int breadOrderNum = Convert.ToInt32(breadOrder);
       Console.WriteLine("Please enter the number of pastries you would like to order: ");
       int pastryOrder = Console.Readline();
      //  int breadOrderNum = Convert.ToInt32(breadOrder);
      int breadOrderPrice = this.BreadOrder(breadOrder);
      int pastryOrderPrice = this.PastryOrder(pastryOrder);
      int totalprice = breadOrderPrice + pastryOrderPrice;
      Console.WriteLine("Your total is " + ${totalprice} + "dollars. Thanks for choosing Fresh Dawn!");
    }
    public int BreadOrder(int loaves)
    {
    int breadprice = 0;
    for(int i = 0; i<loaves; i++){
      if(i%3 == 0)
      {
        breadprice += 0;
      } else {
        breadprice += 5;
      }
    } return breadprice;
    }
  }

   public class Pastry
  {
    public int PastryOrder(int pastry)
    {
      int pastryprice = 0;
      int pastrynum = pastry%6;
      int pastrynum2 = pastry - pastrynum;
      if(pastrynum == 0 && pastry > 0)
      {
        pastryprice += ((pastry/6) * 10);
      } else if(pastry == 1){
        pastryprice += 2;
      } else if(pastry == 3){
        pastryprice += 5;
      } else if(pastry == 4){
        pastryprice += 7;
      } else if(pastry == 5){
        pastryprice += 9;
      } else if(pastrynum == 1 && pastrynum2 > 0){
        pastryprice += ((pastrynum2/6)*10);
        pastryprice += 2;
      } else if(pastrynum == 2 && pastrynum2 >0) {
        pastryprice += ((pastrynum2/6)*10);
        pastryprice += 4;
      }else if(pastrynum == 3 && pastrynum2 >0) {
        pastryprice += ((pastrynum2/6)*10);
        pastryprice += 5;
      } else if(pastrynum == 4 && pastrynum2 >0) {
        pastryprice += ((pastrynum2/6)*10);
        pastryprice += 7;
      }else if(pastrynum == 5 && pastrynum2 >0) {
        pastryprice += ((pastrynum2/6)*10);
        pastryprice += 9;
      } else {
        return pastryprice;
      }
     return pastryprice;
    }
  }
}
