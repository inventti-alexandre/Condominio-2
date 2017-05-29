using Condominio.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.Persistence.EntitiesConfiguration
{
    public class AguaConfiguration : EntityTypeConfiguration<Agua>
    {
        public AguaConfiguration()
        {
            //table configuration
            ToTable("Agua");
            HasKey(m => m.AguaId);

            //relation configuration

            //relation ServicioCompartido
            //relation PagoCompartido
        }

    }
}
