using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.Data.Models.ORM.Entity
{
  public  class User:BaseEntity
    {
        public string UserName { get; set; }

        public string UserSurname { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public int Phone { get; set; }

        public string City { get; set; }
    }
}
