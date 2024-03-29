using Microsoft.EntityFrameworkCore;
using TurnsBackFront.Models;

namespace TurnsBackFront.Models
{
    public class TurnsContext : DbContext
    {
        public TurnsContext(DbContextOptions<TurnsContext> options)
        : base(options)
        {

        }

        public DbSet<Speciality> Speciality { get; set; }

        public DbSet<Patient> Patient { get; set; }

        public DbSet<Physician> Physician { get; set; }
        public DbSet<PhysicianSpeciality> PhysicianSpeciality {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Speciality>(entity =>
            {
                entity.ToTable("Speciality");

                entity.HasKey(e => e.SpecialityId);

                entity.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false);
            });

            modelBuilder.Entity<Patient>(entity =>
            {
                entity.ToTable("Patient");

                entity.HasKey("PatientId");

                entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

                entity.Property(e => e.Surname)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

                entity.Property(e => e.Address)
                .IsRequired()
                .HasMaxLength(250)
                .IsUnicode(false);

                entity.Property(e => e.Phone)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false);

                entity.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
            });

            modelBuilder.Entity<Physician>(entity =>
            {
                entity.ToTable("Physician");

                entity.HasKey("PhysicianId");

                entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

                entity.Property(e => e.Surname)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

                entity.Property(e => e.Address)
                .IsRequired()
                .HasMaxLength(250)
                .IsUnicode(false);

                entity.Property(e => e.Phone)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false);

                entity.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

                entity.Property(e => e.OpeningHoursFrom)
                .IsRequired()
                .IsUnicode(false);

                entity.Property(e => e.OpeningHoursTo)
                .IsRequired()
                .IsUnicode(false);
            });

            modelBuilder.Entity<PhysicianSpeciality>().HasKey(x => new { x.PhysicianId, x.SpecialityId});

            modelBuilder.Entity<PhysicianSpeciality>().HasOne(x => x.Physician)
                .WithMany(p => p.PhysicianSpeciality)
                .HasForeignKey(p => p.PhysicianId);

            modelBuilder.Entity<PhysicianSpeciality>().HasOne(x => x.Speciality)
                .WithMany(p => p.PhysicianSpeciality)
                .HasForeignKey(p => p.SpecialityId);
        }
    }
}