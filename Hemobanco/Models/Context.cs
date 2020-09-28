using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hemobanco.Models
{
    class Context : DbContext
    {
        public DbSet<Doador> Doadores {get; set;}
        public DbSet<Doacao> Doacoes { get; set; }
        public DbSet<Sangue> Sangues { get; set; }
        public DbSet<Estoque> Estoques { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Reserva> Reservas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;
                                        Database=HemoBanco;
                                        Trusted_Connection=true");
        }
    }
}
