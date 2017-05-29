using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.Entities
{
    public class Condomi
    {
        public int ComdomiId { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Emp_Admin { get; set; }

        //Estacionamiento
        public int EstacionamientoId { get; set; }
        public Estacionamiento Estacionamiento { get; set; }

        //AreaComun
        public int AreaComunId { get; set; }
        public AreaComun AreaComun { get; set; }

        //Ingreso
        public int IngresoId { get; set; }
        public Ingreso Ingreso { get; set; }

        //Salida
        public int SalidaId { get; set; }
        public Salida Salida { get; set; }

        //Empleado
        public int EmpleadoId { get; set; }
        public Empleado Empleado { get; set; }

        //Departamento
        public int DepartamentoId { get; set; }
        public Departamento Departamento { get; set; }

        //ServicioCompartido
        public int ServicioCompartidoId { get; set; }
        public ServicioCompartido ServicioCompartido { get; set; }

        //Insumo
        public int InsumoId { get; set; }
        public Insumo Insumo { get; set; }

    }
}
