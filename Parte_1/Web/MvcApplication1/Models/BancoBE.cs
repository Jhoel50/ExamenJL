using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcApplication1.Models
{
   public  class BancoBE
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public DateTime fechaRegistro { get; set; }
        public SucursalesBE oSucursalesBE { get; set; }
    }
}
