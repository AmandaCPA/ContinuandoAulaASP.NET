using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace TestandoASPNet.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(150, ErrorMessage = "Máximo de caracteres excedido")]
        [MinLength(2, ErrorMessage = "Mínimo de 2 caracteres")]
        [DisplayName("Nome do Cliente")]
        [Required(ErrorMessage = "Preencher campo Nome")]
        public string Nome { get; set; }


        [MaxLength(150, ErrorMessage = "Máximo de caracteres excedido")]
        [MinLength(2, ErrorMessage = "Mínimo de 2 caracteres")]
        [DisplayName("Sobrenome do Cliente")]
        [Required(ErrorMessage = "Preencher campo Sobrenome")]
        public string SobreNome { get; set; }


        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }


        [MaxLength(150, ErrorMessage = "Máximo de caracteres excedido")]
        [MinLength(2, ErrorMessage = "Mínimo de 2 caracteres")]
        [DisplayName("E-mail")]
        [Required(ErrorMessage = "Preencher campo e-mail")]
        [EmailAddress(ErrorMessage = "Email inválido")]
        public string Email { get; set; }

    }
}