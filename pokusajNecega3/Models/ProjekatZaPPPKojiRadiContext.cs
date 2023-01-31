using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace pokusajNecega3.Models
{
    public partial class ProjekatZaPPPKojiRadiContext : DbContext
    {
        public ProjekatZaPPPKojiRadiContext()
        {
        }

        public ProjekatZaPPPKojiRadiContext(DbContextOptions<ProjekatZaPPPKojiRadiContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Dokumentacija> Dokumentacija { get; set; }
        public virtual DbSet<Korisnici> Korisnici { get; set; }
        public virtual DbSet<Racun> Racun { get; set; }
        public virtual DbSet<Vozilo> Vozilo { get; set; }
        public virtual DbSet<VozniPark> VozniPark { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-FID9UGE\\MSSQLSERVER01;Database=ProjekatZaPPPKojiRadi;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dokumentacija>(entity =>
            {
                entity.HasKey(e => e.Idvozacke);

                entity.Property(e => e.Idvozacke)
                    .HasColumnName("IDVozacke")
                    .ValueGeneratedNever();

                entity.Property(e => e.DatumIzdavanjaDozvole).HasColumnType("date");

                entity.Property(e => e.DatumRodjenja).HasColumnType("date");

                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Prezime)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Korisnici>(entity =>
            {
                entity.HasKey(e => e.KorisnickoIme);

                entity.Property(e => e.KorisnickoIme)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.Sifra)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Uloga)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Racun>(entity =>
            {
                entity.Property(e => e.RacunId)
                    .HasColumnName("Racun_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cena).HasColumnType("money");

                entity.Property(e => e.Datum).HasColumnType("date");

                entity.Property(e => e.DokumentacijaFk).HasColumnName("Dokumentacija_FK");

                entity.Property(e => e.VoziloFk)
                    .IsRequired()
                    .HasColumnName("Vozilo_FK")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.DokumentacijaFkNavigation)
                    .WithMany(p => p.Racun)
                    .HasForeignKey(d => d.DokumentacijaFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Racun_Dokumentacija");

                entity.HasOne(d => d.VoziloFkNavigation)
                    .WithMany(p => p.Racun)
                    .HasForeignKey(d => d.VoziloFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Racun_Vozilo");
            });

            modelBuilder.Entity<Vozilo>(entity =>
            {
                entity.HasKey(e => e.RegistracioniBroj);

                entity.Property(e => e.RegistracioniBroj)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Boja)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tip)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VozniParkFk).HasColumnName("VozniPark_FK");

                entity.HasOne(d => d.VozniParkFkNavigation)
                    .WithMany(p => p.Vozilo)
                    .HasForeignKey(d => d.VozniParkFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Vozilo_VozniPark");
            });

            modelBuilder.Entity<VozniPark>(entity =>
            {
                entity.Property(e => e.VozniParkId)
                    .HasColumnName("VozniPark_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
