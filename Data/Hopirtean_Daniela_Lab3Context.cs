using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Hopirtean_Daniela_Lab3.Models;

namespace Hopirtean_Daniela_Lab3.Data
{
    public class Hopirtean_Daniela_Lab3Context : DbContext
    {
        public Hopirtean_Daniela_Lab3Context (DbContextOptions<Hopirtean_Daniela_Lab3Context> options)
            : base(options)
        {
        }

        public DbSet<Hopirtean_Daniela_Lab3.Models.Book> Book { get; set; } = default!;

        public DbSet<Hopirtean_Daniela_Lab3.Models.Publisher> Publisher { get; set; }

        public DbSet<Hopirtean_Daniela_Lab3.Models.Category> Category { get; set; }
    }
}
