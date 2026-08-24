using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaAcademico1
{
    public partial class estudiante : Form
    {
        public estudiante()
        {
            InitializeComponent();

            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                MenuLateralHelper.AgregarMenu(this, "Inicio");
                ControlesVentanaHelper.Agregar(this, cerrarAplicacion: true);
            }
        }

        private void estudiante_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lbltitulo_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblenunciado_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Click(object sender, EventArgs e)
        {

        }

        private void panelpregunta_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rb4_CheckedChanged(object sender, EventArgs e)
        {
            if (rb4.Checked)
            {
                rb4.ForeColor = Color.Red;
                MessageBox.Show("Respuesta incorrecta", "Inténtalo de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pseudocodigoprof pseudocodigoprof = new pseudocodigoprof();
            pseudocodigoprof.Show();
            Hide();
        }

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Restablecer el color del texto de las opciones
            rb1.ForeColor = Color.White;
            rb2.ForeColor = Color.White;
            rb3.ForeColor = Color.White;
            rb4.ForeColor = Color.White;

            // Verificar si seleccionó la respuesta correcta (rb2 - Pseudocodigo)
            if (rb2.Checked)
            {
                rb2.ForeColor = Color.Green;
                MessageBox.Show("Tu respuesta es correcta", "¡Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Regresar al menú principal
                frmPrincipal menu = new frmPrincipal();
                menu.Show();

                this.Close();
            }
            else
            {
                // Si seleccionó alguna de las opciones incorrectas
                if (rb1.Checked) rb1.ForeColor = Color.Red;
                if (rb3.Checked) rb3.ForeColor = Color.Red;
                if (rb4.Checked) rb4.ForeColor = Color.Red;

                MessageBox.Show("Tu respuesta es incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
