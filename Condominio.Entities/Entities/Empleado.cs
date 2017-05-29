using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.Entities
{
    public class Empleado
    {
        public int EmpleadoId { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Puesto { get; set; }
        public int Telefono { get; set; }


        //Condomi
        public int CondomiId { get; set; }
        public Condomi Condomi { get; set; }


        //Valoracion
        public int ValoracionEmplId { get; set; }
        public ValoracionEmpl ValoracionEmpl { get; set; }
    }
}
