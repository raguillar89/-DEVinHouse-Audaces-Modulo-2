namespace WebApiFilmeDatabaseFirstExemplo.Models;

public partial class Filme
{
    public Filme()
    {
        FilmeDiretores = new HashSet<FilmeDiretores>();
    }
    public int FilmeId { get; set; }

    public string FilmeName { get; set; } = null!;

    public string Diretor { get; set; } = null!;

    public string Genero { get; set; } = null!;

    public int Duracao { get; set; }

    public virtual ICollection<FilmeDiretores> FilmeDiretores { get; set; }
}
