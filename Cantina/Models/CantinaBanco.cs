using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Cantina.Models
{
    public class CantinaBanco : DbContext
    {
        public CantinaBanco() : base("Defaultconnection")
        {

        }

        public System.Data.Entity.DbSet<Cantina.Models.Sangria> Sangrias { get; set; }

        public System.Data.Entity.DbSet<Cantina.Models.Cliente> Clientes { get; set; }

        public System.Data.Entity.DbSet<Cantina.Models.Pedido> Pedidoes { get; set; }

        public System.Data.Entity.DbSet<Cantina.Models.Estoque> Estoques { get; set; }

        public System.Data.Entity.DbSet<Cantina.Models.PedidoItem> PedidoItems { get; set; }
    }
}