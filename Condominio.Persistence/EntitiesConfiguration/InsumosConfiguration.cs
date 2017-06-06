using Condominio.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.Persistence.EntitiesConfiguration
{
    public class InsumoConfiguration : EntityTypeConfiguration<Insumo>
    {
        public InsumoConfiguration()
        {
            //table configuration
            ToTable("insumo");
            HasKey(m => m.InsumoId);
        }
    }
}
