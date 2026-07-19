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
    }
}
