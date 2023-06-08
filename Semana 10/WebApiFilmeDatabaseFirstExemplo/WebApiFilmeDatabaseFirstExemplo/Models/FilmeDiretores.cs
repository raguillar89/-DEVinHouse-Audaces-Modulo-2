using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApiFilmeDatabaseFirstExemplo.Models;

public class FilmeDiretores
{
    [Key]
    public int Id { get; set; }

    [ForeignKey("Filme")]
    public int IdFilme { get; set; }

    [ForeignKey("Diretores")]
    public int IdDiretor { get; set; }

    public Diretores Diretores { get; set; }
    public Filme Filme { get; set; }
}
