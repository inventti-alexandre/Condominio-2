using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.Entities
{
    public class Reserva
    {
        public int ReservaId { get; set; }
        public int Codreserva { get; set; }
        public DateTime DiaInicio { get; set; }
        public DateTime DiaFin { get; set; }
    }
}
