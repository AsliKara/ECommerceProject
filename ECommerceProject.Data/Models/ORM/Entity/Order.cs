using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.Data.Models.ORM.Entity
{
  public  class Order:BaseEntity
    {
        public DateTime OrderDate { get; set; }

        public string ShipName { get; set; }

        public string ShipAddress { get; set; }

        public string ShipCountry { get; set; }


        public int UserID { get; set; }

        [ForeignKey("UserID")]
        public virtual User User { get; set; }
    }
}
