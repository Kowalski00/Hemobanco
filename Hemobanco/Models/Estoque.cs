using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Hemobanco.Models
{
    [Table("Estoques")]
    class Estoque
    {
        [Key]
        private int EstoqueId;
        private Sangue sangue { get; set; }
        private int Quantidade { get; set; }
        private Funcionario Func { get; set; }
        private DateTime ArmazenadoEm { get; set; }
    }

}
