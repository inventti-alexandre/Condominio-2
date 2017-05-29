using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.Entities
{
    public class Visitante
    {
        public int VisitanteId { get; set; }
        public int DNI { get; set; }
        public string Nombre { get; set; }

        //Ingreso
        public int IngresoId { get; set; }
        public Ingreso Ingreso { get; set; }

        //Salida
        public int SalidaId { get; set; }
        public Salida Salida { get; set; }
    }
}
