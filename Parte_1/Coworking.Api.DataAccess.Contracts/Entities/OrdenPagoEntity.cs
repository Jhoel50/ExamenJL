using System;
using System.Collections.Generic;
using System.Text;

namespace Coworking.Api.DataAccess.Contracts.Entities
{
  public  class OrdenPagoEntity
    {
        public OrdenPagoEntity()
        {
            Id = 0;
            Monto = 0;
            Moneda = string.Empty;
            Estado = string.Empty;
            FechaPago = DateTime.Now;
            Sucursal = new SucursalEntity();
        }

        public int Id { get; set; }
        public decimal Monto { get; set; }
        public string Moneda { get; set; }
        public string Estado { get; set; }
        public DateTime FechaPago { get; set; }
        public SucursalEntity Sucursal { get; set; }
       // public List<SucursalEntity> Sucursales { get; set; }
    }
}
