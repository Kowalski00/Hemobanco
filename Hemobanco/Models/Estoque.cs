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
        public int EstoqueId { get; set; }
        public Sangue sangue { get; set; }
        public Double Quantidade { get; set; }
        public Funcionario Func { get; set; }
        public DateTime ArmazenadoEm { get; set; }

        public Estoque() => ArmazenadoEm = DateTime.Now;

        public Estoque(Sangue sangue) {
            this.Quantidade = 0;
            this.sangue = sangue;
            this.ArmazenadoEm = DateTime.Now;
        }


    }

}
