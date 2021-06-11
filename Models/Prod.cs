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
        [Range(1, 100, ErrorMessage = "O código do produto deve ser entre 1 e 100.")]
        public int Codigo { get; set; }

        [Required(ErrorMessage = "O campo nome é obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo descrição é obrigatório.")]
        [StringLength(50, MinimumLength = 10, ErrorMessage = "A descrição deve ter no mínimo 10 caracteres.")]
        public string Descricao { get; set; }

        [Range(1, 100, ErrorMessage = "O peso deve ser entre 1kg e 100kg")]
        public double Peso { get; set; }

        [Required(ErrorMessage = "O campo categoria é obrigatório.")]
        public string Categoria { get; set; }

        [Range(0.01, 9999, ErrorMessage = "O preço deve ser no mínimo de um centavo.")]
        public double PrecoUnitario { get; set; }
    }
}