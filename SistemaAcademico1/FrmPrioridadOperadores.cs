using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaAcademico1
{
    public partial class FrmPrioridadOperadores : Form
    {
        public FrmPrioridadOperadores()
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

        private void FrmPrioridadOperadores_Load(object sender, EventArgs e)
        {
            cmbParentesis.Items.AddRange(new string[] { "1", "2", "3", "4" });
            cmbNot.Items.AddRange(new string[] { "1", "2", "3", "4" });
            cmbAnd.Items.AddRange(new string[] { "1", "2", "3", "4" });
            cmbOr.Items.AddRange(new string[] { "1", "2", "3", "4" });

            cmbParentesis.SelectedIndex = -1;
            cmbNot.SelectedIndex = -1;
            cmbAnd.SelectedIndex = -1;
            cmbOr.SelectedIndex = -1;
        }

        private void btnComprobar_Click(object sender, EventArgs e)
        {
            if (cmbParentesis.SelectedIndex == -1 ||
       cmbNot.SelectedIndex == -1 ||
       cmbAnd.SelectedIndex == -1 ||
       cmbOr.SelectedIndex == -1)
            {
                lblResultado.Text = "Debes completar todas las prioridades.";
                lblResultado.ForeColor = Color.Orange;
                return;
            }

            int correctas = 0;

            if (cmbParentesis.Text == "1")
                correctas++;

            if (cmbNot.Text == "2")
                correctas++;

            if (cmbAnd.Text == "3")
                correctas++;

            if (cmbOr.Text == "4")
                correctas++;

            lblResultado.Text = "Resultado: " + correctas + " / 4";

            if (correctas == 4)
                lblResultado.ForeColor = Color.LimeGreen;
            else if (correctas >= 2)
                lblResultado.ForeColor = Color.Orange;
            else
                lblResultado.ForeColor = Color.Red;
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            FrmCombinacionOperadores anterior = new FrmCombinacionOperadores();
            anterior.Show();
            this.Close();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            FrmUsoCondiciones siguiente = new FrmUsoCondiciones();
            siguiente.Show();
            this.Close();
        }
    }
}
