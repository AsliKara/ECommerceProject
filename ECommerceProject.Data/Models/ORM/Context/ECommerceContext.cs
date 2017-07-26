using ECommerceProject.Data.Models.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.Data.Models.ORM.Context
{
   public class ECommerceContext:DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }


        public ECommerceContext()
        {
            Database.Connection.ConnectionString = "Server=USER\\SQLEXPRESS;Database=E-CommerceProject;trusted_connection=true";
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<AdminUser> AdminUsers { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }

        public DbSet<User> Users { get; set; }

    }
}
