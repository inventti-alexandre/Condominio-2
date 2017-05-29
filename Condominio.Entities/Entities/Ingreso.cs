using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.Entities
{
    public class Ingreso
    {
        public int IngresoId { get; set; }
        public int DNI { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string Comentario { get; set; }

        //Condomi
        public int CondomiId { get; set; }
        public Condomi Condomi { get; set; }

        //Visitante
        public int VisitanteId { get; set; }
        public Visitante Visitante { get; set; }
    }
}
