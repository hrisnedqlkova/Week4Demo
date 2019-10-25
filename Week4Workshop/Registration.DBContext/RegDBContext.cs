using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using registration.Models;

namespace Registration.DBContext
{
    public class RegDBContext : DbContext
    {
        public  DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=RegistratonDB;Trusted_Connection=True;");
        }

          
    }
}
