using Newtonsoft.Json;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCovid.Data
{
    public interface IKawalCorona
    {
        [Get("/indonesia/")]
        Task<List<KawalCoronaIndonesiaVm>> GetKawalCoronaIndonesia();
    }

    public class KawalCoronaIndonesiaVm
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("positif")]
        public string Positif { get; set; }

        [JsonProperty("sembuh")]
        public string Sembuh { get; set; }

        [JsonProperty("meninggal")]
        public string Meninggal { get; set; }
    }
}
