using Coworking.Api.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Api.ViewModels;

namespace Web_Api.Mappers
{
    public  static class OrdenPagoMappers
    {
        public static OrdenPago Map(OrdenPagoModel Model)
        {
            return new OrdenPago()
            {
                 Estado = Model.Estado,
                 FechaPago = Model.FechaPago,
                 Id = Model.Id,
                 Moneda = Model.Moneda,
                  Monto=Model.Monto,
                  Sucursal= new Sucursal
                  {
                      Banco=Model.Sucursal.Banco,
                      Direccion=Model.Sucursal.Direccion,
                      FechaRegistro=Model.Sucursal.FechaRegistro,
                      Id=Model.Sucursal.Id,
                      Nombre=Model.Sucursal.Nombre
                  }
            };

        }
    }
}
