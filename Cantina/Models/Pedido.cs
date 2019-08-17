using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cantina.Models
{
    public class Pedido
    {
    [Key]
        public int id_pedido { get; set; }

     //   public string pedido { get { return string.Format(id_pedido.ToString()); } }
                                          

        public string statusVenda { get; set; }

        [DataType(DataType.Date)]
        public DateTime data { get; set; }

        public decimal valor { get; set; }

        public int id_cliente { get; set; }
        public virtual Cliente Cliente { get; set; }
       public virtual ICollection<PedidoItem> pedidoitem { get; set; }



    }
}