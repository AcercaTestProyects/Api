using Acerca.Test.Api.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Acerca.Test.Api.Services.Interface
{
    public interface IGetVehicleService
    {
        /// <summary>
        /// This method returns all vehicles information.
        /// </summary>
        /// <returns></returns>
        Task<ActionResult<IEnumerable<Vehicle>>> GetVehicles();
    }
}