using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaAcademico1
{
    public partial class MenuEstudiante : Form
    {
        public MenuEstudiante()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
        "¿Desea cerrar sesión?",
        "Confirmar",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();
                this.Close();
            }
        }

        private void btnTema_Click(object sender, EventArgs e)
        {
            MenuTemaCiclo menuTema = new MenuTemaCiclo();
            menuTema.Show();
        }
    }
}
