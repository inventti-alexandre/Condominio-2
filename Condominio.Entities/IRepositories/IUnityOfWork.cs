using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.Entities.IRepositories
{
    public interface IUnityOfWork : IDisposable
    {
        IAguaRepository Aguas { get; }
        IAreaComunRepository AreaComunes { get; }
        ICompraRepository Compras { get; }
        ICondomiRepository Condomis { get; }
        IDepartamentoRepository Departamentos { get; }
        IEmpleadoRepository  Empleados { get; }
        IEstacionamientoRepository Estacionamientos { get; }
        IEstadoDepaRepository EstadoDepas { get; }

        int SaveChanges();
    }
}
