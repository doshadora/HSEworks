using practice2.DAL;
using practice2.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace practice2.Controllers
{
    public class OrderController : Controller
    {
        private cswEntities db = new cswEntities();

        // GET: Order
        public ActionResult Index()
        {
            OrderViewModel model = new OrderViewModel();
            return View(model.CreateModelStore());
        }

        public static int cid;
        public static int stat;

        // GET: Order/Edit/5
        public ActionResult EditStatus(int? id, int statId)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            status_of_cheque soc = db.status_of_cheque.Include(p => p.cheque_set).Include(p => p.dict_product_status).Where(p => p.cheque_prod_id == id && p.cheque_status_id == statId).Select(p => p).FirstOrDefault();
            if (soc == null)
            {
                return HttpNotFound();
            }

            cid = Convert.ToInt32(id);
            stat = statId;

            ViewBag.stats = db.dict_product_status;
            return View(soc);
        }

        // POST: Order/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditStatus()
        {
            if (ModelState.IsValid)
            {
                status_of_cheque soc = new status_of_cheque();
                soc.status_date = DateTime.Now;
                soc.cheque_status_id = stat + 1;
                soc.cheque_prod_id = cid;
                db.status_of_cheque.Add(soc);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            OrderViewModel model = new OrderViewModel();
            return View(model.CreateModelStore());
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
