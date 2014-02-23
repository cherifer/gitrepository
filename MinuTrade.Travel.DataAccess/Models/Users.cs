using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MinuTrade.Travel.DataAccess.Models
{
    [Table("Users")]
    public class Users
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o Nome do Usuário")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o Password")]
        public string Password { get; set; }
    }
}