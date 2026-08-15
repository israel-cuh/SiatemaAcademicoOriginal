using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaAcademico1
{
    public partial class FrmCombinacionOperadores : Form
    {
        public FrmCombinacionOperadores()
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

        private void FrmCombinacionOperadores_Load(object sender, EventArgs e)
        {
            cmbPregunta1.Items.AddRange(new string[] { "Seleccionar", "Verdadero", "Falso" });
            cmbPregunta2.Items.AddRange(new string[] { "Seleccionar", "Verdadero", "Falso" });
            cmbPregunta3.Items.AddRange(new string[] { "Seleccionar", "Verdadero", "Falso" });
            cmbPregunta4.Items.AddRange(new string[] { "Seleccionar", "Verdadero", "Falso" });
            cmbPregunta5.Items.AddRange(new string[] { "Seleccionar", "Verdadero", "Falso" });

            cmbPregunta1.SelectedIndex = 0;
            cmbPregunta2.SelectedIndex = 0;
            cmbPregunta3.SelectedIndex = 0;
            cmbPregunta4.SelectedIndex = 0;
            cmbPregunta5.SelectedIndex = 0;
        }

        private void btnComprobar_Click(object sender, EventArgs e)
        {
            // Verificar que todas las preguntas estén respondidas
            if (cmbPregunta1.SelectedIndex == 0 ||
                cmbPregunta2.SelectedIndex == 0 ||
                cmbPregunta3.SelectedIndex == 0 ||
                cmbPregunta4.SelectedIndex == 0 ||
                cmbPregunta5.SelectedIndex == 0)
            {
                lblResultado.Text = "Debes responder todas las preguntas.";
                lblResultado.ForeColor = Color.Orange;
                return;
            }

            int correctas = 0;

            // Contar respuestas correctas
            if (cmbPregunta1.Text == "Verdadero")
                correctas++;

            if (cmbPregunta2.Text == "Verdadero")
                correctas++;

            if (cmbPregunta3.Text == "Verdadero")
                correctas++;

            if (cmbPregunta4.Text == "Falso")
                correctas++;

            if (cmbPregunta5.Text == "Verdadero")
                correctas++;

            // Colorear las respuestas
            ColorearRespuesta(cmbPregunta1, "Verdadero");
            ColorearRespuesta(cmbPregunta2, "Verdadero");
            ColorearRespuesta(cmbPregunta3, "Verdadero");
            ColorearRespuesta(cmbPregunta4, "Falso");
            ColorearRespuesta(cmbPregunta5, "Verdadero");

            // Mostrar resultado
            lblResultado.Text = "Aciertos: " + correctas + " / 5";

            if (correctas == 5)
            {
                lblResultado.ForeColor = Color.LimeGreen;
            }
            else if (correctas >= 3)
            {
                lblResultado.ForeColor = Color.Orange;
            }
            else
            {
                lblResultado.ForeColor = Color.Red;
            }
        }
        private void ColorearRespuesta(ComboBox combo, string respuestaCorrecta)
        {
            if (combo.Text == respuestaCorrecta)
            {
                combo.BackColor = Color.LightGreen;
            }
            else
            {
                combo.BackColor = Color.LightCoral;
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            FrmOperadores anterior = new FrmOperadores();
            anterior.Show();
            this.Close();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            FrmPrioridadOperadores siguiente = new FrmPrioridadOperadores();
            siguiente.Show();
            this.Close();
        }
    }
}
