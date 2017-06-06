using Condominio.Entities;
using Condominio.Persistence.EntitiesConfiguration;
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
        public DbSet<Agua> Aguas { get; set; }
        public DbSet<AreaComun> AreaComunes { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<Condomi> Codomis { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Estacionamiento> Estacionamientos { get; set; }
        public DbSet<EstadoDepa> EstadoDepas { get; set; }
        public DbSet<EstadoPagoServBasico> EstadopagoServBasicos { get; set; }
        public DbSet<FormaDePago> FormasDePagos { get; set; }
        //proveedor
        public DbSet<Proveedor> Proveedores { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AguaConfiguration());
            modelBuilder.Configurations.Add(new AreaComunConfiguration());
            modelBuilder.Configurations.Add(new CompraConfiguration());
            modelBuilder.Configurations.Add(new CondomiConfiguration());
            modelBuilder.Configurations.Add(new DepartamentoConfiguration());
            modelBuilder.Configurations.Add(new EmpleadoConfiguration());
            modelBuilder.Configurations.Add(new EstacionamientoConfiguration());
            modelBuilder.Configurations.Add(new EstadoDepaConfiguration());
            modelBuilder.Configurations.Add(new EstadoPagoServBasicoConfiguration());
            modelBuilder.Configurations.Add(new FormaDePagoConfiguration());
            modelBuilder.Configurations.Add(new GasConfiguration());
            modelBuilder.Configurations.Add(new IngresoConfiguration());
            modelBuilder.Configurations.Add(new InsumoConfiguration());
            modelBuilder.Configurations.Add(new LuzConfiguration());
            modelBuilder.Configurations.Add(new MantenimientoConfiguration());
            modelBuilder.Configurations.Add(new ProveedorConfiguration());
            modelBuilder.Configurations.Add(new ReservaConfiguration());
            modelBuilder.Configurations.Add(new ResidenteConfiguration());
            modelBuilder.Configurations.Add(new SalidaConfiguration());
            modelBuilder.Configurations.Add(new ServicioCompartidoConfiguration());
            modelBuilder.Configurations.Add(new ValoracionEmplConfiguration());
            modelBuilder.Configurations.Add(new ValoracionResiConfiguration());
            modelBuilder.Configurations.Add(new VehiculoConfiguration());
            modelBuilder.Configurations.Add(new VigilanciaConfiguration());
            modelBuilder.Configurations.Add(new VisitanteConfiguration());




            base.OnModelCreating(modelBuilder);
        }
    }

    
}
