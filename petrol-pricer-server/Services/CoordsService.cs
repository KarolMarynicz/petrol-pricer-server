using Microsoft.EntityFrameworkCore.ChangeTracking;
using petrol_pricer_server.Database;
using petrol_pricer_server.Models;

namespace petrol_pricer_server.Services
{
    public class CoordsService : ICoordsService
    {
        private readonly DatabaseContext _databaseContext;

        public CoordsService(DatabaseContext databaseContext)
        {
            this._databaseContext = databaseContext;
        }

        public Task<Coords> GetByIdAsync(int itemId)
        {
            ValueTask<Coords> coordsTask = this._databaseContext.Coords.FindAsync(itemId);
            return coordsTask.AsTask();
        }

        public Task<IEnumerable<Coords>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<EntityEntry<Coords>> PutAsync(Coords itemToUpdate)
        {
            throw new NotImplementedException();
        }

        public Task<EntityEntry<Coords>> PostAsync(Coords itemToCreate)
        {
            throw new NotImplementedException();
        }

        public Task<EntityEntry<Coords>> DeleteAsync(Coords itemToDelete)
        {
            throw new NotImplementedException();
        }
    }
}
