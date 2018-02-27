namespace Assignment.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=DefaultConnections")
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Vehicle> Vehicles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .Property(e => e.planes)
                .IsFixedLength();

            modelBuilder.Entity<Category>()
                .Property(e => e.cranes)
                .IsFixedLength();

            modelBuilder.Entity<Vehicle>()
                .Property(e => e.bike)
                .IsFixedLength();

            modelBuilder.Entity<Vehicle>()
                .Property(e => e.cars)
                .IsFixedLength();

            modelBuilder.Entity<Vehicle>()
                .Property(e => e.trains)
                .IsFixedLength();
        }
    }
}
