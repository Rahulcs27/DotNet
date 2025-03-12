using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo_codeFirstApproach.Model;
using Microsoft.EntityFrameworkCore;

namespace Demo_codeFirstApproach
{
    public class WareHouseDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-V2H7PT7;Database=CodeFirstDB;Trusted_Connection=True;");
        }
    }

}
