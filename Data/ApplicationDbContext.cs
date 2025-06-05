using BlogSystem.API.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogSystem.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<BlogPost> BlogPosts { get; set; }

        //FORMULARIOS REGISTRO SERVICIOS
        public DbSet<ExcedenteEnergiaNuevo> ExcedentesEnergiaNuevo { get; set; }
        public DbSet<ExcedenteEnergiaEnFuncionamiento> ExcedentesEnergiaEnFuncionamiento { get; set; }
        public DbSet<ProduccionHidrogeno> ProduccionesHidrogeno { get; set; }
        public DbSet<TransporteHidrogeno> TransportesHidrogeno { get; set; }
        public DbSet<VendeAlquilaHidrogeno> VentaAlquilerHidrogeno { get; set; }
        public DbSet<ContactoForm> ContactoForm { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configurar relaciones
            modelBuilder.Entity<BlogPost>()
                .HasOne(bp => bp.User)
                .WithMany(u => u.BlogPosts)
                .HasForeignKey(bp => bp.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // Índices únicos
            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();

            modelBuilder.Entity<User>()
                .HasIndex(u => u.Username)
                .IsUnique();

            //modelBuilder.Entity<RegistroUsuarioForm>(entity =>
            //{
            //    // Entity Framework convierte automáticamente enum a string
            //    entity.Property(e => e.TipoEntidad)
            //        .HasConversion<string>(); // Guarda como string en BD
            //});

            // Configuración para ExcedenteEnergiaNuevo
            modelBuilder.Entity<ExcedenteEnergiaNuevo>(entity =>
            {
                entity.Property(e => e.TipoEntidad).HasConversion<string>();
                entity.Property(e => e.TipoTecnologia).HasConversion<string>();
            });

            // Configuración para ExcedenteEnergiaEnFuncionamiento  
            modelBuilder.Entity<ExcedenteEnergiaEnFuncionamiento>(entity =>
            {
                entity.Property(e => e.TipoEntidad).HasConversion<string>();
                entity.Property(e => e.TipoTecnologia).HasConversion<string>();
            });

            // Configuración para ProduccionHidrogeno
            modelBuilder.Entity<ProduccionHidrogeno>(entity =>
            {
                entity.Property(e => e.TipoEntidad).HasConversion<string>();
                entity.Property(e => e.TipoTecnologia).HasConversion<string>();
                entity.Property(e => e.TipoSectorProduccion).HasConversion<string>();
                entity.Property(e => e.TipoTecnologiaAlquiler).HasConversion<string>();
            });

            // Configuración para VendeAlquilaHidrogeno
            modelBuilder.Entity<VendeAlquilaHidrogeno>(entity =>
            {
                entity.Property(e => e.TipoEntidad).HasConversion<string>();
                entity.Property(e => e.TipoTerreno).HasConversion<string>();
            });

            modelBuilder.Entity<TransporteHidrogeno>(entity =>
            {
                entity.Property(e => e.TipoEntidad).HasConversion<string>();
                entity.Property(e => e.TipoTransporte).HasConversion<string>();
            });
        }
    }
}