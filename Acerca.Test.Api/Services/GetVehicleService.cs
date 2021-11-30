using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Acerca.Test.Api.Helper;
using Acerca.Test.Api.Model;
using Acerca.Test.Api.Services.Interface;

namespace Acerca.Test.Api.Services
{
    public class GetVehicleService : IGetVehicleService
    {
        private readonly IConfiguration _configuration;

        public GetVehicleService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<ActionResult<IEnumerable<Vehicle>>> GetVehicles()
        {
            var models = new List<Vehicle>();

            try
            {
                //Get json data
                var data = JsonRender.GetJsonData(_configuration["UrlFile"]);
                if (!string.IsNullOrEmpty(data))
                {
                    var information = JsonConvert.DeserializeObject<Information>(data);
                    if (information != null)
                    {
                        models = information.Vehicles.ToList();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
   
            await Task.CompletedTask;

            return models;
        }
    }
}