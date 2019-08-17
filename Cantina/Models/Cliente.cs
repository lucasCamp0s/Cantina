using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cantina.Models
{
    public class Cliente
    {
        [Key]
        public int id_cliente { get; set; }
        [Display(Name = "CPF")]
        public string cpg { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }

       public virtual ICollection<Pedido> pedido { get; set; }
     

    }
}