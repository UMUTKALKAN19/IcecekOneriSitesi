using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IcecekOneriSitesi.Models
{
    public class Context: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-7PB94FK; database=Db_IcecekOneriSitesi; integrated security=true");
        }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Icecek> Iceceklers { get; set; }
        public DbSet<Kategori> Kategorilers { get; set; }
        public DbSet<Mesajlar> Mesajlars { get; set; }
        public DbSet<Yorum> Yorumlars { get; set; }
    }
}
