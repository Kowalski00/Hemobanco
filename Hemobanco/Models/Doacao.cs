using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Hemobanco.Models
{
    [Table("Doacoes")]
    class Doacao
    {
        [Key]
        private int DoacaoId { get; set; }
        private Doador doacao;
        private double QtdSangue { get; set; }
        private DateTime CriadoEm { get; set; }
    }
}
