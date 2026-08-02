using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaAcademico1
{
    public partial class FrmAsignacionVariables : Form
    {
        public FrmAsignacionVariables()
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

        private void btnComprobar_Click(object sender, EventArgs e)
        {
            int correctas = 0;

            txtEdad.BackColor = Color.White;
            txtNombre.BackColor = Color.White;
            txtActivo.BackColor = Color.White;


            // INT
            if (int.TryParse(txtEdad.Text.Trim(), out int edad))
            {
                txtEdad.BackColor = Color.LightGreen;
                correctas++;
            }
            else
            {
                txtEdad.BackColor = Color.LightCoral;
            }


            // STRING
            string nombre = txtNombre.Text.Trim();

            if (nombre.StartsWith("\"") && nombre.EndsWith("\""))
            {
                txtNombre.BackColor = Color.LightGreen;
                correctas++;
            }
            else
            {
                txtNombre.BackColor = Color.LightCoral;
            }


            // BOOL
            if (bool.TryParse(txtActivo.Text.Trim(), out bool activo))
            {
                txtActivo.BackColor = Color.LightGreen;
                correctas++;
            }
            else
            {
                txtActivo.BackColor = Color.LightCoral;
            }


            lblResultado.Visible = true;

            if (correctas == 3)
            {
                lblResultado.Text = "✔ Correcto, todas las asignaciones son válidas";
            }
            else
            {
                lblResultado.Text = "✘ Hay valores incorrectos (" + correctas + "/3 correctos)";
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            FrmDeclaracionVariables frm = new FrmDeclaracionVariables();
            frm.Show();
            this.Hide();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            FrmReglasVariables frm = new FrmReglasVariables();
            frm.Show();
            this.Hide();
        }
    }
}
