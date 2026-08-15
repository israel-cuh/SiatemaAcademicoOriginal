using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaAcademico1
{
    public partial class FrmUsoCondiciones : Form
    {
        public FrmUsoCondiciones()
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

        private void FrmUsoCondiciones_Load(object sender, EventArgs e)
        {
            cmbPregunta1.Items.AddRange(new string[] { "&&", "||", "!" });
            cmbPregunta2.Items.AddRange(new string[] { "&&", "||", "!" });
            cmbPregunta3.Items.AddRange(new string[] { "&&", "||", "!" });
            cmbPregunta4.Items.AddRange(new string[] { "&&", "||", "!" });
            cmbPregunta5.Items.AddRange(new string[] { "&&", "||", "!" });

            cmbPregunta1.SelectedIndex = -1;
            cmbPregunta2.SelectedIndex = -1;
            cmbPregunta3.SelectedIndex = -1;
            cmbPregunta4.SelectedIndex = -1;
            cmbPregunta5.SelectedIndex = -1;
        }

        private void btnComprobar_Click(object sender, EventArgs e)
        {
            // Verificar que todas las preguntas estén respondidas
            if (cmbPregunta1.SelectedIndex == -1 ||
                cmbPregunta2.SelectedIndex == -1 ||
                cmbPregunta3.SelectedIndex == -1 ||
                cmbPregunta4.SelectedIndex == -1 ||
                cmbPregunta5.SelectedIndex == -1)
            {
                lblResultado.Text = "Completa todas las respuestas antes de comprobar.";
                lblResultado.ForeColor = Color.Orange;
                return;
            }

            int correctas = 0;

            // Pregunta 1
            if (cmbPregunta1.Text == "&&")
                correctas++;

            // Pregunta 2
            if (cmbPregunta2.Text == "||")
                correctas++;

            // Pregunta 3
            if (cmbPregunta3.Text == "!")
                correctas++;

            // Pregunta 4
            if (cmbPregunta4.Text == "&&")
                correctas++;

            // Pregunta 5
            if (cmbPregunta5.Text == "!")
                correctas++;

            // Mostrar mensaje según los aciertos
            if (correctas == 5)
            {
                lblResultado.Text = "¡Excelente! Dominaste el tema.";
                lblResultado.ForeColor = Color.LimeGreen;
            }
            else if (correctas == 4)
            {
                lblResultado.Text = "¡Muy bien! Casi perfecto.";
                lblResultado.ForeColor = Color.LimeGreen;
            }
            else if (correctas == 3)
            {
                lblResultado.Text = "¡Buen trabajo! Sigue practicando.";
                lblResultado.ForeColor = Color.Orange;
            }
            else if (correctas >= 1)
            {
                lblResultado.Text = "Sigue practicando, ¡tú puedes!";
                lblResultado.ForeColor = Color.Orange;
            }
            else
            {
                lblResultado.Text = "Repasa un poco e inténtalo nuevamente.";
                lblResultado.ForeColor = Color.Red;
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            FrmPrioridadOperadores anterior = new FrmPrioridadOperadores();
            anterior.Show();
            this.Close();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            FrmOperadoresCompletado completado = new FrmOperadoresCompletado();
            completado.Show();
            this.Close();
        }
    }
}
