using Coworking.Api.Aplication.Contracts.Services;
using Coworking.Api.Business.Models;
using Coworking.Api.DataAccess.Contracts.Entities;
using Coworking.Api.DataAccess.Contracts.Repositories;
using Coworking.Api.DataAccess.Mappers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace Coworking.Api.Aplication.Services
{
   public class SucursalService: ISucursalService
    {
        private readonly ISucursalRepository _SucursalRepository;
        public SucursalService(ISucursalRepository SucursalRepository)
        {
            _SucursalRepository = SucursalRepository;
        }
        public async Task<SucursalEntity> GetSucursal(int Id)
        {
            var entidad = await _SucursalRepository.Get(Id);
            return entidad;
        }

        public List<SucursalEntity> GetSucursalAll()
        {
            var entidad = _SucursalRepository.GetAll();
            return entidad;
        }

        public Sucursal AddSucursal(Sucursal Sucursal)
        {
            var ResultadoEntity = _SucursalRepository.Add(SucursalMapper.Map(Sucursal));
            return SucursalMapper.Map(ResultadoEntity);
        }
        public Sucursal UpdateSucursal(Sucursal Sucursal)
        {
            var ResultadoEntity = _SucursalRepository.Update(SucursalMapper.Map(Sucursal));
            return SucursalMapper.Map(ResultadoEntity);
        }
    }
}
