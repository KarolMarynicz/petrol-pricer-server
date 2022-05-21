using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace petrol_pricer_server.Services
{
    public interface IBaseService<T> where T : class
    {
        public Task<T> GetByIdAsync(int itemId);
        public Task<IEnumerable<T>> GetAllAsync();
        public Task<EntityEntry<T>> PostAsync(T itemToCreate);
        public Task<EntityEntry<T>> PutAsync(T itemToUpdate);
        public Task<EntityEntry<T>> DeleteAsync(T itemToDelete);
    }
}
