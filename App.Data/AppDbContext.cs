using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using App.Model;
using App.Data.SampleData;

namespace App.Data
{
    public class AppDbContext : DbContext 
    {
        // ToDo: Move Initializer to Global.asax; don't want dependence on SampleData
        static AppDbContext()
        {
            Database.SetInitializer(new AppDatabaseInitializer());
        }

        public AppDbContext()
            : base(nameOrConnectionString: "App") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Use singular table names
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //add for each model:
            modelBuilder.Configurations.Add(new SampleModelConfiguration());
        }

        public DbSet<SampleModel> SampleModels { get; set; }
        //public DbSet<Person> Persons { get; set; }
        //public DbSet<Attendance> Attendance { get; set; }

        //// Lookup Lists
        //public DbSet<Room> Rooms { get; set; }
        //public DbSet<TimeSlot> TimeSlots { get; set; }
        //public DbSet<Track> Tracks { get; set; }
    }
}
