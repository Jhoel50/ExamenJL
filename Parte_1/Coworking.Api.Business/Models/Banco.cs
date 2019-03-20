﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Coworking.Api.Business.Models
{
   public class Banco
    {
        public Banco()
        {
            Id = 0;
            Nombre = string.Empty;
            Direccion = string.Empty;
            FechaRegistro = DateTime.Now;
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
