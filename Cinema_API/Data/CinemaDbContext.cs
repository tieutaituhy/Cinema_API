using Cinema_API.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.OpenIddict.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.TenantManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;

namespace Cinema_API.Data
{
    public class CinemaDbContext : AbpDbContext<CinemaDbContext>
    {
        public DbSet<CinemaRoom> CinemaRooms { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<FilmForm> FilmForms { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieScreeningDetail> MovieScreeningDetails { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<TicketType> TicketTypes { get; set; }
        public DbSet<TypeOfFilm> TypeOfFilms { get; set; }
        public CinemaDbContext(DbContextOptions<CinemaDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            /* Include modules to your migration db context */

            builder.ConfigurePermissionManagement();
            builder.ConfigureSettingManagement();
            builder.ConfigureAuditLogging();
            builder.ConfigureIdentity();
            builder.ConfigureOpenIddict();
            builder.ConfigureFeatureManagement();
            builder.ConfigureTenantManagement();

            /* Configure your own entities here */
            if (builder.IsHostDatabase())
            {
                builder.Entity<MovieScreeningDetail>(b =>
                {
                    b.ToTable("ChiTietChieuPhim");
                    //b.HasKey(b => b.);
                });
                builder.Entity<CinemaRoom>(b =>
                {
                    b.ToTable("PhongChieuPhim");
                });
                builder.Entity<Customer>(b =>
                {
                    b.ToTable("KhachHang");
                });
                builder.Entity<Employee>(b =>
                {
                    b.ToTable("NhanVien");
                });
                builder.Entity<FilmForm>(b =>
                {
                    b.ToTable("DangPhim");
                });
                builder.Entity<Movie>(b =>
                {
                    b.ToTable("Phim");
                    //b.HasMany(b);
                    //b.HasKey(b => new { b.MoivieCode, b.TypeOfFilmCode, b.FilmFormCode });
                });
                builder.Entity<MovieScreeningDetail>(b =>
                {
                    b.ToTable("ChiTietPhieuPhim");
                    //b.HasKey(b => new { b.TicketCode, b.MovieCode, b.CinemaRoomCode });
                });
                builder.Entity<Ticket>(b =>
                {
                    b.ToTable("Ve");
                });
                builder.Entity<TicketType>(b =>
                {
                    b.ToTable("LoaiVe");
                });
                builder.Entity<TypeOfFilm>(b =>
                {
                    b.ToTable("TheLoaiPhim");
                });
            }

        }



    }
}
