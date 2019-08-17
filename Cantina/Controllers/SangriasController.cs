using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Cantina.Models;

namespace Cantina.Controllers
{
    public class SangriasController : Controller
    {
        private CantinaBanco db = new CantinaBanco();

        // GET: Sangrias
        public ActionResult Index()
        {
            return View(db.Sangrias.ToList());
        }

        // GET: Sangrias/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sangria sangria = db.Sangrias.Find(id);
            if (sangria == null)
            {
                return HttpNotFound();
            }
            return View(sangria);
        }

        // GET: Sangrias/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sangrias/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_sangria,data,valor")] Sangria sangria)
        {
            if (ModelState.IsValid)
            {
                db.Sangrias.Add(sangria);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sangria);
        }

        // GET: Sangrias/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sangria sangria = db.Sangrias.Find(id);
            if (sangria == null)
            {
                return HttpNotFound();
            }
            return View(sangria);
        }

        // POST: Sangrias/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_sangria,data,valor")] Sangria sangria)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sangria).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sangria);
        }

        // GET: Sangrias/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sangria sangria = db.Sangrias.Find(id);
            if (sangria == null)
            {
                return HttpNotFound();
            }
            return View(sangria);
        }

        // POST: Sangrias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Sangria sangria = db.Sangrias.Find(id);
            db.Sangrias.Remove(sangria);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
