using practice2.DAL;
using practice2.Models.Home;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace practice2.Controllers
{
    public class HomeController : Controller
    {
        cswEntities cs = new cswEntities();
        public ActionResult Index(string search)
        {
            if (search != null)
            {
                ViewBag.searchEmpty = false;
            }
            else ViewBag.searchEmpty = true;

            HomeIndexViewModel model = new HomeIndexViewModel();
            return View(model.CreateModel(search));
        }

        public ActionResult Checkout()
        {
            int id = AccountController.id;

            SqlParameter[] param = new SqlParameter[]{
                new SqlParameter("@cust_id",id)
            };
            SqlParameter[] param1 = new SqlParameter[]{
                new SqlParameter("@cust_id",id)
            };
            SqlParameter[] param2 = new SqlParameter[]{
                new SqlParameter("@cust_id",id)
            };
            SqlParameter[] param3 = new SqlParameter[]{
                new SqlParameter("@cust_id",id)
            };
            SqlParameter[] param4 = new SqlParameter[]{
                new SqlParameter("@cust_id",id)
            };
            SqlParameter[] param5 = new SqlParameter[]{
                new SqlParameter("@cust_id",id)
            };

            var cheque = cs.Database.SqlQuery<cheque_set>("GetCustBag @cust_id", param).ToList();
            ViewBag.prodad = cs.Database.SqlQuery<product_address>("GetCustBag @cust_id", param1).ToList();
            ViewBag.product = cs.Database.SqlQuery<product>("GetCustBag @cust_id", param2).ToList();
            ViewBag.store = cs.Database.SqlQuery<store>("GetCustBag @cust_id", param3).ToList();
            ViewBag.size_id = cs.Database.SqlQuery<dict_size>("GetCustBag @cust_id", param4).ToList();
            ViewBag.price = cs.Database.SqlQuery<price>("GetCustBag @cust_id", param5).ToList();

            return View(cheque);
        }

        public ActionResult CheckoutDetails()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddToCart(int productId)
        {
            if (ModelState.IsValid)
            {
                cheque_set cheque_set = new cheque_set();
                cheque_set.cust_id = AccountController.id;
                cheque_set.product_address_id = cs.product_address.Include(p => p.product).Where(p => p.product_id == productId && p.size_id == 32 && p.product_amount == 0).Select(p => p.product_address_id).FirstOrDefault();
                cheque_set.cheque_product_amount = 1;
                cheque_set.prod_date = DateTime.Now;
                cs.cheque_set.Add(cheque_set);
                cs.SaveChanges();

                status_of_cheque soc = new status_of_cheque();
                soc.cheque_prod_id = cheque_set.cheque_prod_id;
                soc.cheque_status_id = 1;
                soc.status_date = DateTime.Now;
                cs.status_of_cheque.Add(soc);
                cs.SaveChanges();

                TempData["Success"] = "Success message text.";

                return RedirectToAction("Index");
            }

            return View("Index");
        }

        public static int prodadId;
        public static SelectList sizes;

        public ActionResult EditCart(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            cheque_set cheque_set = cs.cheque_set.Include(p => p.product_address).Include(p => p.product_address.product).Include(p => p.product_address.dict_size).Include(p => p.product_address.product.store).Where(p => p.cheque_prod_id == id).FirstOrDefault();
            int tempProdId = cs.cheque_set.Include(p => p.product_address).Where(p => p.cheque_prod_id == id).Select(p => p.product_address.product_id).FirstOrDefault();

            @ViewBag.price = cs.price.OrderByDescending(p => p.version_date).Where(p => p.product_id == tempProdId).Select(p => p.product_price).FirstOrDefault();
            prodadId = cheque_set.product_address_id;

            if (cheque_set == null)
            {
                return HttpNotFound();
            }
            ViewBag.product_id = new SelectList(cs.product, "product_id", "product.product_name", cheque_set.product_address.product_id);

            sizes = new SelectList(cs.product_address.Include(p => p.dict_size).Where(p => p.size_id == p.dict_size.size_id && p.size_id != 32 && p.product_id == tempProdId).Select(p => p.dict_size).Distinct().OrderBy(p => p.size_id), "size_id", "size_value", cheque_set.product_address.size_id);
            ViewBag.size_id = sizes;

            return View(cheque_set);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditCart([Bind(Include = "cheque_prod_id,cust_id,product_address_id,cheque_product_amount")] cheque_set cheque_set, int size_id)
        {
            if (ModelState.IsValid)
            {
                int tempId = cs.product_address.Where(p => p.product_address_id == prodadId).Select(p => p.product_id).FirstOrDefault();
                int tempQuantity = cs.product_address.Where(p => p.product_id == tempId && p.size_id == size_id).OrderByDescending(p => p.change_date).Select(p => p.product_amount).FirstOrDefault();
                cheque_set.product_address_id = cs.product_address.Where(p => p.product_id == tempId && p.size_id == size_id).OrderByDescending(p => p.change_date).Select(p => p.product_address_id).FirstOrDefault();
                cheque_set.cust_id = AccountController.id;
                cheque_set.prod_date = DateTime.Now;

                if (cheque_set.cheque_product_amount > tempQuantity)
                {
                    ModelState.AddModelError("", "Вы выбрали больше товаров, чем есть в наличии (" + tempQuantity + ")");
                }
                else
                {
                    cs.Entry(cheque_set).State = EntityState.Modified;
                    cs.SaveChanges();
                    return RedirectToAction("Checkout");
                }
            }

            ViewBag.size_id = sizes;
            return View(cheque_set);
        }

        public ActionResult DeleteCart(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            cheque_set cheque_set = cs.cheque_set.Find(id);
            if (cheque_set == null)
            {
                return HttpNotFound();
            }
            return View(cheque_set);
        }

        // POST: Product/Delete/5
        [HttpPost, ActionName("DeleteCart")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteCartConfirmed(int id)
        {
            cheque_set cheque_set = cs.cheque_set.Find(id);

            cs.cheque_set.Remove(cheque_set);
            cs.SaveChanges();

            return RedirectToAction("Checkout");
        }

        public static IEnumerable<status_of_cheque> soc;

        [HttpGet]
        public ActionResult MakeOrder()
        {
            int id = AccountController.id;

            SqlParameter[] param = new SqlParameter[]{
                new SqlParameter("@cust_id",id)
            };

            soc = cs.Database.SqlQuery<status_of_cheque>("GetCustBag @cust_id", param).ToList();
            return View(soc);
        }

        [HttpPost, ActionName("MakeOrder")]
        [ValidateAntiForgeryToken]
        public ActionResult MakeOrder(IEnumerable<status_of_cheque> soc1)
        {
            if (ModelState.IsValid)
            {
                foreach (var item in soc)
                {
                    item.status_date = DateTime.Now;
                    item.cheque_status_id = 2;
                    cs.status_of_cheque.Add(item);

                    cheque_set cheque_set = cs.cheque_set.Find(item.cheque_prod_id);
                    product_address product_address = cs.product_address.Find(cheque_set.product_address_id);

                    product_address prodad = new product_address();
                    prodad.product_id = product_address.product_id;
                    prodad.size_id = product_address.size_id;
                    prodad.change_date = DateTime.Now;
                    prodad.product_amount = Convert.ToInt32(product_address.product_amount) - Convert.ToInt32(cheque_set.cheque_product_amount);
                    cs.product_address.Add(prodad);
                }
                cs.SaveChanges();

            }
            return RedirectToAction("Checkout", "Home");
        }

        public ActionResult CustOrder()
        {
            int id = AccountController.id;

            SqlParameter[] param = new SqlParameter[]{
                new SqlParameter("@cust_id",id)
            };
            SqlParameter[] param1 = new SqlParameter[]{
                new SqlParameter("@cust_id",id)
            };
            SqlParameter[] param2 = new SqlParameter[]{
                new SqlParameter("@cust_id",id)
            };
            SqlParameter[] param3 = new SqlParameter[]{
                new SqlParameter("@cust_id",id)
            };
            SqlParameter[] param4 = new SqlParameter[]{
                new SqlParameter("@cust_id",id)
            };
            SqlParameter[] param5 = new SqlParameter[]{
                new SqlParameter("@cust_id",id)
            };
            SqlParameter[] param6 = new SqlParameter[]{
                new SqlParameter("@cust_id",id)
            };
            SqlParameter[] param7 = new SqlParameter[]{
                new SqlParameter("@cust_id",id)
            };

            var cheque = cs.Database.SqlQuery<cheque_set>("GetCustOrder @cust_id", param).ToList();
            ViewBag.prodad = cs.Database.SqlQuery<product_address>("GetCustOrder @cust_id", param1).ToList();
            ViewBag.product = cs.Database.SqlQuery<product>("GetCustOrder @cust_id", param2).ToList();
            ViewBag.store = cs.Database.SqlQuery<store>("GetCustOrder @cust_id", param3).ToList();
            ViewBag.size = cs.Database.SqlQuery<dict_size>("GetCustOrder @cust_id", param4).ToList();
            ViewBag.stat = cs.Database.SqlQuery<status_of_cheque>("GetCustOrder @cust_id", param5).ToList();
            ViewBag.price = cs.Database.SqlQuery<price>("GetCustOrder @cust_id", param6).ToList();
            ViewBag.statName = cs.Database.SqlQuery<dict_product_status>("GetCustOrder @cust_id", param7).ToList();

            return View(cheque);
        }

        public ActionResult About()
        {
            return View();
        }
    }
}