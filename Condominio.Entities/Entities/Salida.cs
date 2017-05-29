using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.Entities
{
    public class Salida
    {
        public int SalidaId { get; set; }
        public int DNI { get; set; }
        public DateTime FechaSalida { get; set; }
        public string Comentario { get; set; }
    }
}
