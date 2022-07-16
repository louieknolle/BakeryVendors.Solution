using System.Collections.Generic;
using System;

namespace BakeryVendor.Models
{
  public class Order
  {
    // public Order(string title, string description, int price, DateTime date)

    public string Vendor { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public DateTime Date { get; set; }

    public Order(string vendor, string description, int price, DateTime date)
    {
      Vendor = vendor;
      Description  = description;
      Price = price;
      Date = date;
    }
  }
}