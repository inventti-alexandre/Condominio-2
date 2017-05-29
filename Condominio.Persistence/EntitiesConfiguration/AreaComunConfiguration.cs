using Condominio.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.Persistence.EntitiesConfiguration
{
    public class AreaComunConfiguration : EntityTypeConfiguration<AreaComun>
    {
        public AreaComunConfiguration()
        {
            //table configuration
            ToTable("AreaComun");
            HasKey(m => m.AreaComunId);

            //relation configuration
            //Reserva
            HasRequired(c => c.Reserva)
                .WithRequiredPrincipal(c => c.AreaComun);
            //Condomi
            HasRequired(c => c.Condomi)
                .WithRequiredPrincipal(c => c.AreaComun);
        }
    }
}
