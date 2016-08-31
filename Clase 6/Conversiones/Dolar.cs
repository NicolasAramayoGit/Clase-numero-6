using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversiones
{
    class Dolar
    {

        // Un Dolar esta 15 pesos argentinos.

        public int _cantidad;

        public Dolar(int cantidad)
        {
            this._cantidad = cantidad;
        }

        public static implicit operator Dolar(int cantidad)
        {
            return new Dolar(cantidad);
        }

        public static Dolar operator +(Dolar unDolar, Pesos unPeso)
        {
            return unDolar._cantidad + (unPeso._cantidad / 15);
        }


    }
}
