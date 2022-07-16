using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using BakeryVendor.Models;

namespace BakeryVendor.Controllers
{
  public class VendorsController : Controller
  {

    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string vendorVendorName, string vendorVendorDescription)
    {
      Vendor newVendor = new Vendor(vendorVendorName, vendorVendorDescription);
      return RedirectToAction("Index");
    }

    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor selectedVendor = Vendor.Find(id);
      List<Order> categoryOrders = selectedVendor.Orders;
      model.Add("vendor", selectedVendor);
      model.Add("orders", categoryOrders);
      return View(model);
    }


    // This one creates new Orders within a given Vendor, not new Vendors:

    [HttpPost("/vendors/{vendorId}/orders")]
    public ActionResult Create(int vendorId, string title, string description, int numberLoaves, int numberPastry, DateTime date)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor foundVendor = Vendor.Find(vendorId);
      Order newOrder = new Order(title, description, numberLoaves, numberPastry, date);
      foundVendor.AddOrder(newOrder);
      List<Order> vendorOrders = foundVendor.Orders;
      model.Add("orders", vendorOrders);
      model.Add("vendor", foundVendor);
      return View("Show", model);
    }

  }
}