using CinemaxWeb.DTOs;
namespace CinemaxWeb.Services
{
    public interface IPeliculasService
    {
        Task<List<PeliculaCarteleraDTO>> GetPeliculasCarteleraAsync();
    }
}
