using Condominio.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.Persistence.Repositories
{
    public class UnityOfWork : IUnityOfWork
    {
        private readonly CondominioDbContext _Context;
        private static UnityOfWork _Instance;
        private static readonly object _Lock = new object();

        public IAguaRepository Aguas { get; private set; }

        public IAreaComunRepository AreaComunes { get; private set; }

        public ICompraRepository Compras { get; private set; }

        public ICondomiRepository Condomis { get; private set; }

        public IDepartamentoRepository Departamentos { get; private set; }

        public IEmpleadoRepository Empleados { get; private set; }

        public IEstacionamientoRepository Estacionamientos { get; private set; }

        public IEstadoDepaRepository EstadoDepas { get; private set; }

        
        private UnityOfWork()
        {
            _Context = new CondominioDbContext();

            Aguas = new AguaRepository(_Context);
            AreaComunes = new AreaComunRepository(_Context);
            Compras = new CompraRepository(_Context);
            Condomis = new CondomiRepository(_Context);
            Departamentos = new DepartamentoRepository(_Context);
            Empleados = new EmpleadoRepository(_Context);
            Estacionamientos = new EstacionamientoRepository(_Context);
            EstadoDepas = new EstadoDepaRepository(_Context);


        }

        public static UnityOfWork Instance
        {
            get
            {
                lock(_Lock)
                {
                    if (_Instance == null)
                        _Instance = new UnityOfWork();

                    return _Instance;
                }
            }
        }

        public void Dispose()
        {
            _Context.Dispose();
        }

        public int SaveChanges()
        {
            return _Context.SaveChanges();
        }
    }
}
