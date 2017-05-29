using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.Entities
{
    public class EstadoPagoServBasico
    {
        public int EstadoPagoServBasicoId { get; set; }
        public string StatusPago { get; set; }

        //PagoCompartido
        public int PagoCompartidoId { get; set; }
        public PagoCompartido PagoCompartido { get; set; }
    }
}
