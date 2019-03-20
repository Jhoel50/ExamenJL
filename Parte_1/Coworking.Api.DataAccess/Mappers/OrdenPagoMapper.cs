using Coworking.Api.Business.Models;
using Coworking.Api.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coworking.Api.DataAccess.Mappers
{
    public class OrdenPagoMapper
    {
        public static OrdenPagoEntity Map(OrdenPago dto)
        {
            return new OrdenPagoEntity()
            {
                 Estado = dto.Estado,
                 FechaPago = dto.FechaPago,
                 Id = dto.Id,
                 Moneda = dto.Moneda,
                 Monto=dto.Monto,
                 Sucursal= new SucursalEntity
                 {
                     Banco=new BancoEntity {
                         Direccion=dto.Sucursal.Banco.Direccion,
                         FechaRegistro = dto.Sucursal.Banco.FechaRegistro,
                        Id  = dto.Sucursal.Banco.Id,
                        Nombre=dto.Sucursal.Nombre
                     },
                     Direccion=dto.Sucursal.Direccion,
                     FechaRegistro=dto.Sucursal.FechaRegistro,
                     Id=dto.Sucursal.Id,
                     Nombre=dto.Sucursal.Nombre
                 }
            };
        }
        public static OrdenPago Map(OrdenPagoEntity entity)
        {
            return new OrdenPago()
            {
                Estado = entity.Estado,
                FechaPago = entity.FechaPago,
                Id = entity.Id,
                Moneda = entity.Moneda,
                Monto = entity.Monto,
                Sucursal= new Sucursal
                {
                    Banco= new Banco
                    {
                        Id=entity.Sucursal.Banco.Id,
                        Direccion = entity.Sucursal.Banco.Direccion,
                        Nombre= entity.Sucursal.Banco.Nombre,
                        FechaRegistro=entity.Sucursal.FechaRegistro
                    },
                 Direccion=entity.Sucursal.Direccion,
                  FechaRegistro = entity.Sucursal.FechaRegistro,
                  Id = entity.Sucursal.Id,
                   Nombre=entity.Sucursal.Nombre
                }
            };
        }
    }
}
