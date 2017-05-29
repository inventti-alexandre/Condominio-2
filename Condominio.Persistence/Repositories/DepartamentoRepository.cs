using Condominio.Entities;
using Condominio.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.Persistence.Repositories
{
    public class DepartamentoRepository : Repository<Departamento>, IDepartamentoRepository
    {
        private readonly CondominioDbContext _Context;

        public DepartamentoRepository(CondominioDbContext context)
        {
            _Context = context;
        }
        private DepartamentoRepository()
        {

        }
    }
}
