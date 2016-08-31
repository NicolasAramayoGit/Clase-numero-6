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
            int numero1 = int.Parse(this.txtNumero1.ToString());
            int numero2 = int.Parse(this.txtNumero2.ToString());
            int numero3 = int.Parse(this.txtNumero3.ToString());

            resultado = numero1 + numero2 + numero3;
            MessageBox.Show(resultado.ToString());
        }
    }
}
