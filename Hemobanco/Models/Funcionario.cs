using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Hemobanco.Models
{
    [Table("Funcionarios")]
    class Funcionario : Pessoa
    {
        public override string ToString()
        {
            return String.Format("{0}, CPF: {1};", Nome, CPF);
        }
    }
}
