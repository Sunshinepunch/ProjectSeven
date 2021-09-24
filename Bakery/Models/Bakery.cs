// using System;



namespace Bakery
{
  public class Bread
  {
    public static void Main()
    {
      //  Console.WriteLine("Welcome to Fresh Dawn Bakery! \n Our bread is priced as following: \n 1 loaf : $5 \n 2 loaves : $10 \n Buy 2 loaves and receive a third free!");
      //  Console.WriteLine("Our pastries are priced as follows: \n 1 pastry : $2 \n 3 pastries : $5 \n 4 pastries : $7 \n 5 pastries $9 \n 6 pastries : $10");
      //  Console.WriteLine("Please enter the number of loaves you would like to order: ");
      //  breadOrder = Console.ReadLine();
      //  Console.WriteLine("Please enter the number of pastries you would like to order: ");
      //  pastryOrder = Console.Readline();

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
      for(int i = 0; i<pastry; i++){
      if(i%1==0)
      {
        pastryprice += 2;
      } else if(i%3 == 0 ) {
        pastryprice += 5;
      } else if(i%4==0) {
        pastryprice +=7;
      } else if (i%5 == 0) {
        pastryprice += 9;
      } else {
        pastryprice+= 12;
      }
    } return pastryprice;
    }
  }
}
