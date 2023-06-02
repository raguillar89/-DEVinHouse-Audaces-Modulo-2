using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FilmesApi.Models
{
    [Table("filmes")]
    public class Filme
    {
        [Key]
        public int FilmeId { get; set; }

        [Required(ErrorMessage = "O nome do filme deve ser informado.")]
        [StringLength(100, ErrorMessage = "O tamanho máximo é de 100 caracteres")]
        [Display(Name = "Filme")]
        public string FilmeName { get; set; }

        [Required(ErrorMessage = "O diretor deve ser informado.")]
        [StringLength(30, ErrorMessage = "O tamanho máximo é de 30 caracteres")]
        [Display(Name = "Diretor")]
        public string Diretor { get; set; }

        [Required(ErrorMessage = "O gênero deve ser informado.")]
        [StringLength(20, ErrorMessage = "O tamanho máximo é de 20 caracteres")]
        [Display(Name = "Gênero")]
        public string Genero { get; set; }

        [Required(ErrorMessage = "A duração deve ser informado.")]
        [Display(Name = "Duração")]
        public int Duracao { get; set; }
    }
}
