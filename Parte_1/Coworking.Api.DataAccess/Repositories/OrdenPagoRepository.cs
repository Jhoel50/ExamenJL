using Coworking.Api.DataAccess.Contracts.Entities;
using Coworking.Api.DataAccess.Contracts.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Api.DataAccess.Repositories
{
    public class OrdenPagoRepository: IOrdenPagoRepository
    {
        
        private static UnitOfWork _unitOfWork;

        public List<OrdenPagoEntity> OrdenPago { get; set; }
        public OrdenPagoRepository()
        {
            OrdenPago = new List<OrdenPagoEntity>();
        }

        public OrdenPagoEntity Add(OrdenPagoEntity entity)
        {

            _unitOfWork = UnitOfWork.GetInstance;
            var result_ = _unitOfWork.OrdenPagoRepository.OrdenPago.ToList();
            _unitOfWork.OrdenPagoRepository.OrdenPago.Add(entity);
            //Insertar Banco
            return entity;
        }

        public OrdenPagoEntity Update(OrdenPagoEntity entity)
        {
            _unitOfWork = UnitOfWork.GetInstance;
            var result = _unitOfWork.OrdenPagoRepository.OrdenPago.Where(e => e.Id == entity.Id).FirstOrDefault();
            result = entity;
            return result;
        }

        public async Task<OrdenPagoEntity> Get(int Identity)
        {
            _unitOfWork = UnitOfWork.GetInstance;
            var result = _unitOfWork.OrdenPagoRepository.OrdenPago.Where(e => e.Id == Identity).FirstOrDefault();
            return result;
        }

        public async Task DeleteAsync(int Identity)
        {
           
        }

        public List<OrdenPagoEntity> GetAll()
        {
            _unitOfWork = UnitOfWork.GetInstance;
            var result_ = _unitOfWork.OrdenPagoRepository.OrdenPago.ToList();
            return result_;
        }

        public Task<OrdenPagoEntity> Update(int id, OrdenPagoEntity element)
        {
            throw new NotImplementedException();
        }

    }
}
