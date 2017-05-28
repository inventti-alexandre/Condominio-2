using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.Entities
{
    public class Condominio
    {
        public int ComdominioId { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Emp_Admin { get; set; }
    }
}
