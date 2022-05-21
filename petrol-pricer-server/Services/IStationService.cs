using Microsoft.EntityFrameworkCore.ChangeTracking;
using petrol_pricer_server.Dtos;
using petrol_pricer_server.Models;

namespace petrol_pricer_server.Services
{
    public interface IStationService : IBaseService<Station> { }
}
