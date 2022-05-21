using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using petrol_pricer_server.Models;
using petrol_pricer_server.Services;

namespace petrol_pricer_server.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class StationsController : ControllerBase
    {
        private readonly IStationService _stationService;
        private readonly ILogger _logger;

        public StationsController(ILogger<StationsController> logger, IStationService stationService)
        {
            this._logger = logger;
            this._stationService = stationService;
        }

        [HttpGet]
        [ActionName("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            this._logger.LogInformation("HTTP GET: GetAll method of StationsController invoked.");

            IEnumerable<Station> stations = await this._stationService.GetAllAsync();

            if (stations == null)
            {
                return BadRequest();
            }

            return Ok(stations);
        }

        [HttpGet]
        [ActionName("Get")]
        public async Task<IActionResult> Get([FromHeader(Name="Id")] int id)
        {
            this._logger.LogInformation("HTTP GET('Id'): Get method of StationsController invoked.");

            Station? station = await this._stationService.GetByIdAsync(id);

            if (station == null)
            {
                return NotFound();
            }

            return Ok(station);
        }

        [HttpPost]
        [ActionName("Post")]
        public async Task<IActionResult> Create([FromBody] Station station)
        {
            this._logger.LogInformation("HTTP POST: Create method of StationsController invoked.");

            EntityEntry<Station> stationCreated = await this._stationService.PostAsync(station);

            if (stationCreated == null)
            {
                return BadRequest();
            }

            return Ok(stationCreated);
        }

        [HttpPut]
        [ActionName("Put")]
        public async Task<IActionResult> Update(Station station)
        {
            this._logger.LogInformation("HTTP PUT: Update method of StationsController invoked.");

            EntityEntry<Station> stationUpdated = await this._stationService.PutAsync(station);

            if (stationUpdated == null)
            {
                return BadRequest();
            }

            return Ok(stationUpdated);
        }

        [HttpDelete]
        [ActionName("Delete")]
        public async Task<IActionResult> Delete(int stationId)
        {
            this._logger.LogInformation("HTTP DELETE: Delete method of StationsController invoked.");

            Station? stationToDelete = await this._stationService.GetByIdAsync(stationId);

            if (stationToDelete == null)
            {
                return NotFound();
            }

            EntityEntry<Station> deletedEntry = await this._stationService.DeleteAsync(stationToDelete);

            return Ok(deletedEntry);
        }
    }
}
