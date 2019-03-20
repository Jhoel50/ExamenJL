using Coworking.Api.Business.Models;
using Coworking.Api.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coworking.Api.DataAccess.Mappers
{
    public static class BancoMapper
    {
        public static BancoEntity Map(Banco dto)
        {
            return new BancoEntity()
            {
                Direccion = dto.Direccion,
                FechaRegistro = dto.FechaRegistro,
                Id = dto.Id,
                Nombre = dto.Nombre
            };
        }
        public static Banco Map(BancoEntity entity)
        {
            return new Banco()
            {
                Direccion = entity.Direccion,
                FechaRegistro = entity.FechaRegistro,
                Id = entity.Id,
                Nombre = entity.Nombre
            };
        }
    }
}
