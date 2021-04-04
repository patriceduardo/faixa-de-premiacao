using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaixaDePremiacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal compras;
            compras = Convert.ToDecimal(txtTotalCompras.Text);
            string resultado = ""; 
            if (compras < 499)
            {
                resultado="pobre";
            }
              
                
              else if (compras > 499 && compras < 2000)
            {
                resultado = "prata";

            }
            else if (compras >= 2000 && compras < 5000)
            {
                resultado = "prata";
            }
            else if (compras >= 5000 && compras < 8000)
            {
                resultado="ouro";
            }
            else if (compras >= 8000)
            {
               resultado="Super bonus";
            }

            MessageBox.Show(resultado);

        }
    }
}
