﻿using Condominio.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.Persistence.EntitiesConfiguration
{
    public class IngresoConfiguration : EntityTypeConfiguration<Ingreso>
    {
        public IngresoConfiguration()
        {
            //table configuration
            ToTable("Ingreso");
            HasKey(m => m.IngresoId);

        }
    }
}
