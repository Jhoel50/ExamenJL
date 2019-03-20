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
    [Route("api/[controller]")]
    [ApiController]
    public class OrdenPagoController : ControllerBase
    {
        private readonly IOrdenPagoService _IOrdenPagoService;
        public OrdenPagoController(IOrdenPagoService OrdenPagoService)
        {
            _IOrdenPagoService = OrdenPagoService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {

            var Resultado = await _IOrdenPagoService.GetOrdenPago(id);
            return Ok(Resultado);
        }
        [HttpGet]
        public IActionResult GetAll()
        {

            var Resultado = _IOrdenPagoService.GetOrdenPagoAll();
            return Ok(Resultado);
        }

    
        [HttpPost]
        public IActionResult AddOrdenPago([FromBody] OrdenPagoModel Banco)
        {
            var resul = _IOrdenPagoService.AddOrdenPago(OrdenPagoMappers.Map(Banco));

            var Resultado = _IOrdenPagoService.GetOrdenPagoAll();
            return Ok(Resultado);
        }

        [HttpPut]
        public IActionResult UpdateOrdenPago([FromBody] OrdenPagoModel Banco)
        {
            var resul = _IOrdenPagoService.UpdateOrdenPago(OrdenPagoMappers.Map(Banco));

            return Ok(resul);
        }


    }
}