using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta_3
{
    public class MoneyParts
    {
        static decimal[] valores = new decimal[] { 0.05m, 0.1m, 0.2m, 0.5m, 1, 2, 5, 10, 20, 50, 100, 200 };
        public  string Build(decimal ingreso)
        {
            string resultado =string.Empty;
            foreach (var valor in valores)
            {
                if (ingreso >= valor)
                {
                    if (ingreso % valor == 0)
                    {
                        var cantidad = ingreso / valor;
                       
                            resultado = resultado + "[";
                            for (int i = 0; i < Convert.ToInt32(cantidad); i++)
                            {
                                resultado = resultado + valor + ",";
                            }
                            resultado = resultado.Substring(0, resultado.Length - 1) + "]";
                       
                    }
                }
            }
   
            return resultado ;
        }
    }
}
