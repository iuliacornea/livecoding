using CRUD_demo_3.Model;
using Microsoft.EntityFrameworkCore;

namespace CRUD_demo_3.Data;


public class DataContext : DbContext
{
    public DbSet<Course> Courses { get; set; }
    public DbSet<Teacher> Teachers { get; set; }

    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Teacher>()
            .HasMany<Course>(t => t.Courses)
            .WithOne(c => c.Coordinator)
            .HasForeignKey(c => c.CoordinatorId);
    }
}
