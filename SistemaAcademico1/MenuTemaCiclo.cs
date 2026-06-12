using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaAcademico1
{
    public partial class MenuTemaCiclo : Form
    {
        public object Items { get; private set; }

        public MenuTemaCiclo()
        {
            InitializeComponent();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            {
                txtSalida.Clear();

                int i = 1;

                while (i <= 5)
                {
                    txtSalida.AppendText(i.ToString() + Environment.NewLine);
                    i++;
                }
            }
        }

        private void txtSalida_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuEstructura ventana = new MenuEstructura();
            ventana.Show();
            this.Hide();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtSalida.Clear();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            txtCodigo.ReadOnly = true;
            txtCodigo.TabStop = false;
        }

        private void richTextBox2Explicacion_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = true;
            richTextBox1.TabStop = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
