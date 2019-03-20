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
    public class SucursalController : ControllerBase
    {
        private readonly ISucursalService _SucursalService;
        public SucursalController(ISucursalService SucursalService)
        {
            _SucursalService = SucursalService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {

            var Resultado = await _SucursalService.GetSucursal(id);
            return Ok(Resultado);
        }
        [HttpGet]
        public IActionResult GetAll()
        {

            var Resultado = _SucursalService.GetSucursalAll();
            return Ok(Resultado);
        }

     
        [HttpPost]
        public IActionResult AddOrdenPago([FromBody] SucursalModel Sucursal)
        {
            var resul = _SucursalService.AddSucursal(SucursalMappers.Map(Sucursal));

            var Resultado = _SucursalService.GetSucursalAll();
            return Ok(Resultado);
        }

        [HttpPut]
        public IActionResult UpdateOrdenPago([FromBody] SucursalModel sucursal)
        {
            var resul = _SucursalService.UpdateSucursal(SucursalMappers.Map(sucursal));

            return Ok(resul);
        }
    }
}