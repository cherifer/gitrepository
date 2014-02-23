using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MinuTrade.Travel.Models
{
    [Table("tb_estado")]
    public class Estado
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdEstado { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o Nome do Estado")]
        [Display(Name = "Estado")]
        public string NomeEstado { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar a Unidade Federativa")]
        [Display(Name = "UF")]
        public string UfEstado { get; set; }
    }
}