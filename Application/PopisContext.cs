using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Application
{
    public class PopisContext: DbContext
    {
        public DbSet<Grad> Grad { get; set; }
        public DbSet<Opstina> Opstina { get; set; }
        public DbSet<Zhitel> Zhiteli { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=Popis2020;Integrated Security=True");
        }
    }   

}
