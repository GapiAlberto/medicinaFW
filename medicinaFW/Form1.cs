using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medicinaFW
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void htmlLabel1_Click(object sender, EventArgs e)
        {
        }
        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            double precio = double.Parse(metroTextBoxPrecio.Text);
            bool esMedicina = metroCheckBox1.Checked;
            double IVA = 0.0;

            if (!esMedicina)
            {
                IVA = precio * 0.16;
            }

            double precioTotal = precio + IVA;

            htmlLabelPrecioTotal.Text = $"El precio total a pagar es de: {precioTotal:C}";
        }
    }
}
