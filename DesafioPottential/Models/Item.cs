using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioPottential.Models;

namespace DesafioPottential.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Produto { get; set; }
        public int Quantidade { get; set; }
        public int Venda { get; set; }
    }
}
