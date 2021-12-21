using Microsoft.EntityFrameworkCore;

namespace AgenciaCrud2.Models
{
    public class BancoDdados : DbContext
    {
        public DbSet<Destino> Destino { get; set; }
        public DbSet<Promocao> Promocao { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(connectionString: @"Server=LAPTOP-MBUICO5C\SQLEXPRESS;Database=AgenciaCrud2;Integrated Security=True");



        }

    }
}