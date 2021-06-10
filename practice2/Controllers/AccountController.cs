using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using practice2.DAL;
using practice2.Models;
using System.Data.Entity.Validation;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace practice2.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        public static int role;
        public static int id;
        cswEntities db = new cswEntities();
        //
        // GET: /Account/Login
        [HttpGet]
        [AllowAnonymous]
        public ActionResult Login()
        {
            id = 0;
            role = 0;
            return View();
        }

        //
        // POST: /Account/Login
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                // поиск пользователя в бд
                customer cust = null;
                store store = null;
                using (UserContext db = new UserContext())
                {
                    cust = db.Cust.FirstOrDefault(u => u.cust_phone == model.Phone && u.cust_password == model.Password);
                    store = db.Store.FirstOrDefault(u => u.store_code == model.Phone && u.store_password == model.Password);
                }
                if (cust != null)
                {
                    role = 1;
                    id = cust.cust_id;

                    FormsAuthentication.SetAuthCookie(model.Phone, true);
                    return RedirectToAction("Index", "Home");
                }
                else if (store != null)
                {
                    role = 2;
                    id = store.store_id;
                    ViewBag.Name = store.store_name;
                    FormsAuthentication.SetAuthCookie(model.Phone, true);
                    return RedirectToAction("Index", "Product");
                }
                else
                {
                    ModelState.AddModelError("", "Пользователя с таким логином и паролем нет");
                }
            }

            return View();
        }

        //
        // GET: /Account/Register
        [HttpGet]
        [AllowAnonymous]
        public ActionResult Register()
        {
            RegisterModelCust cust = new RegisterModelCust();
            return View(cust);
        }

        //
        // POST: /Account/Register
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Register(RegisterModelCust model)
        {
            if (ModelState.IsValid)
            {
                customer cust = null;
                using (UserContext db = new UserContext())
                {
                    cust = db.Cust.FirstOrDefault(u => u.cust_phone == model.Phone);
                }
                if (cust == null)
                {
                    // создаем нового пользователя
                    using (UserContext db = new UserContext())
                    {
                        db.Cust.Add(new customer { cust_name = model.FIO, cust_phone = model.Phone, cust_password = model.Password, cust_birth = model.BDay, cust_role = "Покупатель" });
                        db.SaveChanges();

                        cust = db.Cust.Where(u => u.cust_phone == model.Phone && u.cust_password == model.Password).FirstOrDefault();
                    }
                    // если пользователь удачно добавлен в бд
                    if (cust != null)
                    {
                        FormsAuthentication.SetAuthCookie(model.Phone, true);
                        return RedirectToAction("Login", "Account");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Пользователь с таким логином уже существует");
                }
            }
            return View(model);
        }

        //
        // GET: /Account/RegisterStore
        [HttpGet]
        [AllowAnonymous]
        public ActionResult RegisterStore()
        {
            ViewBag.city_id = new SelectList(db.dict_city, "city_id", "city_name");
            return View();
        }

        //
        // POST: /Account/RegisterStore
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult RegisterStore([Bind(Include = "store_id,store_name,store_code,store_info,store_password,store_role,store_logo,store_address,city_id")] store store, HttpPostedFileBase Logo)
        {
            if (ModelState.IsValid)
            {
                store stor = null;
                stor = db.store.FirstOrDefault(u => u.store_code == store.store_code);

                if (stor == null)
                {
                    try
                    {
                        byte[] imageData = null;

                        using (var binaryReader = new BinaryReader(Logo.InputStream))
                        {
                            imageData = binaryReader.ReadBytes(Logo.ContentLength);
                        }
                        store.store_logo = imageData;
                    }
                    catch
                    {
                        ModelState.AddModelError("", "Требуется добавление логотипа магазина");
                    }

                    db.store.Add(new store { store_name = store.store_name, store_code = store.store_code, store_password = store.store_password, store_info = store.store_info, store_role = "Покупатель", store_logo = store.store_logo, store_address = store.store_address, city_id = store.city_id });
                    db.SaveChanges();

                    store = db.store.Where(u => u.store_code == store.store_code && u.store_password == store.store_password).FirstOrDefault();

                    // если пользователь удачно добавлен в бд
                    if (store != null)
                    {
                        FormsAuthentication.SetAuthCookie(store.store_code, true);
                        return RedirectToAction("Login", "Account");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Пользователь с таким логином уже существует");
                }
            }
            else
            {
                ModelState.AddModelError("", "Не все поля заполнены верно");
            }
            ViewBag.city_id = new SelectList(db.dict_city, "city_id", "city_name");
            return View(store);
        }

        //
        // POST: /Account/LogOff
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogOff()
        {
            role = 0;
            id = 0;
            AuthenticationManager.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
            return RedirectToAction("Login", "Account");
        }

        #region Вспомогательные приложения
        // Используется для защиты от XSRF-атак при добавлении внешних имен входа
        private const string XsrfKey = "XsrfId";

        private IAuthenticationManager AuthenticationManager
        {
            get
            {
                return HttpContext.GetOwinContext().Authentication;
            }
        }

        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error);
            }
        }

        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            return RedirectToAction("Index", "Home");
        }

        internal class ChallengeResult : HttpUnauthorizedResult
        {
            public ChallengeResult(string provider, string redirectUri)
                : this(provider, redirectUri, null)
            {
            }

            public ChallengeResult(string provider, string redirectUri, string userId)
            {
                LoginProvider = provider;
                RedirectUri = redirectUri;
                UserId = userId;
            }

            public string LoginProvider { get; set; }
            public string RedirectUri { get; set; }
            public string UserId { get; set; }

            public override void ExecuteResult(ControllerContext context)
            {
                var properties = new AuthenticationProperties { RedirectUri = RedirectUri };
                if (UserId != null)
                {
                    properties.Dictionary[XsrfKey] = UserId;
                }
                context.HttpContext.GetOwinContext().Authentication.Challenge(properties, LoginProvider);
            }
        }
        #endregion
    }
}