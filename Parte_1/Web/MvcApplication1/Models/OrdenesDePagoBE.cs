using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcApplication1.Models
{
   public class OrdenesDePagoBE
    {
        public int ID { get; set; }
        public decimal monto { get; set; }
        public string Moneda { get; set; }  
        public string Estado { get; set; }

    }
}
