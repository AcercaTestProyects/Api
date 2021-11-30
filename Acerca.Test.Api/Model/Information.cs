using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Acerca.Test.Api.Model
{
    public class Information
    {
        [JsonProperty("vehicles")]
        public IList<Vehicle> Vehicles { get; set; }
    }
}
