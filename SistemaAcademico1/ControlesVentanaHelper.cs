using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SistemaAcademico1
{
    internal static class ControlesVentanaHelper
    {
        private const int AnchoBoton = 36;
        private const int AltoBoton = 28;
        private const int Separacion = 5;
        private const int MargenSuperior = 6;
        private const int MargenDerecho = 10;

        private static readonly Dictionary<Form, Size> TamanoMinimoOriginal = new();

        public static void Agregar(Form formulario, bool cerrarAplicacion = true)
        {
            if (formulario.Controls.Find("btnVentanaCerrar", true).Any())
                return;

            OcultarBotonesViejos(formulario);

            Button btnMinimizar = CrearBoton("btnVentanaMinimizar", "—", Color.FromArgb(28, 49, 105));
            Button btnMaximizar = CrearBoton("btnVentanaMaximizar", "□", Color.FromArgb(28, 49, 105));
            Button btnCerrar = CrearBoton("btnVentanaCerrar", "X", Color.FromArgb(160, 45, 65));

            btnMinimizar.Click += (_, _) => formulario.WindowState = FormWindowState.Minimized;
            btnMaximizar.Click += (_, _) => AlternarPantalla(formulario, btnMaximizar);
            btnCerrar.Click += (_, _) =>
            {
                if (cerrarAplicacion)
                    Application.Exit();
                else
                    formulario.Close();
            };

            formulario.Controls.Add(btnMinimizar);
            formulario.Controls.Add(btnMaximizar);
            formulario.Controls.Add(btnCerrar);

            UbicarBotones(formulario, btnMinimizar, btnMaximizar, btnCerrar);
            TraerAlFrente(btnMinimizar, btnMaximizar, btnCerrar);

            formulario.Resize += (_, _) =>
            {
                UbicarBotones(formulario, btnMinimizar, btnMaximizar, btnCerrar);
                btnMaximizar.Text = formulario.WindowState == FormWindowState.Maximized ? "❐" : "□";
                TraerAlFrente(btnMinimizar, btnMaximizar, btnCerrar);
            };
        }

        private static Button CrearBoton(string nombre, string texto, Color colorFondo)
        {
            Button boton = new Button
            {
                Name = nombre,
                Text = texto,
                Size = new Size(AnchoBoton, AltoBoton),
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                BackColor = colorFondo,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                TabStop = false,
                Cursor = Cursors.Hand
            };

            boton.FlatAppearance.BorderSize = 1;
            boton.FlatAppearance.BorderColor = Color.FromArgb(70, 95, 170);
            boton.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 105, 210);
            boton.FlatAppearance.MouseDownBackColor = Color.FromArgb(132, 78, 255);

            return boton;
        }

        private static void UbicarBotones(Form formulario, Button btnMinimizar, Button btnMaximizar, Button btnCerrar)
        {
            int xCerrar = formulario.ClientSize.Width - MargenDerecho - AnchoBoton;
            int xMaximizar = xCerrar - Separacion - AnchoBoton;
            int xMinimizar = xMaximizar - Separacion - AnchoBoton;

            btnMinimizar.Location = new Point(xMinimizar, MargenSuperior);
            btnMaximizar.Location = new Point(xMaximizar, MargenSuperior);
            btnCerrar.Location = new Point(xCerrar, MargenSuperior);
        }

        private static void AlternarPantalla(Form formulario, Button btnMaximizar)
        {
            if (formulario.WindowState == FormWindowState.Maximized)
            {
                formulario.WindowState = FormWindowState.Normal;

                if (TamanoMinimoOriginal.TryGetValue(formulario, out Size minimoOriginal))
                    formulario.MinimumSize = minimoOriginal;

                TamanoMinimoOriginal.Remove(formulario);
                btnMaximizar.Text = "□";
                return;
            }

            TamanoMinimoOriginal[formulario] = formulario.MinimumSize;
            formulario.MinimumSize = Size.Empty;
            formulario.MaximumSize = Size.Empty;
            formulario.WindowState = FormWindowState.Maximized;
            btnMaximizar.Text = "❐";
        }

        private static void TraerAlFrente(params Button[] botones)
        {
            foreach (Button boton in botones)
                boton.BringToFront();
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
