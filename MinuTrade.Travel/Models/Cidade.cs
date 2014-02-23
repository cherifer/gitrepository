using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MinuTrade.Travel.Models
{
    [Table("tb_cidade")]
    public class Cidade
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCidade { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o Nome do Estado")]
        [Display(Name = "Estado")]
        public int IdEstado { get; set; }
        
        [Required(ErrorMessage = "Obrigatório Informar o Nome da Cidade")]
        [Display(Name = "Cidade")]
        public string DescricaoCidade { get; set; }

    }
}