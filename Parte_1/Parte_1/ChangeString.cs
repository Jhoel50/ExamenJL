using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte_1
{
    public class ChangeString
    {
        public string build(string cadena)
        {
            String strResultdo = string.Empty;
            foreach (char caracter in cadena)
            {
                if(caracter=='Z')
                {
                    strResultdo = strResultdo + "A";
                }
                else if(caracter=='z')
                {
                    strResultdo = strResultdo + "a";
                }
               else if(char.IsLetter(caracter))
                {
                    strResultdo= strResultdo + (char)(Encoding.ASCII.GetBytes(caracter.ToString())[0] + 1);
                }
                else
                {
                    strResultdo = strResultdo + caracter;
                }
            }
            return strResultdo;
        }
    }
}
