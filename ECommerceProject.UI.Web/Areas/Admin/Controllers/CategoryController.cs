using ECommerceProject.Business;
using ECommerceProject.Data.Models.ORM.Entity;
using ECommerceProject.UI.Web.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECommerceProject.UI.Web.Areas.Admin.Controllers
{
    public class CategoryController : BaseController
    {
        GenericRepository<Category> rpcategory = new GenericRepository<Category>();
        
        public ActionResult Index()
        {
            rpcategory.List();
            List<CategoryVM> catlist = rpcategory.GetListWithQuery(x => x.IsDeleted == false).OrderBy(x => x.AddDate).Select(x => new CategoryVM()
            {
                Name = x.CategoryName,
                Description = x.Description,
                ID = x.ID

            }).ToList();
            return View(catlist);
            
        }
        public ActionResult DeleteCategory(int id)
        {
            
            Category cat = rpcategory.FirstOrDefault(x => x.ID == id);
            rpcategory.Delete(cat);

            return RedirectToAction("Index");

        }
       

        public ActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCategory(CategoryVM model)
        {
            if (ModelState.IsValid)
            {
                Category category = new Category();
                category.CategoryName = model.Name;
                category.Description = model.Description;

                rpcategory.Add(category);
               
                ViewBag.IslemDurum = 1;

                return View();


            }

            else
            {
                ViewBag.IslemDurum = 2;
                return View();
            }

            
        }

       
       public ActionResult UpdateCategory(int id)
        {
            Category category = db.Categories.FirstOrDefault(x => x.ID ==id);

            CategoryVM model = new CategoryVM();

            model.Name = category.CategoryName;
            model.Description = category.Description;
            return View(model);

        }



        [HttpPost]

        public ActionResult UpdateCategory(CategoryVM model)
        {

            if (ModelState.IsValid)
            {
                Category category = db.Categories.FirstOrDefault(x => x.ID == model.ID);
                category.CategoryName = model.Name;
                category.Description = model.Description;
                db.SaveChanges();

                ViewBag.IslemDurum = 1;

                return View();
            }
            else
            {
                ViewBag.IslemDurum = 2;
                return View();
            }
           

        }
    }

}