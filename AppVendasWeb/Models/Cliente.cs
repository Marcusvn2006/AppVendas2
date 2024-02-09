using System.ComponentModel.DataAnnotations;

namespace AppVendasWeb.Models
{
    public class Cliente
    {
        public Guid ClienteId { get; set; }

        [Display(Name = "Nome do Cliente")]
        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo Nome deve ter no máximo 100 caracteres")]
        public string ClienteNome { get; set; }

        [Required(ErrorMessage = "O campo CPF é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo CPF deve ter no máximo 11 caracteres")]
        public string CPF { get; set; }

        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "O campo E-mail é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo E-mail deve ter no máximo 150 caracteres")]
        public string Email { get; set; }

        [Display(Name = "Data de Nascimento")]
        [Required(ErrorMessage = "A Data de Nascimento é obrigatória")]
        public DateOnly DataNascimento { get; set; }
        public string? Celular { get; set; }

        [Display(Name = "Data de Cadastro")]
        public DateTime? DataCadastro { get; set; }

        [Display(Name = "Cadastro Ativo")]
        public bool CadastroAtivo { get; set; }
    }
}
