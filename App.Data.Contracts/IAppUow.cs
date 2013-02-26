using App.Model;

namespace App.Data.Contracts
{
    /// <summary>
    /// Interface for the Site "Unit of Work"
    /// </summary>
    public interface IAppUow
    {
        // Save pending changes to the data store.
        void Commit();

        // Repositories
        ISampleModelRepository SampleModel { get; }
        //IPersonsRepository Persons { get; }
        //IRepository<Room> Rooms { get; }        
        //IRepository<TimeSlot> TimeSlots { get; }
        //IRepository<Track> Tracks { get; }
        //IAttendanceRepository Attendance { get; }
    }
}