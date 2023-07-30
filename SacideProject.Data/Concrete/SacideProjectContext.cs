using Microsoft.EntityFrameworkCore;
using SacideProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SacideProject.Data.Concrete
{
    public class SacideProjectContext : DbContext
    {
        public DbSet<Danisman> Danismanlar { get; set; }
        public DbSet<Terapi> Terapiler { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = ESRA\\SQLEXPRESS; Database = SacideDB; Trusted_Connection = True; TrustServerCertificate=True");
        }
    }
}
