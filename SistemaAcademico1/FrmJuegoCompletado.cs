using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaAcademico1
{
    public partial class FrmJuegoCompletado : Form
    {
        public FrmJuegoCompletado()
        {
            InitializeComponent();
        }

        private void pnlVolverMenu_Click(object sender, EventArgs e)
        {
            Menuvariables menu = new Menuvariables();
            menu.Show();
            this.Close();
        }
    }
}
