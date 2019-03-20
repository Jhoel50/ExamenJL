using Coworking.Api.Business.Models;
using Coworking.Api.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Api.Aplication.Contracts.Services
{
    public interface IBancoService
    {
        Task<BancoEntity> GetBancos(int Id);
        List<BancoEntity> GetBancosAll();
        Banco AddBanco(Banco Banco);
        Banco UpdateBanco(Banco Banco);
    }
}
