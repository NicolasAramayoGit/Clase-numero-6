using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversiones
{
    class Program
    {
        static void Main(string[] args)
        {

            Dolar und;
            Pesos unp;

            und = 1;        // Sobrecarga implicita de Dolar.

            unp = (Pesos)1; // Sobrecarga explicita de Pesos.

            und = und + unp; // Tiene que estar en la clase 'Dolar'.
          //  unp = unp + und; // Tiene que estar en la clase 'Pesos'.


        }
    }
}
