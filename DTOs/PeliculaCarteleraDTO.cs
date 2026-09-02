namespace CinemaxWeb.DTOs
{
    public class PeliculaCarteleraDTO
    {
        public int IdPelicula { get; set; }
        public string Titulo { get; set; } = null!;
        public string PosterURL { get; set; } = null!;
    }
}
