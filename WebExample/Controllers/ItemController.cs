using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebExample.Data;
using WebExample.Models;

namespace WebExample.Controllers
{
    public class ItemController : Controller
    {
        private readonly AppDbContext _db;

        public ItemController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Item> objList = _db.Items.Include(ex => ex.ItemName).ToList();
            //IEnumerable<Item> objListI = _db.Items;
            //IEnumerable<Expensce> objListEx = _db.Expenceses;
            //var objList = (from i in objListI
            //               from ex in objListEx
            //               where (i.ItemName.Id == ex.Id)
            //               select new
            //               {
            //                   ex.ItemName,
            //                   i.Borrower,
            //                   i.Lender }).ToList(); 
            return View(objList);
        }

        //Get Create
        public IActionResult Create()
        {
            return View();
        }

        //Post create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Item obj)
        {
            var temp = (from id in _db.Expenceses
                        where id.ItemName == obj.ItemName.ItemName
                        select id.Id).First();
            obj.ExpensceId = temp;

            _db.Items.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
