using Condominio.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.Persistence.EntitiesConfiguration
{
    public class FormaDePagoConfiguration : EntityTypeConfiguration<FormaDePago>
    {
        public FormaDePagoConfiguration()
        {
            //table configuration
            ToTable("FormaDePago");
            HasKey(m => m.FormaDePagoId);
        }
    }
}
