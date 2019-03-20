using System;
using System.Collections.Generic;
using System.Text;

namespace Coworking.Api.Business.Models
{
   public class OrdenPago
    {
        public OrdenPago()
        {
            Id = 0;
            Monto = 0;
            Moneda = string.Empty;
            Estado = string.Empty;
            FechaPago = DateTime.Now;
            Sucursal = new Sucursal();
        }

        public int Id { get; set; }
        public decimal Monto { get; set; }
        public string Moneda { get; set; }
        public string Estado { get; set; }
        public DateTime FechaPago { get; set; }
        public Sucursal Sucursal { get; set; }
        //public List<Sucursal> Sucursales { get; set; }
    }
}
