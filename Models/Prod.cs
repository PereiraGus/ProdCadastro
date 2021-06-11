using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ProdCadastro.Models
{
    public class Prod
    {
        [Range(1, 1000, ErrorMessage = "O código do produto deve ser entre 1 e 1000.")]
        [Remote("UniqueCod", "HomeController", ErrorMessage = "Esse código já existe.")]
        public int Codigo { get; set; }

        [Required(ErrorMessage = "O campo nome é obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo descrição é obrigatório.")]
        [StringLength(200, MinimumLength = 10, ErrorMessage = "A descrição deve ser entre 10 e 200 caracteres.")]
        public string Descricao { get; set; }

        [Range(1.00, 1000.00, ErrorMessage = "O peso deve ser entre 1kg e 1000kg")]
        public decimal Peso { get; set; }

        [Required(ErrorMessage = "O campo categoria é obrigatório.")]
        public string Categoria { get; set; }

        [Range(0.01, 10000, ErrorMessage = "O preço deve ser no mínimo de um centavo e no máximo dez mil reais.")]
        public decimal PrecoUnitario { get; set; }
    }
}