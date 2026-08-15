using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaAcademico1
{
    public partial class FrmOperadoresCompletado : Form
    {
        public FrmOperadoresCompletado()
        {
            InitializeComponent();
        }

        private void pnlRepasar_Click(object sender, EventArgs e)
        {
            FrmOperadores operadores = new FrmOperadores();
            operadores.Show();
            this.Close();
        }

        private void pnlVolverMenu_Click(object sender, EventArgs e)
        {
            Menuvariables menu = new Menuvariables();
            menu.Show();
            this.Close();
        }
    }
}
