using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta_3
{
    class Program
    {
        private static MoneyParts O_moneyParts = new MoneyParts();
        static void Main(string[] args)
        {
            decimal num = 0.5m;

            Console.WriteLine("Ingrese monto en soles");
            num = Convert.ToDecimal(Console.ReadLine().ToString());
            Console.WriteLine(O_moneyParts.Build(num));
            Console.Read();
        }
    }
}
