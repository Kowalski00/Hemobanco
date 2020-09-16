using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Hemobanco.Models
{
    [Table("Funcionarios")]
    class Funcionario
    {
        [Key]
        private int FuncId;
        private String Nome { get; set; }
        private String Cpf { get; set; }
        private String Email { get; set; }

    }
}
