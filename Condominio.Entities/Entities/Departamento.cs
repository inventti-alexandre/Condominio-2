using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.Entities
{
    public class Departamento
    {
        public int DepartamentoId { get; set; }
        public string NroNombre { get; set; }
        public int Telefono { get; set; }

        //Condominio
        public int CondomiId { get; set; }
        public Condomi Condomi { get; set; }

        //Estacionamiento
        public int EstacionamientoId { get; set; }
        public Estacionamiento Estacionamiento { get; set; }

        //Vehiculo
        public int VehiculoId { get; set; }
        public Vehiculo Vehiculo { get; set; }

        //Residente
        public int ResidenteId { get; set; }
        public Residente Residente { get; set; }

        //EstadoDepartamento
        public int EstadoDepaId { get; set; }
        public EstadoDepa EstadoDepa { get; set; }

        //PagoCompartido
        public int PagoCompartidoId { get; set; }
        public PagoCompartido PagoCompartido { get; set; }


    }
}
