using LearningCenter.Infraestructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace LearningCenter.Infraestructure.Context;

public class LeadYourWayDBContext : DbContext {
    public LeadYourWayDBContext() {
    }

    public LeadYourWayDBContext(DbContextOptions<LeadYourWayDBContext> options) : base(options) {
        Database.EnsureCreated();
    }

    public DbSet<Bicycle> Bicycles { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        if (!optionsBuilder.IsConfigured) {
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 29));
            optionsBuilder.UseMySql("Server=localhost,3306;Uid=root;Pwd=1234;Database=LeadYourWayDB;", serverVersion);
        }
    }

    protected override void OnModelCreating(ModelBuilder builder) {

        base.OnModelCreating(builder);

        builder.Entity<User>().ToTable("User");
        builder.Entity<User>().HasKey(p => p.Id);
        builder.Entity<User>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
        builder.Entity<User>().Property(c => c.FirstName).IsRequired().HasMaxLength(60);
        builder.Entity<User>().Property(c => c.LastName).IsRequired();
        
        
        builder.Entity<Bicycle>().ToTable("Bicycle");
        builder.Entity<Bicycle>().HasKey(p => p.Id);
        builder.Entity<Bicycle>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
        builder.Entity<Bicycle>().Property(c => c.Name).IsRequired().HasMaxLength(60);
        builder.Entity<Bicycle>().Property(c => c.IsActive).IsRequired();

    }
}