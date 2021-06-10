using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using practice2.DAL;

namespace practice2.Controllers
{
    public class SizeController : Controller
    {
        private cswEntities db = new cswEntities();

        // GET: Size
        public ActionResult Index()
        {
            var product_address = db.product_address.Include(p => p.dict_size).Include(p => p.product);
            return View(product_address.ToList());
        }

        // GET: Size/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            product_address product_address = db.product_address.Find(id);
            if (product_address == null)
            {
                return HttpNotFound();
            }
            return View(product_address);
        }

        // GET: Size/Create
        public ActionResult Create()
        {
            ViewBag.size_id = new SelectList(db.dict_size, "size_id", "size_value");
            ViewBag.product_id = new SelectList(db.product, "product_id", "product_code");
            return View();
        }

        // POST: Size/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "product_address_id,product_id,product_amount,change_date,size_id")] product_address product_address)
        {
            if (ModelState.IsValid)
            {
                db.product_address.Add(product_address);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.size_id = new SelectList(db.dict_size, "size_id", "size_value", product_address.size_id);
            ViewBag.product_id = new SelectList(db.product, "product_id", "product_code", product_address.product_id);
            return View(product_address);
        }

        // GET: Size/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            product_address product_address = db.product_address.Find(id);
            if (product_address == null)
            {
                return HttpNotFound();
            }
            ViewBag.size_id = new SelectList(db.dict_size, "size_id", "size_value", product_address.size_id);
            ViewBag.product_id = new SelectList(db.product, "product_id", "product_code", product_address.product_id);
            return View(product_address);
        }

        // POST: Size/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "product_address_id,product_id,product_amount,change_date,size_id")] product_address product_address)
        {
            if (ModelState.IsValid)
            {
                db.Entry(product_address).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            var temp = product_address.dict_size.size_value + " " + product_address.dict_size.country_name;
            ViewBag.size_id = new SelectList(db.dict_size, "size_id", "size_value", product_address.size_id);
            ViewBag.product_id = new SelectList(db.product, "product_id", "product_code", product_address.product_id);
            return View(product_address);
        }

        // GET: Size/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            product_address product_address = db.product_address.Find(id);
            if (product_address == null)
            {
                return HttpNotFound();
            }
            return View(product_address);
        }

        // POST: Size/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            product_address product_address = db.product_address.Find(id);
            db.product_address.Remove(product_address);
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
