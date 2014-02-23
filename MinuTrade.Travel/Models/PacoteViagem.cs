using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MinuTrade.Travel.Models
{
    [Table("pacote_viagem")]
    public class PacoteViagem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPacoteViagem { get; set; }

        [Display(Name = "Usuário")]
        public int UserId { get; set; }

        [Display(Name = "Origem")]
        public int IdCidadeOrigem { get; set; }

        [Display(Name = "Destino")]
        public int IdCidadeDestino { get; set; }

        [Display(Name = "Partida em(dd/mm/yyyy)")]
        public DateTime DataSaidaOrigem { get; set; }

        [Display(Name = "Volta em(dd/mm/yyyy)")]
        public DateTime DataSaidoDestino { get; set; }

        [Display(Name = "Nível de satisfação")]
        public int NivelSatisfacaoCliente { get; set; }

        public string NomeCidadeOrigem { get; set; }

        public string NomeCidadeDestino { get; set; }
    }
}