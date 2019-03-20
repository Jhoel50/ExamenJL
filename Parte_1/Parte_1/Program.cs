using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte_1
{
	class Program
	{
        private static ChangeString obConvertString = new ChangeString();
        static void Main(string[] args)
		{
            #region Ejercicio N:1
            String texto;
            bool error = false;
            Console.WriteLine("Ingrese el texto");
            texto = Console.ReadLine().ToString();
            if (texto.Trim().Length <= 0)
            {
                Console.WriteLine("Usted Tiene que ingresar un valor");
                error = true;
            }
            else
            {
                Console.WriteLine("Resultado: " + obConvertString.build(texto));
            }
            Console.Read();
            #endregion
        }
    }
}
