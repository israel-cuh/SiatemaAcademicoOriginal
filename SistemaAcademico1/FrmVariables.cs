using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaAcademico1
{
    public partial class FrmVariables : Form
    {
        public FrmVariables()
        {
            InitializeComponent();

            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                FormBorderStyle = FormBorderStyle.None;
                MenuLateralHelper.AgregarMenu(this, "Variables");
                ControlesVentanaHelper.Agregar(this, cerrarAplicacion: true);
            }
        }

        private void pnlRegresar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlRegresar_Click(object sender, EventArgs e)
        {
            Menuvariables menu = new Menuvariables();
            menu.Show();
            Hide();
        }

        private void lblRegresar_Click(object sender, EventArgs e)
        {
            pnlRegresar_Click(sender, e);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void chkTotalCompra_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnComprobar_Click(object sender, EventArgs e)
        {
            int correctas = 0;

            // Respuestas correctas
            if (chkNombreAlumno.Checked)
                correctas++;

            if (chkTotalCompra.Checked)
                correctas++;

            if (chkEdad.Checked)
                correctas++;

            // Mostrar resultado
            lblResultado.Visible = true;

            if (correctas == 3)
            {
                lblResultado.Text = "✔ ¡Excelente!\n3 de 3 respuestas correctas.";
            }
            else
            {
                lblResultado.Text = $"❌ Obtuviste {correctas} de 3 respuestas correctas.\nInténtalo nuevamente.";
            }
        }

        private void panelPractica_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            FrmDeclaracionVariables frm = new FrmDeclaracionVariables();
            frm.Show();
            this.Hide();
        }
    }
}
