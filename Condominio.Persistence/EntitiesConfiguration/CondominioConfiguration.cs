using Condominio.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.Persistence.EntitiesConfiguration
{
    public class CondominioConfiguration : EntityTypeConfiguration<Condomi>
    {
        public CondominioConfiguration()
        {
            //Estacionamientos
            HasRequired(c => c.Estacionamiento)
                .WithRequiredPrincipal(c => c.Condomi);
            //AreaComun
            //Ingreso
            //Salida
            //Empleado
            //Departamento
            //ServicioCompartido
            //Insumos
        }

    }
}
