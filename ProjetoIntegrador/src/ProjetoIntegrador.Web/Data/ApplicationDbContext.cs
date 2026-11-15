// Supabase
using Microsoft.EntityFrameworkCore;
using ProjetoIntegrador.Web.Models.Entities;

namespace ProjetoIntegrador.Web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}