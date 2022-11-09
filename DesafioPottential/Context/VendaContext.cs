using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DesafioPottential.Models;
using System.Net;

namespace DesafioPottential.Context
{
    public class VendaContext : DbContext
    {
        public VendaContext(DbContextOptions<VendaContext> options) : base(options)
        {

        }

        public DbSet<Venda> Vendas { get; set; }
        public DbSet<Item> Itens { get; set; }
        public DbSet<Vendedor> Vendedores { get; set; }
    }
}
