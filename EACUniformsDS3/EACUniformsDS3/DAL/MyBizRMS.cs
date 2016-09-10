using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;
using EACUniformsDS3.Models;


namespace EACUniformsDS3.DAL
{
    public class MyBizRMSDBContext : DbContext
    {
        public DbSet<Item> Item { get; set; }
        public DbSet<School> School { get; set; }

        public DbSet<Size> Size { get; set; }

        public DbSet<Supplier> Supplier { get; set; }

        public DbSet<Order> Order { get; set; }

        public DbSet<OrdItem> OrdItem { get; set; }
    }
}