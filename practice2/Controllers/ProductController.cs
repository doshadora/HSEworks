using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using practice2.DAL;

namespace practice2.Controllers
{
    public class ProductController : Controller
    {
        private cswEntities db = new cswEntities();

        // GET: Product
        public ActionResult Index()
        {
            ViewBag.id = AccountController.id;
            var product = db.product.Include(p => p.dict_category);
            return View(product.ToList());
        }

        // GET: Product/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            product product = db.product.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            ViewBag.category_id = new SelectList(db.dict_category, "category_id", "category_name");
            return View();
        }

        // POST: Product/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "product_id,product_code,product_name,product_photo,product_info,category_id,store_id")] product product, HttpPostedFileBase ProdPhoto)
        {
            if (ModelState.IsValid)
            {
                byte[] imageData = null;

                using (var binaryReader = new BinaryReader(ProdPhoto.InputStream))
                {
                    imageData = binaryReader.ReadBytes(ProdPhoto.ContentLength);
                }
                product.product_photo = imageData;

                product.store_id = AccountController.id;
                db.product.Add(product);
                db.SaveChanges();

                prodId = product.product_id;
                return RedirectToAction("CreatePrice");
            }

            ViewBag.category_id = new SelectList(db.dict_category, "category_id", "category_name", product.category_id);
            return View(product);
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            product product = db.product.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            ViewBag.category_id = new SelectList(db.dict_category, "category_id", "category_name", product.category_id);
            return View(product);
        }

        // POST: Product/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "product_id,product_code,product_name,product_photo,product_info,category_id,store_id")] product product)
        {
            if (ModelState.IsValid)
            {
                db.Entry(product).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.category_id = new SelectList(db.dict_category, "category_id", "category_name", product.category_id);
            return View(product);
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            product product = db.product.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Product/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            product product = db.product.Find(id);
            db.product.Remove(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public static int prodId;

        // GET: Price
        public ActionResult IndexPrice(int? id)
        {
            prodId = Convert.ToInt32(id);
            var price = db.price.Where(p => p.product_id == id).Include(p => p.product).OrderByDescending(p => p.version_date);
            return View(price.ToList());
        }

        // GET: Price/Create
        public ActionResult CreatePrice()
        {
            return View();
        }

        // POST: Price/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreatePrice([Bind(Include = "price_version_id,product_id,product_price,version_date,price_comment")] price price)
        {
            if (ModelState.IsValid)
            {
                price.version_date = DateTime.Now;
                price.product_id = prodId;
                db.price.Add(price);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.product_id = prodId;
            return View(price);
        }

        // GET: Size
        public ActionResult IndexSize(int? id)
        {
            prodId = Convert.ToInt32(id);
            var product_address = db.product_address.Include(p => p.dict_size).Include(p => p.product).Where(p => p.product_id == prodId).OrderByDescending(p => p.change_date);
            return View(product_address.ToList());
        }


        // GET: Size/Create
        public ActionResult CreateSize()
        {
            ViewBag.size_id = new SelectList(db.dict_size, "size_id", "size_value");
            ViewBag.product_id = new SelectList(db.product.Where(p => p.store_id == AccountController.id), "product_id", "product_name");
            return View();
        }

        // POST: Size/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateSize([Bind(Include = "product_address_id,product_id,product_amount,change_date,size_id")] product_address product_address)
        {
            if (ModelState.IsValid)
            {
                product_address.change_date = DateTime.Now;
                db.product_address.Add(product_address);
                db.SaveChanges();

                product_address.change_date = DateTime.Today;
                product_address.product_amount = 0;
                product_address.size_id = 32;
                db.product_address.Add(product_address);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.size_id = new SelectList(db.dict_size, "size_id", "size_value", product_address.size_id);
            ViewBag.product_id = new SelectList(db.product, "product_id", "product_name", product_address.product_id);
            return View(product_address);
        }

        // GET: Size/Edit/5
        public ActionResult EditSize(int? id)
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
            ViewBag.product_id = new SelectList(db.product, "product_id", "product_name", product_address.product_id);
            return View(product_address);
        }

        // POST: Size/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditSize([Bind(Include = "product_address_id,product_id,product_amount,change_date,size_id")] product_address product_address)
        {
            if (ModelState.IsValid)
            {
                db.Entry(product_address).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.size_id = new SelectList(db.dict_size, "size_id", "size_value", "country_name", product_address.size_id);
            ViewBag.product_id = new SelectList(db.product, "product_id", "product_name", product_address.product_id);
            return View(product_address);
        }

        // GET: Size/Delete/5
        public ActionResult DeleteSize(int? id)
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
        [HttpPost, ActionName("DeleteSize")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmedSize(int id)
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
