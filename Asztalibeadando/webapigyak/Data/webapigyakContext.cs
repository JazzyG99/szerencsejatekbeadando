using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ClassLibrary.Models;

namespace webapigyak.Data
{
    public class webapigyakContext : DbContext
    {
        public webapigyakContext (DbContextOptions<webapigyakContext> options)
            : base(options)
        {
        }

        public DbSet<ClassLibrary.Models.Huzas> Huzas { get; set; } = default!;
    }
}
