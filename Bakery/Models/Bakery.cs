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
    int price = 0;
    for(int i = 0; i<loaves; i++){
      if(i%3 == 0)
      {
        price += 0;
      } else {
        price += 5;
      }
    } return price;
    }
  }

   public class Pastry
  {
    public int PastryOrder(int pastry)
    {
      if(pastry == 1)
      {
        return 2;
      } else if (pastry == 2)
      {
        return 4;
      } else if(pastry == 4){
        return 7;
      } else if (pastry == 5)
      {
        return 9;
      } else if (pastry == 6)
      {
        return 10;
      } else {
        return 0;
      }
    }
  }
}
