using Newtonsoft.Json;
using System;

namespace Application.Models
{
    public class CovidApiByCountry
    {
        [JsonProperty("Country")]
        public string Country { get; set; }

        [JsonProperty("CountryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("Province")]
        public string Province { get; set; }

        [JsonProperty("City")]
        public string City { get; set; }

        [JsonProperty("CityCode")]
        public string CityCode { get; set; }

        [JsonProperty("Lat")]
        public string Lat { get; set; }

        [JsonProperty("Lon")]
        public string Lon { get; set; }

        [JsonProperty("Confirmed")]
        public long Confirmed { get; set; }

        [JsonProperty("Deaths")]
        public long Deaths { get; set; }

        [JsonProperty("Recovered")]
        public long Recovered { get; set; }

        [JsonProperty("Active")]
        public long Active { get; set; }

        [JsonProperty("Date")]
        public DateTimeOffset Date { get; set; }
    }
}
