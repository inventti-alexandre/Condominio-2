using Condominio.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.Persistence.EntitiesConfiguration
{
    public class EstadoDepaConfiguration : EntityTypeConfiguration<EstadoDepa>
    {
        public EstadoDepaConfiguration()
        {
            //table configuration
            ToTable("EstadoDepa");
            HasKey(m => m.EstadoDepartamentoId);

            
        }
    }
}
