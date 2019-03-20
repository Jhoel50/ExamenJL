using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta_2
{
    class Program
    {
        private static  OrderRange  O_orderRange= new OrderRange();
        static void Main(string[] args)
        {
            #region Ejercicio N:2
            Console.WriteLine("Introduzca un rango de texto por ejemplo: [2,1,4,5]");
            String texto;
            bool error = false;
            texto = Console.ReadLine();
            if (texto.Trim().Length <= 0)
            {
                Console.WriteLine("Usted Tiene que ingresar un valor");
                error = true;
            }
            else if (texto.Contains(',') == false)
            {
                Console.WriteLine("Usted Tiene que ingresar un rango correcto");
                error = true;
            }
            else if (texto.Contains('[') == false || texto.Contains(']') == false)
            {
                Console.WriteLine("Ingrese los números dentro de llaves ejemplo: [2,1,4,5] ");
                error = true;
            }
            else
            {
                texto = texto.Replace("[", "");
                texto = texto.Replace("]", "");
                string[] Lista = texto.Split(',');
                List<int> ListaNumeros = new List<int>();

                foreach (var item in Lista)
                {
                    try
                    {
                        ListaNumeros.Add(Convert.ToInt16(item));
                    }
                    catch (Exception)
                    {
                        error = true;
                        Console.WriteLine("El Item " + item + " no es un entero");
                        break;
                    }
                }

                if (error == false)
                    Console.WriteLine(O_orderRange.build(ListaNumeros));
            }
            Console.Read();
            #endregion
        }
    }
}
