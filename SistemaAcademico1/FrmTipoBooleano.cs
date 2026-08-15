using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaAcademico1
{
    public partial class FrmTipoBooleano : Form
    {
        public FrmTipoBooleano()
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
            if ((!rdbP1True.Checked && !rdbP1False.Checked) ||
        (!rdbP2True.Checked && !rdbP2False.Checked) ||
        (!rdbP3True.Checked && !rdbP3False.Checked) ||
        (!rdbP4True.Checked && !rdbP4False.Checked))
            {
                lblResultado.Text = "⚠ Debes responder todas las preguntas.";
                lblResultado.ForeColor = Color.Orange;
                return;
            }

            int correctas = 0;

            if (rdbP1True.Checked)
                correctas++;

            if (rdbP2True.Checked)
                correctas++;

            if (rdbP3True.Checked)
                correctas++;

            if (rdbP4False.Checked)
                correctas++;

            if (correctas == 4)
            {
                lblResultado.Text =
                    "✓ ¡Excelente!\nObtuviste 4 de 4 respuestas correctas.";

                lblResultado.ForeColor = Color.LimeGreen;
            }
            else if (correctas >= 2)
            {
                lblResultado.Text =
                    "👍 Buen trabajo.\nObtuviste " + correctas +
                    " de 4 respuestas correctas.";

                lblResultado.ForeColor = Color.Orange;
            }
            else
            {
                lblResultado.Text =
                    "📘 Sigue practicando.\nObtuviste " + correctas +
                    " de 4 respuestas correctas.";

                lblResultado.ForeColor = Color.OrangeRed;
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            FrmTiposTexto frm = new FrmTiposTexto();
            frm.Show();
            this.Hide();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            FrmTiposDatosCompletado frm = new FrmTiposDatosCompletado();
            frm.Show();
            this.Hide();
        }
    }
}
