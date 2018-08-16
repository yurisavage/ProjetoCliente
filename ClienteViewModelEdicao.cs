using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Projeto.Web.Models
{
    public class ClienteViewModelEdicao
    {
        [Required(ErrorMessage = "Por favor, informe o código do cliente.")]
        [Display(Name = "Código:")]
        public int IdCliente { get; set; }

        [Required(ErrorMessage = "Por favor, informe o nome do cliente.")]
        [Display(Name = "Nome do Cliente:")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Por favor, informe o email do cliente.")]
        [Display(Name = "Endereço de Email:")] 
        public string Email { get; set; }

    }
}