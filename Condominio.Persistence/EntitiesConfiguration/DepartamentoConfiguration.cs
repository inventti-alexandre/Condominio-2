using Condominio.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.Persistence.EntitiesConfiguration
{
    public class DepartamentoConfiguration : EntityTypeConfiguration<Departamento>
    {
        public DepartamentoConfiguration()
        {
            //table configuration
            ToTable("Departamento");
            HasKey(m => m.DepartamentoId);

            //Estacionamiento
            HasRequired(c => c.Estacionamiento)
                .WithRequiredPrincipal(c => c.Departamento);
            //Vehiculo
            HasRequired(c => c.Vehiculo)
                .WithRequiredPrincipal(c => c.Departamento);
            //Residente
            HasRequired(c => c.Residente)
                .WithRequiredPrincipal(c => c.Departamento);
            //StadoDepa
            HasRequired(c => c.EstadoDepa)
                .WithRequiredPrincipal(c => c.Departamento);

        }
    }
}
