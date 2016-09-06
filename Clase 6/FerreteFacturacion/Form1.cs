using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FerreteFacturacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            int resultado;

            int numero1 = int.Parse(this.txtNumero1.Text);
            int numero2 = int.Parse(this.txtNumero2.Text);
            int numero3 = int.Parse(this.txtNumero3.Text);

            resultado = numero1 + numero2 + numero3;
            MessageBox.Show(resultado.ToString());
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            int resultado;

            int numero1 = int.Parse(this.txtNumero1.Text);
            int numero2 = int.Parse(this.txtNumero2.Text);
            int numero3 = int.Parse(this.txtNumero3.Text);

            resultado = Operaciones.Sumar(numero1, numero2, numero3);
            float promedio = Operaciones.Promedio(resultado, 3);

            // MessageBox.Show((Operaciones.Promedio(resultado, 3)).ToString());

            MessageBox.Show(Facilitador.MostrarPromedio(promedio));
        }
    }
}
