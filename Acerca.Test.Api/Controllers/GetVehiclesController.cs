using Acerca.Test.Api.Model;
using Acerca.Test.Api.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Acerca.Test.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetVehiclesController : ControllerBase
    {
        private readonly ILogger<GetVehiclesController> _logger;
        private readonly IGetVehicleService _getVehicleService;

        public GetVehiclesController(ILogger<GetVehiclesController> logger, IGetVehicleService getVehicleService)
        {
            _logger = logger;
            _getVehicleService = getVehicleService;
        }

        [HttpGet("/api/getVehicles/readVehicles")]
        [Produces("application/json")]
        public async Task<ActionResult<IEnumerable<Vehicle>>> ReadVehicles()
        {
            var response = await _getVehicleService.GetVehicles();
            return Ok(response);
        }
    }
}
