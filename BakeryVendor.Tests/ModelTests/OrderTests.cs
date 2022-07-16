using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using BakeryVendor.Models;

namespace BakeryVendor.Tests 
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      DateTime orderDate = new DateTime(2022, 7, 15);
      Order newOrder = new Order("Ricky's", "Bread Reorder", 5, 6, orderDate);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      DateTime orderDate = new DateTime(2022, 7, 15);
      Order newOrder = new Order("Ricky's", "Bread Reorder", 5, 6, orderDate);
      string result = newOrder.Title;
      Assert.AreEqual("Ricky's", result);
    }

    [TestMethod]
    public void GetDate_ReturnsDate_DateTime()
    {
      DateTime orderDate = new DateTime(2022, 7, 15);
      Order newOrder = new Order("Ricky's", "Bread Reorder", 5, 6, orderDate);
      DateTime result = newOrder.Date;
      Assert.AreEqual(orderDate, result);
    }

    [TestMethod]
    public void GetPrice_ReturnsPrice_Price()
    {
      DateTime orderDate = new DateTime(2022, 7, 15);
      int testPrice = Order.CalculateOrderTotal(5,6);
      Order newOrder = new Order("Ricky's", "Bread Reorder", 5, 6, orderDate);
      int result = newOrder.Price;
      Assert.AreEqual(testPrice, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newList = new List<Order> { };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsOrder_OrderList()
    {
      DateTime orderDate = new DateTime(2022, 7, 15);
      DateTime orderDate2 = new DateTime(2022, 7, 16);
      Order newOrder1 = new Order("Ricky's", "Bread Reorder", 5, 6, orderDate);
      Order newOrder2 = new Order("Rick's", "Bread order", 50, 60, orderDate2);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
  }
}