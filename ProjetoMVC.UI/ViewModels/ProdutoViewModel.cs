using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoMVC.UI.ViewModels
{
    public class ProdutoViewModel
    {
        [Key]
        public int ProdutoId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(250, ErrorMessage = "Maximo {0} Caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} Caracteres")]
        public string Nome { get; set; }

        [DataType(DataType.Currency)]
        [Range(typeof(decimal),"0","999999999999")]
        [Required(ErrorMessage = "Preencha um valor")]
        public decimal Valor { get; set; }

        [DisplayName("Disponivel?")]
        public bool Disponivel { get; set; }

        public int ClientId { get; set; }

        public virtual ClienteViewModel Cliente { get; set; }
    }
}