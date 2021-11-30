using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Acerca.Test.Api.Model
{
    public class Vehicle
    {
        [JsonProperty("numeroPedido")]
        public int NumeroPedido { get; set; }
        [JsonProperty("bastidor")]
        public string Bastidor { get; set; }
        [JsonProperty("modelo")]
        public string Modelo { get; set; }
        [JsonProperty("matricula")]
        public string Matricula { get; set; }
        [JsonProperty("fechaEntrega")]
        public string FechaEntrega { get; set; }
    }
}
