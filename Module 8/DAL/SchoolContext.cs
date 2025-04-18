using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class SchoolContext : DbContext
    {
        private string _connectionString = "";
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Classroom> Classrooms { get; set; }

        public SchoolContext(string connectionstring)
        {
            this._connectionString = connectionstring;
        }

        public SchoolContext(DbContextOptions<SchoolContext> context) : base(context)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();

            if (!string.IsNullOrWhiteSpace(this._connectionString))
               optionsBuilder.UseSqlServer(this._connectionString);

            base.OnConfiguring(optionsBuilder);


        }
    }
}
