using System;
using System.Collections.Generic;
using System.Text;

namespace Coworking.Api.DataAccess.Contracts.Entities
{
    public class SucursalEntity
    {
        public SucursalEntity()
        {
            Id = 0;
            Nombre = string.Empty;
            Direccion = string.Empty;
            FechaRegistro = DateTime.Now;
            Banco = new BancoEntity();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaRegistro { get; set; }
        public BancoEntity Banco { get; set; }
      //  public List<BancoEntity> Bancos { get; set; }
    }
}
