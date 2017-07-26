using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.Data.Models.ORM.Entity
{
  public  class Product:BaseEntity
    {
        public string ProductName { get; set; }

        public decimal UnitPrice { get; set; }

        public short? UnitsInStock { get; set; }


        public int CategoryID { get; set; }

        [ForeignKey("CategoryID")]
        public virtual Category Category { get; set; }
    }
}
