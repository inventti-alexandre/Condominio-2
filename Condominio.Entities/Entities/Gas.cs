using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.Entities
{
    public class Gas
    {
        public int GasId { get; set; }
        public int NumSuministro { get; set; }
        public double Importe { get; set; }

        //ServicioCompratido
        public int ServicioCompartidoId { get; set; }
        public ServicioCompartido ServicioCompartido { get; set; }

        //PagoCompartido
        public int PagoCompartidoId { get; set; }
        public PagoCompartido PagoCompartido { get; set; }

    }
}
