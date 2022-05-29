using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using petrol_pricer_server.Database;
using petrol_pricer_server.Models;

namespace petrol_pricer_server.Services
{
    public class StationService : IStationService
    {
        private readonly DatabaseContext _databaseContext;

        public StationService(DatabaseContext databaseContext)
        {
            this._databaseContext = databaseContext;
        }

        public Task<Station> GetByIdAsync(int stationId)
        {
            Task<Station> stationTask = this._databaseContext.Stations
                .Include(station => station.Coords)
                .Include(station => station.Prices)
                .SingleAsync(station => station.Id == stationId);

            return stationTask;
        }

        public Task<IEnumerable<Station>> GetAllAsync()
        {
            IEnumerable<Station> stations = this._databaseContext.Stations
                .Include(station => station.Coords)
                .Include(station => station.Prices);
           
            return Task.FromResult(stations);
        }

        public Task<EntityEntry<Station>> PostAsync(Station station)
        {
            ValueTask<EntityEntry<Station>> stationAdded = this._databaseContext.Stations.AddAsync(station);

            return stationAdded.AsTask();
        }

        public Task<EntityEntry<Station>> PutAsync(Station station)
        {
            EntityEntry<Station> stationUpdated = this._databaseContext.Stations.Update(station);

            return Task.FromResult(stationUpdated);
        }

        public Task<EntityEntry<Station>> DeleteAsync(Station stationToDelete)
        {
            return Task.FromResult(this._databaseContext.Stations.Remove(stationToDelete));
        }
    }
}
