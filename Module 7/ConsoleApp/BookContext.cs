using Microsoft.EntityFrameworkCore;

namespace ConsoleApp
{
    public class BookContext : DbContext
    {
        public DbSet<Auteur> Authors { get; set; }
        public DbSet<Livre> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\repos\\perso\\Supinfo-2025-3ASP-private\\Module 7\\ConsoleApp\\Database1.mdf\";Integrated Security=True");

            base.OnConfiguring(optionsBuilder);
        }
    }
}
