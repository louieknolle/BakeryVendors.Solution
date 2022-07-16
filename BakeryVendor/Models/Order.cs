using System.Collections.Generic;
using System;

namespace BakeryVendor.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public int Loaves { get; set; }
    public int Pastry { get; set; }
    public DateTime Date { get; set; }
    public int Id { get; }
    private static List<Order> _instances = new List<Order> { };

    public static int CalculateOrderTotal(int numberLoaves, int numberPastry)
    {
      int priceBread;
      int pricePastry;
      int orderTotalPrice;
      
      if (numberLoaves < 100)
      {
        priceBread = 3;
      } 
      else if (numberLoaves >= 100 && numberLoaves < 200)
      {
        priceBread = 2;
      }
      else 
      {
        priceBread = 1;
      }

      if (numberPastry < 100)
      {
        pricePastry = 4;
      } 
      else if (numberPastry >= 100 && numberPastry < 200)
      {
        pricePastry = 3;
      }
      else 
      {
        pricePastry = 2;
      }

      return orderTotalPrice = (numberLoaves * priceBread) + (numberPastry * pricePastry);

    }

    public Order(string title, string description, int numberLoaves, int numberPastry, DateTime date)
    {
      Title = title;
      Description  = description;
      Loaves = numberLoaves;
      Pastry = numberPastry;
      Price = CalculateOrderTotal(numberLoaves, numberPastry);
      Date = date;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Order Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}