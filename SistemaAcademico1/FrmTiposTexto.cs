using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaAcademico1
{
    public partial class FrmTiposTexto : Form
    {
        public FrmTiposTexto()
        {
            InitializeComponent();
            CargarCombos();

        }
        private void CargarCombos()
        {
            ComboBox[] combos =
            {
        cmbHola,
        cmbH,
        cmb2026,
        cmb7,
        cmbA
    };

            foreach (ComboBox combo in combos)
            {
                combo.Items.Clear();

                combo.Items.Add("Seleccionar...");
                combo.Items.Add("string");
                combo.Items.Add("char");

                combo.DropDownStyle = ComboBoxStyle.DropDownList;
                combo.SelectedIndex = 0;
            }
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

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void btnComprobar_Click(object sender, EventArgs e)
        {
            // Verificar que haya respondido las 5 preguntas
            if (cmbHola.SelectedIndex == 0 ||
                cmbH.SelectedIndex == 0 ||
                cmb2026.SelectedIndex == 0 ||
                cmb7.SelectedIndex == 0 ||
                cmbA.SelectedIndex == 0)
            {
                lblResultado.Text = "⚠ Debes completar todas las respuestas.";
                lblResultado.ForeColor = Color.Orange;
                return;
            }

            int correctas = 0;

            // "Hola" → string
            if (cmbHola.Text == "string")
                correctas++;

            // 'H' → char
            if (cmbH.Text == "char")
                correctas++;

            // "2026" → string
            if (cmb2026.Text == "string")
                correctas++;

            // '7' → char
            if (cmb7.Text == "char")
                correctas++;

            // "A" → string
            if (cmbA.Text == "string")
                correctas++;


            // Mostrar resultado
            if (correctas == 5)
            {
                lblResultado.Text =
                    "✓ ¡Excelente!\nObtuviste 5 de 5 respuestas correctas.";

                lblResultado.ForeColor = Color.LimeGreen;
            }
            else if (correctas >= 3)
            {
                lblResultado.Text =
                    "👍 Buen trabajo.\nObtuviste " + correctas +
                    " de 5 respuestas correctas.";

                lblResultado.ForeColor = Color.Orange;
            }
            else
            {
                lblResultado.Text =
                    "📘 Sigue practicando.\nObtuviste " + correctas +
                    " de 5 respuestas correctas.";

                lblResultado.ForeColor = Color.OrangeRed;
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            FrmTiposNumericos frm = new FrmTiposNumericos();
            frm.Show();
            this.Hide();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            FrmTipoBooleano frm = new FrmTipoBooleano();
            frm.Show();
            this.Hide();
        }
    }
}
