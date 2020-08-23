using System;
using System.Collections.Generic;
using System.Text;
using BeerBar_Rajpal_7thAssnmnt.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BeerBar_Rajpal_7thAssnmnt.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Waiter> Waiters { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
