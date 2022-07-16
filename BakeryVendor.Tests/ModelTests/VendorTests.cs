using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using BakeryVendor.Models;

namespace BakeryVendor.Tests 
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("name", "description");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetProperties_ReturnProperties_Vendor()
    {
      string name = "Jenny's";
      string description = "gluten free bakery";
      Vendor newVendor = new Vendor(name, description);
      string resultVendor = newVendor.VendorName;
      string resultVendorDescr = newVendor.VendorDescription;
      Assert.AreEqual(name, resultVendor);
      Assert.AreEqual(description, resultVendorDescr);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      string name = "Jenny's";
      string description = "gluten free bakery";
      Vendor newVendor = new Vendor(name, description);
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }


  }
}