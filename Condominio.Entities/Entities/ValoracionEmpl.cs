using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.Entities
{
    public class ValoracionEmpl
    {
        public int ValoracionEmplId { get; set; }
        public string Comentario { get; set; }
        public int Valoracion { get; set; }

        //Empleado
        public int EmpleadoId { get; set; }
        public Empleado Empleado { get; set; }
    }
}
