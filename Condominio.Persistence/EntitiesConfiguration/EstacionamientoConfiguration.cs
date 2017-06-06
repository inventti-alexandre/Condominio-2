using Condominio.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.Persistence.EntitiesConfiguration
{
    public class EstacionamientoConfiguration : EntityTypeConfiguration<Estacionamiento>
    {
        public EstacionamientoConfiguration()
        {
            //table configuration
            ToTable("Estacionamiento");
            HasKey(m => m.EstacionamientoId);
        }
    }
}
