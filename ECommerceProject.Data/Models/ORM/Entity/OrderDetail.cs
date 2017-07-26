using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.Data.Models.ORM.Entity
{
  public  class OrderDetail:BaseEntity
    {

        public int ProductID { get; set; }

        public decimal UnitPrice { get; set; }

        public int Quantity { get; set; }

        [ForeignKey("ProductID")]
        public virtual Product Product { get; set; }
    }
}
