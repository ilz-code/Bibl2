using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Biblio.Models;
using Microsoft.EntityFrameworkCore;

namespace Biblio.Data
{
    public class Bibl2DbContext : DbContext
    {
        public Bibl2DbContext(DbContextOptions<Bibl2DbContext> options) : base(options)
        {
        }

        public DbSet<Gramata> Gramatas { get; set; }
        public DbSet<Autors> Autors { get; set; }
    }
}
