using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coworking.Api.Aplication.Contracts.Services;
using Coworking.Api.DataAccess.Mappers;
using Coworking.Api.DataAccess.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web_Api.Mappers;
using Web_Api.ViewModels;

namespace Web_Api.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class BancoController : ControllerBase
    {
        private readonly IBancoService _bancoService;
        public BancoController(IBancoService BancoService)
        {
            _bancoService = BancoService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get (int id)
        {
            
           var Resultado= await _bancoService.GetBancos(id);
            return Ok(Resultado);
        }
        [HttpGet]
        public IActionResult GetAll()
        {

            var Resultado = _bancoService.GetBancosAll();
            return Ok(Resultado);
        }

        //[Route("v2/Banco")]
        [HttpPost]
        public  IActionResult AddBanco([FromBody] BancoModel Banco)
        {
            var resul = _bancoService.AddBanco(BancoMappers.Map(Banco));

            var Resultado = _bancoService.GetBancosAll();
            return Ok(Resultado);
        }

        [HttpPut]
        public IActionResult UpdateBanco([FromBody] BancoModel Banco)
        {
            var resul = _bancoService.UpdateBanco(BancoMappers.Map(Banco));

           return Ok(resul);
        }

    }
}