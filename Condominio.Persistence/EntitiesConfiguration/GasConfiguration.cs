using Condominio.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.Persistence.EntitiesConfiguration
{
    public class GasConfiguration : EntityTypeConfiguration<Gas>
    {
        public GasConfiguration()
        {
            //table configuration
            ToTable("Gas");
            HasKey(m => m.GasId);

           

            //relation ServicioCompartido
            HasRequired(c => c.ServicioCompartido)
                .WithRequiredPrincipal(c => c.Gas);
            //relation PagoCompartido
            HasRequired(c => c.PagoCompartido)
                .WithRequiredPrincipal(c => c.Gas);
        }
    }
}
