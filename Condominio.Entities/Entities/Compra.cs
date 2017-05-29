using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.Entities
{
    public class Compra
    {
        public int CompraId { get; set; }
        public int CodRecibo { get; set; }
        public string Elemento { get; set; }
        public int EmpleadoId { get; set; }
        public double Total { get; set; }

        //Proveedor
        public int ProveedorId { get; set; }
        public Proveedor Proveedor { get; set; }

        //FormasdePago
        public int FormasDePagoId { get; set; }
        public FormaDePago FormasDePago { get; set; }

        //Insumos
        public int InsumoId { get; set; }
        public Insumo Insumo { get; set; }

    }
}
