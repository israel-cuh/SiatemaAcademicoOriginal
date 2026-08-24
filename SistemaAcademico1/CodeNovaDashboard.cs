using System.Windows.Forms;

namespace SistemaAcademico1
{
    public partial class CodeNovaDashboard : Form
    {
        public CodeNovaDashboard()
        {
            InitializeComponent();
            // Asociar evento para abrir el formulario GestorTareas desde el botón Agregar tarea
            ControlesVentanaHelper.Agregar(this, cerrarAplicacion: true);
            try
            {
                this.btnAgregarTarea.Click += (s, e) =>
                {
                    GestorTareas gt = new GestorTareas();
                    gt.Show();
                };
            }
            catch { }
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
                Close();
            }
        }

        private void btnSeudocodigo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
       "Esta sección está en proceso de desarrollo.",
       "Próximamente",
       MessageBoxButtons.OK,
       MessageBoxIcon.Information
       );
        }

        private void btnVariables_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
     "Esta sección está en proceso de desarrollo.",
     "Próximamente",
     MessageBoxButtons.OK,
     MessageBoxIcon.Information
     );
        }

        private void btnCondicionales_Click(object sender, EventArgs e)
        {
            DashboardPrincipal dashboard = new DashboardPrincipal("Docente");
            dashboard.Show();
            Hide();
        }

        private void btnCiclos_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
     "Esta sección está en proceso de desarrollo.",
     "Próximamente",
     MessageBoxButtons.OK,
     MessageBoxIcon.Information
     );
        }

        private void btnAcceso4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
     "Esta sección está en proceso de desarrollo.",
     "Próximamente",
     MessageBoxButtons.OK,
     MessageBoxIcon.Information
     );
        }

        private void btnAcceso5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
     "Esta sección está en proceso de desarrollo.",
     "Próximamente",
     MessageBoxButtons.OK,
     MessageBoxIcon.Information
     );
        }
    }
}
