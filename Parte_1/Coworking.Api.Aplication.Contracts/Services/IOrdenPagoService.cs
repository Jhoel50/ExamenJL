using Coworking.Api.Business.Models;
using Coworking.Api.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Api.Aplication.Contracts.Services
{
    public interface IOrdenPagoService
    {
        Task<OrdenPagoEntity> GetOrdenPago(int Id);
        List<OrdenPagoEntity> GetOrdenPagoAll();
        OrdenPago AddOrdenPago(OrdenPago Banco);
        OrdenPago UpdateOrdenPago(OrdenPago Banco);
    }
}
