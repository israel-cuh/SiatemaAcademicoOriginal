using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace SistemaAcademico1
{
    public partial class VentanaControl : UserControl
    {
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Form? FormularioActual { get; set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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
