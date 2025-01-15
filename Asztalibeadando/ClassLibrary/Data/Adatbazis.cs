using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ClassLibrary.Data
{
    public class Adatbazis:DbContext
    {
        public Adatbazis(DbContextOptions<Adatbazis> options)
           : base(options)
        {
        }

        public Adatbazis()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=webapigyakContext-152b09fa-7e31-4dc2-9268-661db3e141b9;Trusted_Connection=True;MultipleActiveResultSets=true");
            
        }

        public DbSet<ClassLibrary.Models.Huzas> Huzas { get; set; } = default!;

    }
}
