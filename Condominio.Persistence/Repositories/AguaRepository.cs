using Condominio.Entities;
using Condominio.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.Persistence.Repositories
{
    public class AguaRepository : Repository<Agua>,IAguaRepository
    {
        private readonly CondominioDbContext _Context;
        private AguaRepository()
        {

        }
        public AguaRepository(CondominioDbContext context)
        {
            _Context = context;
        }
    }
}
