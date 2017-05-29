using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.Entities
{
    public class Insumo
    {
        public int InsumoId { get; set; }
        public string Elemento { get; set; }

        //Condomi
        public int CondomiId { get; set; }
        public Condomi Condomi { get; set; }

        //Compra
        public int CompraIc { get; set; }
        public Compra Compra { get; set; }

        //Mantenimiento
        public int MantenimientoId { get; set; }
        public Mantenimiento Mantenimiento { get; set; }
        
    }
}
