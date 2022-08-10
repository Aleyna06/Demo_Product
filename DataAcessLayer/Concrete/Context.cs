﻿using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer.Concrete
{
   public  class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-107QR8B;database=DbDemoOopCore;" +
                "integrated security=true ");
        }
        public DbSet<Product> Products { get; set; } //c# ve sql tablosunda kullanacağım isimlendirme
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categories { get; set; }
    
}
}
