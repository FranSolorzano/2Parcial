using SegundoParcial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SegundoParcial.Controllers
{
    public class CajeroController : Controller
    {
        
        
     [HttpGet]

      public ActionResult Index1()
      {
         return View();
      }

      [HttpPost]

      public ActionResult Index1(Cajero C)
      {
         if (C.cantidad % 5 == 0)
         {
            return Redirect("VistaDatos");
         }
         else
         {
            return Redirect("Error");

         }

      }

      [HttpGet]

      public ActionResult Error()
      {
          return View();

      }

      [HttpGet]

      public ActionResult VistaDatos()
      {
          return View();

      }

    }
}

