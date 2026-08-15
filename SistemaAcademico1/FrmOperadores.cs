using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaAcademico1
{
    public partial class FrmOperadores : Form
    {
        public FrmOperadores()
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnComprobar_Click(object sender, EventArgs e)
        {
            // Verificar que todas las preguntas estén respondidas
            if ((!rb1Verdadero.Checked && !rb1Falso.Checked) ||
                (!rb2Verdadero.Checked && !rb2Falso.Checked) ||
                (!rb3Verdadero.Checked && !rb3Falso.Checked) ||
                (!rb4Verdadero.Checked && !rb4Falso.Checked) ||
                (!rb5Verdadero.Checked && !rb5Falso.Checked))
            {
                lblResultado.Text = "⚠ Debes responder todas las preguntas.";
                lblResultado.ForeColor = Color.Orange;
                return;
            }

            int correctas = 0;

            if (rb1Verdadero.Checked)
                correctas++;

            if (rb2Verdadero.Checked)
                correctas++;

            if (rb3Verdadero.Checked)
                correctas++;

            if (rb4Falso.Checked)
                correctas++;

            if (rb5Verdadero.Checked)
                correctas++;

            if (correctas == 5)
            {
                lblResultado.Text =
                    "✓ ¡Excelente! 5 de 5 respuestas correctas.";

                lblResultado.ForeColor = Color.LimeGreen;
            }
            else if (correctas >= 3)
            {
                lblResultado.Text =
                    "👍 Buen trabajo. Obtuviste " +
                    correctas + " de 5 respuestas correctas.";

                lblResultado.ForeColor = Color.Orange;
            }
            else
            {
                lblResultado.Text =
                    "Sigue practicando. Obtuviste " +
                    correctas + " de 5 respuestas correctas.";

                lblResultado.ForeColor = Color.OrangeRed;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            FrmCombinacionOperadores siguiente = new FrmCombinacionOperadores();
            siguiente.Show();
            this.Close();
        }
    }
}
