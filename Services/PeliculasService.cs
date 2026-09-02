using CinemaxWeb.DTOs;
using CinemaxWeb.Services;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
namespace CinemaxWeb.Services
{
    public class PeliculasService : IPeliculasService
    {
        private readonly HttpClient _http;

        public PeliculasService(HttpClient http)
        {
            _http = http;
        }
        public async Task<List<PeliculaCarteleraDTO>> GetPeliculasCarteleraAsync()
        {
            var peliculas = await _http.GetFromJsonAsync<List<PeliculaCarteleraDTO>>(
                "api/Peliculas/cartelera");

            return peliculas ?? new List<PeliculaCarteleraDTO>();
        }
    }
}
