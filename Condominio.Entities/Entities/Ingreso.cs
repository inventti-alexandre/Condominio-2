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
    }
}
