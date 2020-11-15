using Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class CustomerDbContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
            optionsBuilder.UseSqlServer("Server=DESKTOP-0TAH8RF;Database=BasicCrm;uid=admin;pwd=123456");
           
            base.OnConfiguring(optionsBuilder);
        }


        public DbSet<Customers> Customers { get; set; }
        public DbSet<Users> Users{ get; set; }
        }
   
}

