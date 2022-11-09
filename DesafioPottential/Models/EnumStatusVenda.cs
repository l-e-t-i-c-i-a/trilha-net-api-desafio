using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioPottential.Models;

namespace DesafioPottential.Models
{
    public enum EnumStatusVenda
    {
        AguardandoPagamento,
        PagamentoAprovado,
        Cancelada,
        EnviadoParaTransportadora,
        Entregue
    }
}
