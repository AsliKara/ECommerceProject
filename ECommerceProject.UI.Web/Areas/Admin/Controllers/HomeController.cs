using ECommerceProject.UI.Web.Areas.Admin.Models.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECommerceProject.UI.Web.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
     
        
        public ActionResult Index()
        {
            return View();
        }
    }
}