using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SistemaAcademico1
{
    internal static class ControlesVentanaHelper
    {
        private const int MargenSuperior = 6;
        private const int MargenDerecho = 10;

        public static void Agregar(Form formulario, bool cerrarAplicacion = true)
        {
            if (formulario.Controls.Find("ventanaControlSistema", true).Any())
                return;

            OcultarBotonesViejos(formulario);

            VentanaControl controlVentana = new VentanaControl
            {
                Name = "ventanaControlSistema",
                FormularioActual = formulario,
                CerrarAplicacion = cerrarAplicacion,
                Anchor = AnchorStyles.Top | AnchorStyles.Right
            };

            formulario.Controls.Add(controlVentana);
            UbicarControl(formulario, controlVentana);
            controlVentana.BringToFront();

            formulario.Resize += (_, _) =>
            {
                UbicarControl(formulario, controlVentana);
                controlVentana.BringToFront();
            };
        }

        private static void UbicarControl(Form formulario, Control controlVentana)
        {
            controlVentana.Location = new Point(
                formulario.ClientSize.Width - controlVentana.Width - MargenDerecho,
                MargenSuperior);
        }

        private static void OcultarBotonesViejos(Form formulario)
        {
            string[] nombres = { "btnMinimizar", "btnCerrar" };

            foreach (string nombre in nombres)
            {
                foreach (Control control in formulario.Controls.Find(nombre, true))
                    control.Visible = false;
            }
        }
    }
}
