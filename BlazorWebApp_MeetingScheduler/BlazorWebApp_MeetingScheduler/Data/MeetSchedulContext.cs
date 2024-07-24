using BlazorWebApp_MeetingScheduler.Models;

namespace BlazorWebApp_MeetingScheduler.Data
{
    // declaires context class derived from DbContext
    public class MeetSchedulContext : DbContext
    {
        // declares properties for DBSet of each model
        public DbSet<Department> Department { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Meeting> Meetings { get; set; }

        // creates constructor for context class that includes configuration options
        public MeetSchedulContext(DbContextOptions<MeetSchedulContext> options) : base(options)
        {
        }

        // overrides the OnModelCreating method for DbContext class
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
