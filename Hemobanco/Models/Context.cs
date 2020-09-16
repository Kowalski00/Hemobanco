using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hemobanco.Models
{
    class Context : DbContext
    {
        public DbSet<Doador> Doadores {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;
                                        Database=HemoBancoDB;
                                        Trusted_Connection=true");
        }
    }
}
