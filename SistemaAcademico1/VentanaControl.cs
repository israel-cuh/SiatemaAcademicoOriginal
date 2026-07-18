using System;
using System.Windows.Forms;

namespace SistemaAcademico1
{
    public partial class VentanaControl : UserControl
    {
        public Form? FormularioActual { get; set; }
        public bool CerrarAplicacion { get; set; } = true;

        public VentanaControl()
        {
            InitializeComponent();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            Form? formulario = FormularioActual ?? FindForm();
            if (formulario != null)
                formulario.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            Form? formulario = FormularioActual ?? FindForm();
            if (formulario == null)
                return;

            if (formulario.WindowState == FormWindowState.Maximized)
            {
                formulario.WindowState = FormWindowState.Normal;
                btnMaximizar.Text = "□";
            }
            else
            {
                formulario.MinimumSize = System.Drawing.Size.Empty;
                formulario.WindowState = FormWindowState.Maximized;
                btnMaximizar.Text = "❐";
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Form? formulario = FormularioActual ?? FindForm();

            if (CerrarAplicacion)
                Application.Exit();
            else
                formulario?.Close();
        }
    }
}
