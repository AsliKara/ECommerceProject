using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ECommerceProject.Data.Models.ORM.Entity
{
 
    public class AdminUser : BaseEntity
    {
        [Required]
        public string Email { get; set; }


        public string Name { get; set; }

        public string Surname { get; set; }

        [Required]
        public string Password { get; set; }


    }
}
