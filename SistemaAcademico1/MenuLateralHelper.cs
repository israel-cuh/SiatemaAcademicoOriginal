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
            if (formulario.Controls.OfType<MenuLateralControl>().Any())
                return;

            formulario.SuspendLayout();

            foreach (Control control in formulario.Controls.Cast<Control>().ToList())
                control.Left += AnchoMenu;

            formulario.ClientSize = new Size(formulario.ClientSize.Width + AnchoMenu, formulario.ClientSize.Height);
            formulario.MinimumSize = new Size(
                Math.Max(formulario.MinimumSize.Width, formulario.ClientSize.Width),
                Math.Max(formulario.MinimumSize.Height, formulario.ClientSize.Height));

            MenuLateralControl menu = new MenuLateralControl
            {
                Name = "menuLateralSistema",
                Dock = DockStyle.Left,
                FormularioActual = formulario,
                OpcionActiva = opcionActiva
            };

            formulario.Controls.Add(menu);
            menu.BringToFront();
            formulario.ResumeLayout(false);
        }
    }
}
