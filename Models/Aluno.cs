using System.ComponentModel.DataAnnotations;

namespace CadastroAluno.Models
{
    public class Aluno
    {
        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(20)]
        public string RA { get; set; }

        [Required]
        [StringLength(50)]
        public string Curso { get; set; }

        [Required]
        public DateTime DataNascimento { get; set; }
    }
}
