using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Find.Models;

namespace Find.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
    [HttpPost("/findreplace/results")]
    public ActionResult Results()
    {
      Finder newFind = new Finder (Request.Form["inputOne"], Request.Form["inputTwo"], Request.Form["inputThree"]);
      return View (newFind);
    }
  }
}
