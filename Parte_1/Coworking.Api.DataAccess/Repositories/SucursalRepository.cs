using Coworking.Api.DataAccess.Contracts.Entities;
using Coworking.Api.DataAccess.Contracts.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Coworking.Api.DataAccess.Repositories
{
  public  class SucursalRepository: ISucursalRepository
    {

        private static UnitOfWork _unitOfWork;

        public List<SucursalEntity> Sucursal { get; set; }
        public SucursalRepository()
        {
            Sucursal = new List<SucursalEntity>();
        }

        public SucursalEntity Add(SucursalEntity entity)
        {

            _unitOfWork = UnitOfWork.GetInstance;
            var result_ = _unitOfWork.SucursalRepository.Sucursal.ToList();
            _unitOfWork.SucursalRepository.Sucursal.Add(entity);
            //Insertar Banco
            return entity;
        }

        public SucursalEntity Update(SucursalEntity entity)
        {
            _unitOfWork = UnitOfWork.GetInstance;
            var result = _unitOfWork.SucursalRepository.Sucursal.Where(e => e.Id == entity.Id).FirstOrDefault();
            result = entity;
            return result;
        }

        public async Task<SucursalEntity> Get(int Identity)
        {
            _unitOfWork = UnitOfWork.GetInstance;
            var result = _unitOfWork.SucursalRepository.Sucursal.Where(e => e.Id == Identity).FirstOrDefault();
            return result;
        }

        public async Task DeleteAsync(int Identity)
        {
            //Insertar Banco
            //return null;
        }

        public List<SucursalEntity> GetAll()
        {
            _unitOfWork = UnitOfWork.GetInstance;
            var result_ = _unitOfWork.SucursalRepository.Sucursal.ToList();
            return result_;
        }

        public Task<SucursalEntity> Update(int id, SucursalEntity element)
        {
            throw new NotImplementedException();
        }
    }
}
