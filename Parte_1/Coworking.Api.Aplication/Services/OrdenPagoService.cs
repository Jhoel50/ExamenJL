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
    public class OrdenPagoService: IOrdenPagoService
    {
        private readonly IOrdenPagoRepository _OrdenPagoRepository;
        public OrdenPagoService(IOrdenPagoRepository OrdenPagoRepository)
        {
            _OrdenPagoRepository = OrdenPagoRepository;
        }
        public async Task<OrdenPagoEntity> GetOrdenPago(int Id)
        {
            var entidad = await _OrdenPagoRepository.Get(Id);
            return entidad;
        }

        public List<OrdenPagoEntity> GetOrdenPagoAll()
        {
            var entidad = _OrdenPagoRepository.GetAll();
            return entidad;
        }

        public OrdenPago AddOrdenPago(OrdenPago OrdenPago)
        {
            var ResultadoEntity = _OrdenPagoRepository.Add(OrdenPagoMapper.Map(OrdenPago));
            return OrdenPagoMapper.Map(ResultadoEntity);
        }
        public OrdenPago UpdateOrdenPago(OrdenPago OrdenPago)
        {
            var ResultadoEntity = _OrdenPagoRepository.Update(OrdenPagoMapper.Map(OrdenPago));
            return OrdenPagoMapper.Map(ResultadoEntity);
        }
    }
}
