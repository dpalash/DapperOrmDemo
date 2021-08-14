namespace EFOrmDemo.DBEntities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class GymDbContext : DbContext
    {
        public GymDbContext()
            : base("name=GymDbContext")
        {
        }

        public virtual DbSet<Story> Stories { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
