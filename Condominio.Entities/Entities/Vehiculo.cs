using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.Entities
{
    public class Vehiculo
    {
        public int VehiculoId { get; set; }
        public string Placa { get; set; }
        public string Descripcion { get; set; }

        //Departamento
        public int DepartamentoId { get; set; }
        public Departamento Departamento { get; set; }
    }
}
