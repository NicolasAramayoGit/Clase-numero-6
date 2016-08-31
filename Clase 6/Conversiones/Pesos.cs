using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversiones
{
    class Pesos
    {

        // Un peso argentino seria dividir al peso por 15.

        public int _cantidad;

        public Pesos(int cantidad)
        {
            this._cantidad = cantidad;
        }

        public static explicit operator Pesos(int cantidad)
        {
            return new Pesos(cantidad);
        }

        public static Pesos operator +(Pesos unPeso, Dolar unDolar)
        {
            return new Pesos((unPeso._cantidad * 15)) + unDolar._cantidad;
        }


    }
}
