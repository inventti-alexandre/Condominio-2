using Condominio.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.Persistence.EntitiesConfiguration
{
    public class MantenimientoConfiguration : EntityTypeConfiguration<Mantenimiento>
    {
        public MantenimientoConfiguration()
        {
            //table configuration
            ToTable("mantenimiento");
            HasKey(m => m.MantenimientoId);

            //relation insumo
            HasRequired(c => c.Insumo)
                .WithRequiredPrincipal(c => c.Mantenimiento);
            //relation PagoCompartido
            HasRequired(c => c.PagoCompartido)
                .WithRequiredPrincipal(c => c.Mantenimiento);
        }
    }
}
