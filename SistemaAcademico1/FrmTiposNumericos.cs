using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaAcademico1
{
    public partial class FrmTiposNumericos : Form
    {
        public FrmTiposNumericos()
        {
            InitializeComponent();
        }

        private void lblRegresar_Click(object sender, EventArgs e)
        {
            pnlRegresar_Click(sender, e);
        }

        private void pnlRegresar_Click(object sender, EventArgs e)
        {
            Menuvariables menu = new Menuvariables();
            menu.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnComprobar_Click(object sender, EventArgs e)
        {
            if (cmbEdad.SelectedIndex == -1 ||
       cmbPromedio.SelectedIndex == -1 ||
       cmbAltura.SelectedIndex == -1 ||
       cmbPrecio.SelectedIndex == -1)
            {
                lblResultado.Text = "⚠ Completa todos los ejercicios.";
                lblResultado.ForeColor = Color.Orange;
                return;
            }

            int correctas = 0;

            // Restaurar colores
            cmbEdad.BackColor = Color.White;
            cmbPromedio.BackColor = Color.White;
            cmbAltura.BackColor = Color.White;
            cmbPrecio.BackColor = Color.White;

            // 1. edad = 18 → int
            if (cmbEdad.Text == "int")
            {
                cmbEdad.BackColor = Color.LightGreen;
                correctas++;
            }
            else
            {
                cmbEdad.BackColor = Color.LightCoral;
            }

            // 2. promedio = 9.5 → double
            if (cmbPromedio.Text == "double")
            {
                cmbPromedio.BackColor = Color.LightGreen;
                correctas++;
            }
            else
            {
                cmbPromedio.BackColor = Color.LightCoral;
            }

            // 3. altura = 1.68 → double
            if (cmbAltura.Text == "double")
            {
                cmbAltura.BackColor = Color.LightGreen;
                correctas++;
            }
            else
            {
                cmbAltura.BackColor = Color.LightCoral;
            }

            // 4. precio = 12.50 → double
            if (cmbPrecio.Text == "double")
            {
                cmbPrecio.BackColor = Color.LightGreen;
                correctas++;
            }
            else
            {
                cmbPrecio.BackColor = Color.LightCoral;
            }

            // Resultado
            if (correctas == 4)
            {
                lblResultado.Text = "✓ ¡Excelente! 4/4 correctas";
                lblResultado.ForeColor = Color.LimeGreen;
            }
            else
            {
                lblResultado.Text = "Tienes " + correctas + "/4 respuestas correctas";
                lblResultado.ForeColor = Color.Orange;
            }
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            FrmTiposDatos frm = new FrmTiposDatos();
            frm.Show();
            this.Hide();
        }

        private void cmbPromedio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            FrmTiposTexto frm = new FrmTiposTexto();
            frm.Show();
            this.Close();
        }
    }
}
