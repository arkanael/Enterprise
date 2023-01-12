using System.ComponentModel.DataAnnotations;

namespace Enterprise.UseCase.Clientes.Model.Request
{
    public class ClienteCadastroPageModel
    {
        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(100, ErrorMessage = "Campo necessita ter no máximo {1} caracteres.")]
        public string RazaoSocial { get; set; }

        [MaxLength(100, ErrorMessage = "Campo necessita ter no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string NomeFantasia { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string CNPJ { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string Site { get; set; }

    }
}
