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
      Order newOrder = new Order("test");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetVendor_ReturnsVendor_String()
    {
      string vendor = "Ralph's Deli";
      Order newOrder = new Order(vendor);
      string result = newOrder.Vendor;
      Assert.AreEqual(vendor, result);
    }
  }
}