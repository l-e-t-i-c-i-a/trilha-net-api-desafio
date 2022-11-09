using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioPottential.Models;

namespace DesafioPottential.Models
{
    public class Venda
    {
        public int Id { get; set; }
        public string NomeVendedor { get; set; }
        public  DateTime Data { get; set; }
        public List<Item> Itens { get; set; }
        public EnumStatusVenda Status { get; set; }
    }
}
