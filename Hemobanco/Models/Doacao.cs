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
        public int DoacaoId { get; set; }
        public Doador Doador { get; set; }
        public double QtdSangue { get; set; }

        public Sangue Sangue { get; set; }
        public DateTime RealizadoEm { get; set; }

        public Doacao() => RealizadoEm = DateTime.Now;
    }
}
