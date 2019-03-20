using Coworking.Api.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Api.ViewModels;

namespace Web_Api.Mappers
{
    public  static class SucursalMappers
    {
        public static Sucursal Map(SucursalModel Model)
        {
            return new Sucursal()
            {
                 Direccion=Model.Direccion,
                  FechaRegistro=Model.FechaRegistro,
                   Id=Model.Id,
                   Nombre=Model.Nombre,
                   Banco = new Banco
                   {
                       Id=Model.Banco.Id,
                       Direccion=Model.Banco.Direccion,
                       FechaRegistro=Model.Banco.FechaRegistro,
                       Nombre=Model.Banco.Nombre
                   }
            };

        }
    }
}
