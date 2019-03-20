using Coworking.Api.DataAccess.Contracts.Entities;
using Coworking.Api.DataAccess.Contracts.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Api.DataAccess.Repositories
{
    public class BancoRepository:IBancoRepository
    {

        private static UnitOfWork _unitOfWork;

        public List<BancoEntity> Bancos { get; set; }
        public BancoRepository()
        {
            Bancos = new List<BancoEntity>();
        }

        public BancoEntity Add(BancoEntity entity)
        {

            _unitOfWork = UnitOfWork.GetInstance;
            var result_ = _unitOfWork.BancoRepository.Bancos.ToList();
            _unitOfWork.BancoRepository.Bancos.Add(entity);
            //Insertar Banco
            return entity;
        }

        public BancoEntity Update(BancoEntity entity)
        {
            _unitOfWork = UnitOfWork.GetInstance;
            var result = _unitOfWork.BancoRepository.Bancos.Where(e => e.Id == entity.Id).FirstOrDefault();
            result = entity;
            return result;
        }

        public async Task<BancoEntity> Get(int Identity)
        {
            _unitOfWork = UnitOfWork.GetInstance;
            var result = _unitOfWork.BancoRepository.Bancos.Where(e=>e.Id==Identity).FirstOrDefault();
            return result;
        }
 
        public async Task DeleteAsync(int Identity)
        {
            //Insertar Banco
            //return null;
        }

        public List<BancoEntity> GetAll()
        {
            _unitOfWork = UnitOfWork.GetInstance;
            var result_ = _unitOfWork.BancoRepository.Bancos.ToList();
            return result_;
        }

        public Task<BancoEntity> Update(int id, BancoEntity element)
        {
            throw new NotImplementedException();
        }

    }
}
