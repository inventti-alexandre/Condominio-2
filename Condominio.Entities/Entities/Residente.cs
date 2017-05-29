using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.Entities
{
    public class Residente
    {
        public int ResidenteId { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public int Dni { get; set; }
        public int Telefono { get; set; }

        //ValoracionResi
        public int ValoracionResiId { get; set; }
        public ValoracionResi ValoracionResi { get; set; }

        //Departamento
        public int DepartamentoId { get; set; }
        public Departamento Departamento { get; set; }

    }
}
