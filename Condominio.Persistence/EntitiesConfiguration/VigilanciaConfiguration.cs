using Condominio.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.Persistence.EntitiesConfiguration
{
    public class VigilanciaConfiguration : EntityTypeConfiguration<Vigilancia>
    {
        public VigilanciaConfiguration()
        {
            //table configuration
            ToTable("Vigilancia");
            HasKey(m => m.VigilanciaId);

            //relation ServicioCompartido
            HasRequired(c => c.ServicioCompartido)
                .WithRequiredPrincipal(c => c.Vigilancia);
            //relation PagoCompartido
            HasRequired(c => c.PagoCompartido)
                .WithRequiredPrincipal(c => c.Vigilancia);
        }
    }
}
