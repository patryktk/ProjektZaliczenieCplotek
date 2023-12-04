using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace Zaliczenie2.Data
{
    public class Zaliczenie2Context : DbContext
    {
        public Zaliczenie2Context (DbContextOptions<Zaliczenie2Context> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie.Models.Movie> Movie { get; set; } = default!;
    }
}
