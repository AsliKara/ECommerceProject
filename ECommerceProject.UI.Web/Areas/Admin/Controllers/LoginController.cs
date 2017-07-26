using ECommerceProject.Data.Models.ORM.Context;
using ECommerceProject.UI.Web.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ECommerceProject.UI.Web.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        private ECommerceContext db = new ECommerceContext();

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                if (db.AdminUsers.Any(x => x.Email == model.Email && x.Password == model.Password))
                {
                    FormsAuthentication.SetAuthCookie(model.Email, true);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return View();
                }
            }
            else
            {

                return View();
            }
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index");
        }
    }
}