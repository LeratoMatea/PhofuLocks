using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PhofuLocks.Models;

namespace PhofuLocks.Controllers
{
    public class CarsController : Controller

    {
        private readonly ConnectionStringClass _cc;
        public CarsController(ConnectionStringClass cc)
        {
            _cc = cc;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

       [HttpPost]
       [ValidateAntiForgeryToken]
        public IActionResult Create(CarsClass sc)
        {
            _cc.Add(sc);
            _cc.SaveChanges();
            ViewBag.message = "Order for " + sc.CarMake + " " + sc.CarModel + " has been placed";
            return View();
        }


    }
}
