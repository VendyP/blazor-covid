using Application.Models;
using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Data
{
    public interface ICovidApi
    {
        [Get("/country/id")]
        Task<List<CovidApiByCountry>> GetCovidApiByCountries();

        [Get("/summary")]
        Task<CovidSummary> GetSummary();


    }
}
