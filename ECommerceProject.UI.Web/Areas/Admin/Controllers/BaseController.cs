using ECommerceProject.Data.Models.ORM.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECommerceProject.UI.Web.Areas.Admin.Controllers
{
    public class BaseController : Controller
    {
        public ECommerceContext db;

        public BaseController()
        {
            db = new ECommerceContext();
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
        }
    }
}