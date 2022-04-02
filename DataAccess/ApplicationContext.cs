using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public partial class ApplicationContext : DbContext
    {

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        public DbSet<PersonGroup> PersonGroups { get; set; }
        public DbSet<Person> Persons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
                .HasOne(p => p.PersonGroup)
                .WithMany(pg => pg.Person)
                .HasForeignKey(p => p.GroupId)
                .HasPrincipalKey(pg => pg.Id);

            modelBuilder.Entity<Person>()
        .HasKey(p => p.Id)
        .HasName("PrimaryKey_PersonId");

            modelBuilder.Entity<PersonGroup>()
        .HasKey(pg => pg.Id)
        .HasName("PrimaryKey_PersonGroupId");
        }
    }
}
