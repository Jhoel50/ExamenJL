using Coworking.Api.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Api.ViewModels;

namespace Web_Api.Mappers
{
    public static class BancoMappers
    {
        public static Banco Map(BancoModel Model)
        {
            return new Banco()
            {
                Direccion=Model.Direccion,
                FechaRegistro=Model.FechaRegistro,
                Id=Model.Id,
                Nombre=Model.Nombre
            };

        }
    }
}
