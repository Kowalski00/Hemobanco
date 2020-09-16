using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Hemobanco.Models
{
    [Table("Doadores")]
    class Doador
    {
        [Key]
        private int DoadorId;
        private string Nome { get; set; }
        private string CPF { get; set; }
        private string Email { get; set; }
        private int Idade { get; set; }
        private string Endereco { get; set; }
        private string Telefone { get; set; }
        private Sangue sangue;
    }
}
