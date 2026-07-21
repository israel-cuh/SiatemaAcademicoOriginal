using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaAcademico1
{
    public partial class FrmDeclaracionVariables : Form
    {
        public FrmDeclaracionVariables()
        {
            InitializeComponent();
        }

        private void pnlRegresar_Click(object sender, EventArgs e)
        {
            Menuvariables menu = new Menuvariables();
            menu.Show();
            this.Close();
        }

        private void lblRegresar_Click(object sender, EventArgs e)
        {
            pnlRegresar_Click(sender, e);
        }

        private void FrmDeclaracionVariables_Load(object sender, EventArgs e)
        {
            string[] tipos = { "Seleccionar...", "int", "string", "double", "bool", "char" };

            cmbNombre.Items.AddRange(tipos);
            cmbEdad.Items.AddRange(tipos);
            cmbPromedio.Items.AddRange(tipos);
            cmbActivo.Items.AddRange(tipos);
            cmbLetra.Items.AddRange(tipos);

            cmbNombre.SelectedIndex = 0;
            cmbEdad.SelectedIndex = 0;
            cmbPromedio.SelectedIndex = 0;
            cmbActivo.SelectedIndex = 0;
            cmbLetra.SelectedIndex = 0;
        }

        private void btnComprobar_Click(object sender, EventArgs e)
        {
            int correctas = 0;

            if (cmbNombre.Text == "string")
                correctas++;

            if (cmbEdad.Text == "int")
                correctas++;

            if (cmbPromedio.Text == "double")
                correctas++;

            if (cmbActivo.Text == "bool")
                correctas++;

            if (cmbLetra.Text == "char")
                correctas++;

            lblResultado.Visible = true;

            switch (correctas)
            {
                case 5:
                    lblResultado.ForeColor = Color.LimeGreen;
                    lblResultado.Text = "🎉 ¡Felicidades!\nObtuviste 5 de 5 respuestas correctas.\n¡Excelente trabajo!";
                    break;

                case 4:
                    lblResultado.ForeColor = Color.Yellow;
                    lblResultado.Text = "👏 ¡Muy bien!\nObtuviste 4 de 5 respuestas correctas.";
                    break;

                case 3:
                    lblResultado.ForeColor = Color.Orange;
                    lblResultado.Text = "👍 Buen trabajo.\nObtuviste 3 de 5 respuestas correctas.";
                    break;

                case 2:
                    lblResultado.ForeColor = Color.OrangeRed;
                    lblResultado.Text = "📚 Obtuviste 2 de 5 respuestas correctas.\nSigue practicando.";
                    break;

                case 1:
                    lblResultado.ForeColor = Color.Red;
                    lblResultado.Text = "📚 Obtuviste 1 de 5 respuestas correctas.\nRepasa la lección.";
                    break;

                default:
                    lblResultado.ForeColor = Color.Red;
                    lblResultado.Text = "📚 No acertaste ninguna respuesta.\nVuelve a intentarlo.";
                    break;
            }

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            FrmVariables frm = new FrmVariables();
            frm.Show();
            this.Hide();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            FrmAsignacionVariables frm = new FrmAsignacionVariables();
            frm.Show();
            this.Hide();
        }
    }
}
