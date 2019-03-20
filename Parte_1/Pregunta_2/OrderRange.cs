using System.Collections.Generic;
using System.Linq;
namespace Pregunta_2
{
    public class OrderRange
    {
        public string build (List<int> Ingreso)
        {
            string resultado = string.Empty;

            List<List<int>> respuesta = new List<List<int>>();
            int Min = Ingreso.Min();
            List<int> Par = new List<int>();
            List<int> Impar = new List<int>();

            foreach (int numero in Ingreso)
            {
                if (numero%2 == 0)
                {
                    Par.Add(numero);
                }
                else
                {
                    Impar.Add(numero);
                }
            }

            respuesta.Add(Par);
            respuesta.Add(Impar);



            List<int> primero = new List<int>();
            List<int> Segundo = new List<int>();

            var min_1= Par.Min();
  
            if (min_1 == Min)
            {
                primero = Par;
                Segundo = Impar;
            }
            else {
                primero = Impar;
                Segundo = Par;
            }

            resultado = resultado + "[";

            foreach(var _item1 in primero)
            {
                resultado = resultado + _item1 + ", ";
            }

            resultado = resultado.Substring(0, resultado.Length - 2) + "]  ";
            resultado = resultado + "[";
            foreach (var _item2 in Segundo)
            {
                resultado = resultado + _item2 + ", ";
            }

            resultado = resultado.Substring(0, resultado.Length - 2) + "]";
            return resultado;
        }
    }
}