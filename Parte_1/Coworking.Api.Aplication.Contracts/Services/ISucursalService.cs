using Coworking.Api.Business.Models;
using Coworking.Api.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace Coworking.Api.Aplication.Contracts.Services
{
public interface ISucursalService
    {
        Task<SucursalEntity> GetSucursal(int Id);
        List<SucursalEntity> GetSucursalAll();
        Sucursal AddSucursal(Sucursal Sucursal);
        Sucursal UpdateSucursal(Sucursal Sucursal);
    }
}
