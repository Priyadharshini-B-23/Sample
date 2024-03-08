using System.Collections.Generic;
using System;
using Sample.Models;
using Microsoft.EntityFrameworkCore;

namespace Sample.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<LoginModel> SignUp { get; set; }
       
    }
}
