using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Hemobanco.Models
{
    [Table("Reservas")]
    class Reserva
    {
        [Key]
        public int ReservaId { get; set; }
        public Sangue sangue { get; set; }
        public int Quantidade { get; set; }
        public Funcionario Func { get; set; }
        public DateTime CriadoEm { get; set; }
        public String Status { get; set; }
    }
}
