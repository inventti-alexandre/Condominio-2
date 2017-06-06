using Condominio.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.Persistence.EntitiesConfiguration
{
    public class EmpleadoConfiguration : EntityTypeConfiguration<Empleado>
    {
        public EmpleadoConfiguration()
        {

            //table configuration
            ToTable("Empleado");
            HasKey(m => m.EmpleadoId);
            //Valoracion
            HasRequired(c => c.ValoracionEmpl)
               .WithRequiredPrincipal(c => c.Empleado);
            
            
        }
    }
}
