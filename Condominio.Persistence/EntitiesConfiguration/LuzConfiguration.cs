using Condominio.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.Persistence.EntitiesConfiguration
{
    public class LuzConfiguration : EntityTypeConfiguration<Luz>
    {
        public LuzConfiguration()
        {
            //table configuration
            ToTable("Luz");
            HasKey(m => m.LuzId);

            //relation ServicioCompartido
            HasRequired(c => c.ServicioCompartido)
                .WithRequiredPrincipal(c => c.Luz);
            //relation PagoCompartido
            HasRequired(c => c.PagoCompartido)
                .WithRequiredPrincipal(c => c.Luz);
        }
    }
}
