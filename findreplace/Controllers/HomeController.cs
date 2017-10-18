// using System.Collections.Generic;
// using System;
// using Microsoft.AspNetCore.Mvc;
// using Find.Models;
//
// namespace Find.Controllers
// {
//   public class HomeController : Controller
//   {
//     [HttpGet("/")]
//     public ActionResult Index()
//     {
//       return View();
//     }
//     [HttpPost("/findreplace/results")]
//     public ActionResult Results()
//     {
//       Rocker newRock = new Rocker (Request.Form["inputOne"], Request.Form["inputTwo"]);
//       return View (newRock);
//     }
//   }
// }
