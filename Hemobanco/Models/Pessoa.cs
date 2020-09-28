using System;
using System.Collections.Generic;
using System.Text;

namespace Hemobanco.Models
{
    class Pessoa : BaseModel
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
    }
}
