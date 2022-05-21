using Microsoft.EntityFrameworkCore.ChangeTracking;
using petrol_pricer_server.Database;
using petrol_pricer_server.Models;

namespace petrol_pricer_server.Services
{
    public class PricesService : IPricesService
    {
        private readonly DatabaseContext _databaseContext;

        public PricesService(DatabaseContext databaseContext)
        {
            this._databaseContext = databaseContext;
        }

        public Task<Prices> GetByIdAsync(int itemId)
        {
            ValueTask<Prices> pricesTask = this._databaseContext.Prices.FindAsync(itemId);
            return pricesTask.AsTask();
        }

        public Task<IEnumerable<Prices>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<EntityEntry<Prices>> PutAsync(Prices itemToUpdate)
        {
            throw new NotImplementedException();
        }

        public Task<EntityEntry<Prices>> PostAsync(Prices itemToCreate)
        {
            throw new NotImplementedException();
        }

        public Task<EntityEntry<Prices>> DeleteAsync(Prices itemToDelete)
        {
            throw new NotImplementedException();
        }
    }
}
