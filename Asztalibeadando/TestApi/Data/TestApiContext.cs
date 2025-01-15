using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ClassLibrary.Models;

namespace TestApi.Data
{
    public class TestApiContext : DbContext
    {
        public TestApiContext (DbContextOptions<TestApiContext> options)
            : base(options)
        {
        }

        public DbSet<ClassLibrary.Models.Huzas> Huzas { get; set; } = default!;
    }
}
