using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace SiriusApi.Models
{
    public partial class DBAntigicuContext : DbContext
    {
        public DBAntigicuContext()
        {
        }

        public DBAntigicuContext(DbContextOptions<DBAntigicuContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TbDevice> TbDevices { get; set; }
        public virtual DbSet<TbMeasure> TbMeasures { get; set; }
        public virtual DbSet<TbPlant> TbPlants { get; set; }
        public virtual DbSet<TbVendor> TbVendors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=DBAntigicu;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<TbDevice>(entity =>
            {
                entity.HasKey(e => e.IdDevice);

                entity.ToTable("tbDevices");

                entity.Property(e => e.IdDevice)
                    .ValueGeneratedNever()
                    .HasColumnName("idDevice");

                entity.Property(e => e.IdPlant).HasColumnName("idPlant");

                entity.Property(e => e.NmAltitude).HasColumnName("nmAltitude");

                entity.Property(e => e.NmLatitude)
                    .HasMaxLength(50)
                    .HasColumnName("nmLatitude");

                entity.Property(e => e.NmLongitude)
                    .HasMaxLength(50)
                    .HasColumnName("nmLongitude");

                entity.Property(e => e.NmSerial).HasColumnName("nmSerial");

                entity.Property(e => e.NmYear).HasColumnName("nmYear");

                entity.Property(e => e.TxModel)
                    .HasMaxLength(50)
                    .HasColumnName("txModel");

                entity.Property(e => e.TxName)
                    .HasMaxLength(50)
                    .HasColumnName("txName");

                entity.Property(e => e.TxNote)
                    .HasMaxLength(50)
                    .HasColumnName("txNote");

                entity.Property(e => e.TxTypeSection)
                    .HasMaxLength(50)
                    .HasColumnName("txTypeSection");

                entity.HasOne(d => d.IdPlantNavigation)
                    .WithMany(p => p.TbDevices)
                    .HasForeignKey(d => d.IdPlant)
                    .HasConstraintName("FK_idPlant");
            });

            modelBuilder.Entity<TbMeasure>(entity =>
            {
                entity.HasKey(e => e.IdMeasure);

                entity.ToTable("tbMeasure");

                entity.Property(e => e.IdMeasure)
                    .ValueGeneratedNever()
                    .HasColumnName("idMeasure");

                entity.Property(e => e.DtDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("dtDate");

                entity.Property(e => e.IdDevice).HasColumnName("idDevice");

                entity.Property(e => e.IdPlant).HasColumnName("idPlant");

                entity.Property(e => e.NmActivePower).HasColumnName("nmActivePower");

                entity.Property(e => e.NmAmbientTemp).HasColumnName("nmAmbientTemp");

                entity.Property(e => e.NmControllerHubTemp).HasColumnName("nmControllerHubTemp");

                entity.Property(e => e.NmControllerTopTemp).HasColumnName("nmControllerTopTemp");

                entity.Property(e => e.NmFrequency).HasColumnName("nmFrequency");

                entity.Property(e => e.NmGeneratorSpeed).HasColumnName("nmGeneratorSpeed");

                entity.Property(e => e.NmNacelleDir).HasColumnName("nmNacelleDir");

                entity.Property(e => e.NmNacelleTemp).HasColumnName("nmNacelleTemp");

                entity.Property(e => e.NmPressure).HasColumnName("nmPressure");

                entity.Property(e => e.NmProduciblePower).HasColumnName("nmProduciblePower");

                entity.Property(e => e.NmProduciblePowerVestas).HasColumnName("nmProduciblePowerVestas");

                entity.Property(e => e.NmRotorSpeed).HasColumnName("nmRotorSpeed");

                entity.Property(e => e.NmWindSpeed).HasColumnName("nmWindSpeed");

                entity.HasOne(d => d.IdPlantNavigation)
                    .WithMany(p => p.TbMeasures)
                    .HasForeignKey(d => d.IdPlant)
                    .HasConstraintName("FK_idDevice");
            });

            modelBuilder.Entity<TbPlant>(entity =>
            {
                entity.HasKey(e => e.IdPlants);

                entity.ToTable("tbPlants");

                entity.Property(e => e.IdPlants)
                    .ValueGeneratedNever()
                    .HasColumnName("idPlants");

                entity.Property(e => e.IdVenditori).HasColumnName("idVenditori");

                entity.Property(e => e.TxEcName)
                    .HasMaxLength(50)
                    .HasColumnName("txEcName");

                entity.Property(e => e.TxPlants)
                    .HasMaxLength(50)
                    .HasColumnName("txPlants");

                entity.Property(e => e.TxSse)
                    .HasMaxLength(50)
                    .HasColumnName("txSse");

                entity.Property(e => e.TxSubSystem)
                    .HasMaxLength(50)
                    .HasColumnName("txSubSystem");

                entity.Property(e => e.TxUp)
                    .HasMaxLength(50)
                    .HasColumnName("txUp");

                entity.HasOne(d => d.IdVenditoriNavigation)
                    .WithMany(p => p.TbPlants)
                    .HasForeignKey(d => d.IdVenditori)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_idVenditori");
            });

            modelBuilder.Entity<TbVendor>(entity =>
            {
                entity.HasKey(e => e.IdVenditori);

                entity.ToTable("tbVendors");

                entity.Property(e => e.IdVenditori)
                    .ValueGeneratedNever()
                    .HasColumnName("idVenditori");

                entity.Property(e => e.TxDownTimeClass)
                    .HasMaxLength(50)
                    .HasColumnName("txDownTimeClass");

                entity.Property(e => e.TxVendors)
                    .HasMaxLength(50)
                    .HasColumnName("txVendors");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
