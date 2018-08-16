using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Projeto.Web.Models
{
    public class ClienteViewModelCadastro
    {
        [RegularExpression("^[A-Za-zÀ-Üà-ü\\s]{3,30}$",
            ErrorMessage = "Erro. Informe um nome válido para o cliente.")]
        [Required(ErrorMessage ="por favor, informe o nome do cliente.")]
        [Display(Name = "Nome do Cliente:")]
        public string Nome { get; set; }

        [EmailAddress(ErrorMessage = "Erro. Informe um email válido para o cliente.")]
        [Required(ErrorMessage = "Por favor, informe o email do cliente.")]
        [Display(Name = "Email do Cliente:")]
        public string Email { get; set; }



    }
}