using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Hemobanco.Models
{
    class BaseModel
    {
        [Key]
        public int Id { get; set; }
        public DateTime CriadoEm { get; set; }

        public BaseModel() => CriadoEm = DateTime.Now;
    
    }
}
