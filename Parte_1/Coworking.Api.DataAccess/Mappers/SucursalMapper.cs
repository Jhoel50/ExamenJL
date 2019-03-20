using Coworking.Api.Business.Models;
using Coworking.Api.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coworking.Api.DataAccess.Mappers
{
    public class SucursalMapper
    {
        public static SucursalEntity Map(Sucursal dto)
        {
            return new SucursalEntity()
            {
                  Direccion = dto.Direccion,
                  FechaRegistro = dto.FechaRegistro,
                 Nombre = dto.Nombre,
                 Id=dto.Id,
                 Banco= new BancoEntity
                 {
                      Id=dto.Banco.Id,
                      Nombre=dto.Banco.Nombre,
                      Direccion=dto.Banco.Direccion,
                      FechaRegistro=dto.FechaRegistro
                 }
            };
        }
        public static Sucursal Map(SucursalEntity entity)
        {
            return new Sucursal()
            {
                Direccion = entity.Direccion,
                FechaRegistro = entity.FechaRegistro,
                Id = entity.Id,
                Nombre = entity.Nombre,
                Banco = new Banco
                {
                    Id = entity.Banco.Id,
                    Nombre = entity.Banco.Nombre,
                    Direccion = entity.Banco.Direccion,
                    FechaRegistro = entity.FechaRegistro
                }
            };
        }
    }
}
