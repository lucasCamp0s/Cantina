using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cantina.Models
{
    public class PedidoItem
    {
        [Key]

        public int id_pedidoItem { get; set; }
        public int id_pedido { get; set; }
        public int id_produto { get; set; }
        public int quantidade { get; set; }

        public virtual Pedido pedido { get; set; }
        public virtual Estoque estoque { get; set; }
       

    }
}