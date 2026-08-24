using System;
using System.Windows.Forms;

namespace SistemaAcademico1
{
    public partial class DashboardPrincipal : Form
    {
        private readonly string rolUsuario;

        public DashboardPrincipal() : this("Docente")
        {
        }

        public DashboardPrincipal(string rol)
        {
            rolUsuario = string.IsNullOrWhiteSpace(rol) ? "Docente" : rol;
            InitializeComponent();

            if (System.ComponentModel.LicenseManager.UsageMode != System.ComponentModel.LicenseUsageMode.Designtime)
            {
                ControlesVentanaHelper.Agregar(this, cerrarAplicacion: true);
            }

            ConfigurarDatos();
        }

        private void ConfigurarDatos()
        {
            lblUsuario.Text = rolUsuario.Equals("Estudiante", StringComparison.OrdinalIgnoreCase)
                ? "Vista estudiante"
                : "Vista administrador";
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            CodeNovaDashboard codeNovaDashboard = new CodeNovaDashboard();
            codeNovaDashboard.Show();
            Close();
        }
    }
}
