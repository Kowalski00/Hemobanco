using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Hemobanco.Models
{
    [Table("Doadores")]
    class Doador : Pessoa
    {
        public int Idade { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }

        public override string ToString()
        {
            return String.Format("{0}, CPF: {1};",Nome,CPF);
        }
    }
}
