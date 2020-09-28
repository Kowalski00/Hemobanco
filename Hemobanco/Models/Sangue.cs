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
        public int SangueId { get; set; }
        public string SangueTipo { get; set; }
    }
}
