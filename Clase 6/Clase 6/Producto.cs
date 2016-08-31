using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_6
{
    class Producto
    {

        public int _cantidad;

        public Producto(int cantidad)
        {
            this._cantidad = cantidad;
        }

        //SOBRECARGA
        public static explicit operator Producto(int cantidad)
        {
            return new Producto(cantidad);
        }

        //SOBRECARGA DE OPERADOR +
        public static int operator +(Producto productoUno, Producto productoDos)
        {
            return productoUno._cantidad + productoDos._cantidad;
        }

    }
}
