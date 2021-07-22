using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ToDoListProject.Models
{
    public class Te : Controller
    {
        // GET: Te
        public ActionResult Index()
        {
            //cia gaunu visus irasus is json failo
            return View(/*cia paduodame*/);
        }

        // GET: Te/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Te/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Te/Create
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

        // GET: Te/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Te/Edit/5
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

        // GET: Te/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Te/Delete/5
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
