using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PhofuLocks.Controllers
{
    public class DLogin : Controller
    {
        // GET: DLogin
        public ActionResult Index()
        {
            return View();
        }

        // GET: DLogin/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DLogin/Create
        public ActionResult Create()
        {
            return View();
        }



        // POST: DLogin/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DLogin/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DLogin/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DLogin/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DLogin/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
