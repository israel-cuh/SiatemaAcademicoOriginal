using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaAcademico1
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panelcontenido_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelIRALMODULO_Click(object sender, EventArgs e)
        {

        }

        private void buttoniraprofesor_Click(object sender, EventArgs e)
        {
            MODULODEPROFESOR profesor = new MODULODEPROFESOR();
            profesor.Show();
        }
    }
}