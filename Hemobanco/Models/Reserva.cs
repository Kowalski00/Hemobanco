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
        private int ReservaId;
        private Sangue sangue { get; set; }
        private int Quantidade { get; set; }
        private Funcionario Func { get; set; }
        private DateTime CriadoEm { get; set; }
        private String Status { get; set; }
    }
}
