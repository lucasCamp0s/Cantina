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
    public class PedidoItemsController : Controller
    {
        private CantinaBanco db = new CantinaBanco();

        // GET: PedidoItems
        public ActionResult Index()
        {
            var pedidoItems = db.PedidoItems.Include(p => p.estoque).Include(p => p.pedido);
            return View(pedidoItems.ToList());
        }

        // GET: PedidoItems/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PedidoItem pedidoItem = db.PedidoItems.Find(id);
            if (pedidoItem == null)
            {
                return HttpNotFound();
            }
            return View(pedidoItem);
        }

        // GET: PedidoItems/Create
        public ActionResult Create()
        {
            ViewBag.id_produto = new SelectList(db.Estoques, "id_produto", "nome");
            ViewBag.id_pedido = new SelectList(db.Pedidoes, "id_pedido", "id_pedido");
            return View();
        }

        // POST: PedidoItems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_pedidoItem,id_pedido,id_produto,quantidade")] PedidoItem pedidoItem)
        {
            if (ModelState.IsValid)
            {
                db.PedidoItems.Add(pedidoItem);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_produto = new SelectList(db.Estoques, "id_produto", "nome", pedidoItem.id_produto);
            ViewBag.id_pedido = new SelectList(db.Pedidoes, "id_pedido", "statusVenda", pedidoItem.id_pedido);
            return View(pedidoItem);
        }

        // GET: PedidoItems/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PedidoItem pedidoItem = db.PedidoItems.Find(id);
            if (pedidoItem == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_produto = new SelectList(db.Estoques, "id_produto", "nome", pedidoItem.id_produto);
            ViewBag.id_pedido = new SelectList(db.Pedidoes, "id_pedido", "statusVenda", pedidoItem.id_pedido);
            return View(pedidoItem);
        }

        // POST: PedidoItems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_pedidoItem,id_pedido,id_produto,quantidade")] PedidoItem pedidoItem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pedidoItem).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_produto = new SelectList(db.Estoques, "id_produto", "nome", pedidoItem.id_produto);
            ViewBag.id_pedido = new SelectList(db.Pedidoes, "id_pedido", "statusVenda", pedidoItem.id_pedido);
            return View(pedidoItem);
        }

        // GET: PedidoItems/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PedidoItem pedidoItem = db.PedidoItems.Find(id);
            if (pedidoItem == null)
            {
                return HttpNotFound();
            }
            return View(pedidoItem);
        }

        // POST: PedidoItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PedidoItem pedidoItem = db.PedidoItems.Find(id);
            db.PedidoItems.Remove(pedidoItem);
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
