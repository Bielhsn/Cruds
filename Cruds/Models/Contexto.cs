using Microsoft.EntityFrameworkCore;

namespace Cruds.Models
{
    public class Contexto: DbContext
    {
        public Contexto(DbContextOptions<Contexto> options): base(options) { 
        }

        public DbSet <Login> Login { get; set; }
        public DbSet <Register> Register { get; set; }
        public DbSet <Assessment> Assessment { get; set; }
    }
}
