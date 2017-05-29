using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.Entities
{
    public class AreaComun
    {
        public string AreaComunId { get; set; }
        public int CantPresonas { get; set; }
        public double CostoDia { get; set; }

        //Reserva
        public int ReservaId { get; set; }
        public Reserva Reserva { get; set; }

        //Condomi
        public int CondomiId { get; set; }
        public Condomi Condomi { get; set; }


    }
}
