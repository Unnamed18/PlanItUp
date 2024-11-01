using Microsoft.EntityFrameworkCore;
using PlanItUp.Models.ViewModels;

namespace PlanItUp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> op)
            : base(op) { }

        public DbSet<Usuario> Usuarios { get; set; } = null!;
        public DbSet<Direccion> Direcciones { get; set; } = null!;
        public DbSet<Evento> Eventos { get; set; } = null!; 
        public DbSet<Pago> Pagos { get; set; } = null!; 
        public DbSet<Rol> Roles { get; set; } = null!;   
        public DbSet<TipoEvento> TipoEventos { get; set; } = null!;
        public DbSet<TipoPago> TipoPagos { get; set; } = null!;  
        public DbSet<UsuarioDireccion> UsuarioDirecciones { get; set; } = null!;
    }
}