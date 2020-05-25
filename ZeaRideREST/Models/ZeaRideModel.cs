namespace ZeaRideREST.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ZeaRideModel : DbContext
    {
        public ZeaRideModel()
            : base("name=ZeaRideModel")
        {
        }

        public virtual DbSet<Bil> Bil { get; set; }
        public virtual DbSet<Bruger> Bruger { get; set; }
        public virtual DbSet<PersonligeOplysninger> PersonligeOplysninger { get; set; }
        public virtual DbSet<Postnummer> Postnummer { get; set; }
        public virtual DbSet<Samkorsel> Samkorsel { get; set; }
        public virtual DbSet<Deltagere> Deltagere { get; set; }
        public virtual DbSet<Samkorsler> Samkorsler { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bil>()
                .Property(e => e.bilmodel)
                .IsFixedLength();

            modelBuilder.Entity<Bil>()
                .Property(e => e.bilfarve)
                .IsFixedLength();

            modelBuilder.Entity<Bruger>()
                .Property(e => e.efternavn)
                .IsFixedLength();

            modelBuilder.Entity<Bruger>()
                .Property(e => e.FK_email)
                .IsFixedLength();

            modelBuilder.Entity<PersonligeOplysninger>()
                .Property(e => e.email)
                .IsFixedLength();

            modelBuilder.Entity<PersonligeOplysninger>()
                .Property(e => e.kodeord)
                .IsFixedLength();

            modelBuilder.Entity<Postnummer>()
                .Property(e => e.bynavn)
                .IsFixedLength();

            modelBuilder.Entity<Samkorsel>()
                .Property(e => e.fraDestination)
                .IsFixedLength();

            modelBuilder.Entity<Samkorsel>()
                .Property(e => e.tilDestination)
                .IsFixedLength();

            modelBuilder.Entity<Samkorsel>()
                .Property(e => e.bemaerkninger)
                .IsFixedLength();
        }
    }
}
