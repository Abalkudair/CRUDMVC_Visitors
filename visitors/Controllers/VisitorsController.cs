using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using visitors.Models;
using visitors.Services;

namespace visitors.Controllers
{
    public class VisitorsController : Controller
    {
        private readonly IVisitor db;

        public VisitorsController(IVisitor db)
        {
            this.db = db;
        }
        // GET: Visitors
        public ActionResult Index()
        {
            var model = db.GetAll();
            return View(model);
        }


        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Visitor visitor)
        {
            if (ModelState.IsValid)
            {
                db.Add(visitor);
                return RedirectToAction("Index");
            }
            return View();
        }


    }
}