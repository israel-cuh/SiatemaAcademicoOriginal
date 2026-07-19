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
        public Form? FormularioActual { get; private set; }

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

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
        private void buttonvolveralinicio_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Desea cerrar volver ?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                MenuEstructura menuEstructura = new MenuEstructura();
                menuEstructura.Show();
                Hide();

            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
