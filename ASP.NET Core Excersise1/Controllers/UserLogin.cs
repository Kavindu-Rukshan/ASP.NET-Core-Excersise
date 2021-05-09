using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_Core_Excersise1.Controllers
{
    public class UserLogin : Controller
    {
       // [HttpPost]
        public IActionResult Index()
        {
          
               return View();
        }

        //[HttpPost]
        //public IActionResult Index(Index formdata)
        //{
        //       if (!ModelState.IsValid)
        //    {
        //        return View(formdata);
        //    }
        //    return RedirectToAction("Index");
        }
    }

