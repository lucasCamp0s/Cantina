using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Cantina.Models
{
    public class Estoque
    {   [Key]

    [Display(Name ="Código")]
        public int id_produto { get; set; }

        [Display(Name = "Nome")]
        public string nome { get; set; }
        public decimal preco_compra { get; set; }

        [Display(Name = "Preço")]
        public decimal preco_venda { get; set; }
        public int quantidade { get; set; }
        public string fornecedor { get; set; }

        public ICollection<PedidoItem> PedidoItem { get; set; }
        
    }
}