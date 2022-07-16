using System.Collections.Generic;
using System;

namespace BakeryVendor.Models
{
  public class Order
  {
    public string Vendor { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public DateTime Date { get; set; }
    private static List<Order> _instances = new List<Order> { };

    public Order(string vendor, string description, int price, DateTime date)
    {
      Vendor = vendor;
      Description  = description;
      Price = price;
      Date = date;
      _instances.Add(this);
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}