using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Projeto.Web.Models
{
    public class ClienteViewModelConsulta
    {
        [RegularExpression("^[A-Za-zÀ-Üà-ü\\s]{3,30}$",
            ErrorMessage = "Erro. Informe um nome valido para a pesquisa.")]
        [Required(ErrorMessage = "Por favor, informe o nome do cliente.")]
        [Display(Name = "Nome do Cliente desejado: ")]
        public string Nome { get; set; }

    }
}