using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaAcademico1
{
    public partial class MenuLateralControl : UserControl
    {
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Form? FormularioActual { get; set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string OpcionActiva { get; set; } = "Inicio";

        public MenuLateralControl()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            MarcarOpcionActiva();
        }

        private void MarcarOpcionActiva()
        {
            Color activo = Color.FromArgb(13, 22, 97);
            Color normal = Color.Transparent;

            btnInicio.BackColor = OpcionActiva == "Inicio" ? activo : normal;
            button1.BackColor = OpcionActiva == "Algoritmo" ? activo : normal;
            btnVariables.BackColor = OpcionActiva == "Variables" ? activo : normal;
            button2.BackColor = OpcionActiva == "Condicionales" ? activo : normal;
            btnCiclos.BackColor = OpcionActiva == "Ciclos" ? activo : normal;
            btnJuego.BackColor = OpcionActiva == "Juego" ? activo : normal;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new MenuEstructura(), "Inicio");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmPrincipal(), "Algoritmo");
        }

        private void btnVariables_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Menuvariables(), "Variables");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new MenuPrinciDiagram(), "Diagramas de flujo");
        }

        private void btnCiclos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new MenuTemaCiclo(), "Ciclos");
        }

        private void btnJuego_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new MenuJuegos(), "Juego");
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
                (FormularioActual ?? FindForm())?.Close();
            }
        }

        private void MostrarEnPreparacion(string tema)
        {
            MessageBox.Show(
                $"La sección de {tema} todavía está en preparación.",
                "CodeNova",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void AbrirFormulario(Form siguiente, string opcionNombre)
        {
            bool yaEstoyAqui = OpcionActiva == opcionNombre;

            if (yaEstoyAqui)
            {
                siguiente.Dispose();
                return;
            }

            // Si ya hay una instancia abierta del mismo tipo, reutilizarla
            Type tipo = siguiente.GetType();
            foreach (Form abierto in Application.OpenForms)
            {
                if (abierto.GetType() == tipo)
                {
                    abierto.StartPosition = FormStartPosition.CenterScreen;
                    abierto.Show();
                    abierto.BringToFront();
                    siguiente.Dispose();
                    // Ocultar el formulario actual en lugar de cerrarlo para evitar que la aplicación termine
                    (FormularioActual ?? FindForm())?.Hide();
                    return;
                }
            }

            // Asegurar que el formulario siguiente también tenga el menú lateral
            try
            {
                MenuLateralHelper.AgregarMenu(siguiente, opcionNombre);
            }
            catch
            {
                // Si falla por cualquier motivo, continuar sin detener la navegación
            }

            siguiente.StartPosition = FormStartPosition.CenterScreen;
            siguiente.Show();
            // Ocultar el formulario actual en lugar de cerrarlo para mantener la aplicación activa
            (FormularioActual ?? FindForm())?.Hide();
        }

        private void MenuLateralControl_Load(object sender, EventArgs e)
        {

        }

        private void lblLogo_Click(object sender, EventArgs e)
        {

        }
    }
}
