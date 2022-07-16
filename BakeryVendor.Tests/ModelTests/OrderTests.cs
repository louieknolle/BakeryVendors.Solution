using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using BakeryVendor.Models;

namespace BakeryVendor.Tests 
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      DateTime orderDate = new DateTime(2022, 7, 15);
      Order newOrder = new Order("Ricky's", "Bread Reorder", 75, orderDate);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetVendor_ReturnsVendor_String()
    {
      DateTime orderDate = new DateTime(2022, 7, 15);
      Order newOrder = new Order("Ricky's", "Bread Reorder", 75, orderDate);
      string result = newOrder.Vendor;
      Assert.AreEqual("Ricky's", result);
    }

    [TestMethod]
    public void GetDate_ReturnsDate_DateTime()
    {
      DateTime orderDate = new DateTime(2022, 7, 15);
      Order newOrder = new Order("Ricky's", "Bread Reorder", 75, orderDate);
      DateTime result = newOrder.Date;
      Assert.AreEqual(orderDate, result);
    }
  }
}