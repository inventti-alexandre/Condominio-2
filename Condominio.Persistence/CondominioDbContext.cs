using Condominio.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.Persistence
{
    public class CondominioDbContext : DbContext
    {
        public DbSet<Residente> Residentes { get; set; }

        static void Main(string[] args)
        {

        }
    }

    
}
