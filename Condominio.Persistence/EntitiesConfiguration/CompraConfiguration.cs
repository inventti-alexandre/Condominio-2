using Condominio.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.Persistence.EntitiesConfiguration
{
    public class CompraConfiguration : EntityTypeConfiguration<Compra>
    {
        public CompraConfiguration()
        {
            //table configuration
            ToTable("Compra");
            HasKey(m => m.CompraId);

            //relation configuration
            //Proveedor
            HasRequired(c => c.Proveedor)
                .WithRequiredPrincipal(c => c.Compra);
            //FormasDePago
            HasRequired(c => c.FormasDePago)
                .WithRequiredPrincipal(c => c.Compra);
            //Insumo
            HasRequired(c => c.Insumo)
                .WithRequiredPrincipal(c => c.Compra);
        }
    }
}
