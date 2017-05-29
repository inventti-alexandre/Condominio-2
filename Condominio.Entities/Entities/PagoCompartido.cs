using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.Entities
{
    public class PagoCompartido
    {
        public int PagoCompartidoId { get; set; }
        public int CodPago { get; set; }
        public double Total { get; set; }
    }
}
