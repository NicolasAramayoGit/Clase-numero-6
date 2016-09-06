using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerreteFacturacion
{
    public static class Operaciones
    {

        static Operaciones()
        { }

        public static int Sumar(int valor1, int valor2)
        {
            return valor1 + valor2;
        }

        public static int Sumar(int valor1, int valor2, int valor3)
        {
            return valor1 + valor2 + valor3;
        }

        public static float Promedio(int valorTotal, int cantidadTotal)
        {
            return (float)(valorTotal / cantidadTotal);
        }

    }
}
