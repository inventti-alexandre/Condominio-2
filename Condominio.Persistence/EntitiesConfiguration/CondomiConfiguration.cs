using Condominio.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.Persistence.EntitiesConfiguration
{
    public class CondomiConfiguration : EntityTypeConfiguration<Condomi>
    {
        public CondomiConfiguration()
        {
            //Estacionamientos
            HasRequired(c => c.Estacionamiento)
                .WithRequiredPrincipal(c => c.Condomi);
            //AreaComun
            HasRequired(c => c.AreaComun)
                .WithRequiredPrincipal(c => c.Condomi);
            //Ingreso
            HasRequired(c => c.Ingreso)
                .WithRequiredPrincipal(c => c.Condomi);
            //Salida
            HasRequired(c => c.Salida)
                .WithRequiredPrincipal(c => c.Condomi);
            //Empleado
            HasRequired(c => c.Empleado)
                .WithRequiredPrincipal(c => c.Condomi);
            //Departamento
            HasRequired(c => c.Departamento)
                .WithRequiredPrincipal(c => c.Condomi);
            //ServicioCompartido
            HasRequired(c => c.ServicioCompartido)
                .WithRequiredPrincipal(c => c.Condomi);
            //Insumos
            HasRequired(c => c.Insumo)
                .WithRequiredPrincipal(c => c.Condomi);
        }

    }
}
