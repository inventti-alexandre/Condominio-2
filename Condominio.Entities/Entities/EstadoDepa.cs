using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.Entities
{
    public class EstadoDepa
    {
        public int EstadoDepartamentoId { get; set; }
        public string EstadoOcupacion { get; set; }
        public string EstadoDepartamento { get; set; }
        public string Observacion { get; set; }

        //Departamento
        public int DepartamentoId { get; set; }
        public Departamento Departamento { get; set; }
    }
}
