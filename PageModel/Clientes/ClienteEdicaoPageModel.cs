using System.ComponentModel.DataAnnotations;

namespace Enterprise.PageModel.Clientes
{
    public class ClienteEdicaoPageModel
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        public string RazaoSocial { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string NomeFantasia { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string CNPJ { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string Site { get; set; }
    }
}
