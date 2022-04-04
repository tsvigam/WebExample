using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebExample.Data;
using WebExample.Models;

namespace WebExample.Controllers
{
    public class ExpensceController : Controller
    {
        private readonly AppDbContext _db;
        public ExpensceController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Expensce> objList = _db.Expenceses;
            return View(objList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Expensce obj)
        {
            if (ModelState.IsValid)
            {
                _db.Expenceses.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Expensce obj)
        {
            if (ModelState.IsValid)
            {
                _db.Expenceses.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        public IActionResult Update(int id)
        {
            Expensce obj;
            obj = _db.Expenceses.Find(id);
            return View(obj);
        }

        public IActionResult Delete(int id)
        {
            Expensce obj;
            obj = _db.Expenceses.Find(id);
            _db.Expenceses.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
