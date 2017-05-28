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
        public int Cod_Recibo { get; set; }
        public string Elemento { get; set; }
        public int Empleado_Id { get; set; }
        public double Total { get; set; }
    }
}
