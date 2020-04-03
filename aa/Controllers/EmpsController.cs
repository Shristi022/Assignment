using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aa.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace aa.Controllers
{
    public class EmpsController : Controller
    {
        List<Emp> e = new List<Emp>()
        {
        new Emp{Id=1,Name="shristi",Designation="IT head",Contact=5265265652 },
         new Emp{Id=2,Name="savi",Designation=" hr head",Contact=989965652 },
          new Emp{Id=3,Name="deba",Designation="manager",Contact=6544265652 },

        };
        // GET: Emps
        public ActionResult Index()
        {
            ViewBag.Emps = e;
            return View(e);
        }

        // GET: Emps/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Emps/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Emps/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Emps/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Emps/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Emps/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Emps/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}