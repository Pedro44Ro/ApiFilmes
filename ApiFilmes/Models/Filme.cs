using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiFilmes.Models
{
    [Table("Filmes")]
    public class Filme
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }
        public string? Cartaz { get; set; }
        public string Genero { get; set; }
        public string Duracao { get; set; }
        [Required]
        public int Lancamento { get; set; }
        public string? Sinopse { get; set; }
        public string Faixaetaria { get; set; }
        public string? Avalicaopub { get; set; }
        public string? Avalicaocrit { get; set; }
        [Required]
        public string Status { get; set; }

    }
}
