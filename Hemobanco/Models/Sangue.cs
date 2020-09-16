using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Hemobanco.Models
{
    [Table("Sangues")]
    class Sangue
    {
        [Key]
        private int SangueId;
        private string SangueTipo { get; set; }
    }
}
