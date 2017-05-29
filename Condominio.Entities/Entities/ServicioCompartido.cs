using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.Entities
{
    public class ServicioCompartido
    {
        public int ServiciocompartidoId { get; set; }
        public int CodServ { get; set; }

        //Condomi
        public int CondomiId { get; set; }
        public Condomi Condomi { get; set; }

        //Luz
        public int LuzId { get; set; }
        public Luz Luz { get; set; }

        //Agua
        public int AguaId { get; set; }
        public Agua Agua { get; set; }

        //vigilancia
        public int VigilanciaId { get; set; }
        public Vigilancia Vigilancia { get; set; }

        //Gas
        public int GasId { get; set; }
        public Gas Gas { get; set; }

        //Manteniemiento
        public int MantenimientoId { get; set; }
        public Mantenimiento Mantenimiento { get; set; }

    }
}
