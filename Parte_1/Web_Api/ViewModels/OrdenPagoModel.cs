using Coworking.Api.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Api.ViewModels
{
    public class OrdenPagoModel
    {
        public int Id { get; set; }
        public decimal Monto { get; set; }
        public string Moneda { get; set; }
        public string Estado { get; set; }
        public DateTime FechaPago { get; set; }
        public Sucursal Sucursal { get; set; }
       // public List<Sucursal> Sucursales { get; set; }
    }
}
