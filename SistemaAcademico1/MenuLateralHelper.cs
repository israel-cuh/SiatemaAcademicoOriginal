using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SistemaAcademico1
{
    internal static class MenuLateralHelper
    {
        private const int AnchoMenu = 270;

        public static void AgregarMenu(Form formulario, string opcionActiva)
        {
            if (formulario.Controls.OfType<Panel>().Any(panel => panel.Name == "panelMenuSistema"))
                return;

            formulario.SuspendLayout();

            foreach (Control control in formulario.Controls.Cast<Control>().ToList())
                control.Left += AnchoMenu;

            formulario.ClientSize = new Size(formulario.ClientSize.Width + AnchoMenu, formulario.ClientSize.Height);
            formulario.MinimumSize = new Size(Math.Max(formulario.MinimumSize.Width, formulario.ClientSize.Width), Math.Max(formulario.MinimumSize.Height, formulario.ClientSize.Height));

            Panel menu = new Panel
            {
                Name = "panelMenuSistema",
                BackColor = Color.FromArgb(6, 16, 45),
                Dock = DockStyle.Left,
                Width = AnchoMenu
            };

            Label logo = CrearLabel("</>", 55, 25, 160, 62, new Font("Consolas", 34F, FontStyle.Bold), Color.FromArgb(55, 116, 255), ContentAlignment.MiddleCenter);
            Label nombre = CrearLabel("CodeNova", 25, 92, 220, 45, new Font("Segoe UI", 24F, FontStyle.Bold), Color.White, ContentAlignment.MiddleCenter);
            Label subtitulo = CrearLabel("Sistema Académico\nProgramación I", 30, 142, 210, 55, new Font("Segoe UI", 10F), Color.Gainsboro, ContentAlignment.MiddleCenter);

            Button btnInicio = CrearBoton("⌂    Inicio", 225, opcionActiva == "Inicio");
            Button btnVariables = CrearBoton("{ }   Variables", 282, opcionActiva == "Variables");
            Button btnCiclos = CrearBoton("↻    Ciclos", 339, opcionActiva == "Ciclos");
            Button btnJuego = CrearBoton("🎮   Juego", 396, opcionActiva == "Juego");
            Button btnCerrarSesion = CrearBoton("↪    Cerrar sesión", formulario.ClientSize.Height - 88, false);

            btnInicio.Click += (_, _) => AbrirFormulario(formulario, new MenuEstructura(), opcionActiva == "Inicio");
            btnVariables.Click += (_, _) => AbrirFormulario(formulario, new Menuvariables(), opcionActiva == "Variables");
            btnCiclos.Click += (_, _) => AbrirFormulario(formulario, new MenuTemaCiclo(), opcionActiva == "Ciclos");
            btnJuego.Click += (_, _) =>
            {
                using MinijuegoOrdenarCodigo juego = new MinijuegoOrdenarCodigo();
                juego.ShowDialog(formulario);
            };
            btnCerrarSesion.Click += (_, _) =>
            {
                DialogResult respuesta = MessageBox.Show("¿Desea cerrar sesión?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    Login login = new Login();
                    login.Show();
                    formulario.Close();
                }
            };

            menu.Controls.Add(logo);
            menu.Controls.Add(nombre);
            menu.Controls.Add(subtitulo);
            menu.Controls.Add(btnInicio);
            menu.Controls.Add(btnVariables);
            menu.Controls.Add(btnCiclos);
            menu.Controls.Add(btnJuego);
            menu.Controls.Add(btnCerrarSesion);

            formulario.Controls.Add(menu);
            menu.BringToFront();
            formulario.ResumeLayout(false);
        }

        private static Label CrearLabel(string texto, int x, int y, int ancho, int alto, Font fuente, Color color, ContentAlignment alineacion)
        {
            return new Label
            {
                Text = texto,
                Location = new Point(x, y),
                Size = new Size(ancho, alto),
                Font = fuente,
                ForeColor = color,
                BackColor = Color.Transparent,
                TextAlign = alineacion
            };
        }

        private static Button CrearBoton(string texto, int y, bool activo)
        {
            return new Button
            {
                Text = texto,
                Location = new Point(20, y),
                Size = new Size(230, 48),
                BackColor = activo ? Color.FromArgb(18, 38, 111) : Color.Transparent,
                ForeColor = Color.Gainsboro,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 11F),
                Padding = new Padding(20, 0, 0, 0),
                TextAlign = ContentAlignment.MiddleLeft,
                UseVisualStyleBackColor = false
            };
        }

        private static void AbrirFormulario(Form actual, Form siguiente, bool yaEstoyAqui)
        {
            if (yaEstoyAqui)
            {
                siguiente.Dispose();
                return;
            }

            siguiente.StartPosition = FormStartPosition.CenterScreen;
            siguiente.Show();
            actual.Close();
        }
    }
}
