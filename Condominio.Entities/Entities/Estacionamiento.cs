using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.Entities
{
    public class Estacionamiento
    {
        public int EstacionamientoId { get; set; }
        public string Pabellon { get; set; }

        //Condominio
        public int CondomiId { get; set; }
        public Condomi Condomi { get; set; }
    }
}
