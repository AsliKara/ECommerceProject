using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ECommerceProject.UI.Web.Areas.Admin.Models
{
    public class CategoryVM:BaseVM
    {
        [Required(ErrorMessage ="Please enter the category name")]

        [Display(Name ="Category Name")]
        public string Name { get; set; }

        [Display(Name ="Description")]
        public string Description { get; set; }
    }
}