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
    public class BancoService: IBancoService
    {
        private readonly IBancoRepository _bancoRepository;
        public BancoService(IBancoRepository bancoRepository)
        {
            _bancoRepository = bancoRepository;
        }
        public async Task<BancoEntity> GetBancos(int Id)
        {
            var entidad =await _bancoRepository.Get(Id);
            return entidad;
        }

        public List<BancoEntity> GetBancosAll()
        {
            var entidad =  _bancoRepository.GetAll();
            return entidad;
        }

        public  Banco AddBanco(Banco Banco)
        {
           var ResultadoEntity=  _bancoRepository.Add(BancoMapper.Map(Banco));
            return BancoMapper.Map(ResultadoEntity);
        }
        public Banco UpdateBanco(Banco Banco)
        {
            var ResultadoEntity = _bancoRepository.Update(BancoMapper.Map(Banco));
            return BancoMapper.Map(ResultadoEntity);
        }
    }
}
