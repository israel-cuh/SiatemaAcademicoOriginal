using System;
using System.Drawing;
using System.Drawing.Drawing2D;
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

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            using LinearGradientBrush fondo = new LinearGradientBrush(
                ClientRectangle,
                Color.FromArgb(5, 12, 35),
                Color.FromArgb(12, 39, 92),
                35F);

            e.Graphics.FillRectangle(fondo, ClientRectangle);
        }

        private void panelGrafico_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle area = new Rectangle(28, 42, panelGrafico.Width - 56, panelGrafico.Height - 82);
            using Pen lineaGuia = new Pen(Color.FromArgb(35, 92, 150), 1);
            using Pen linea = new Pen(Color.FromArgb(132, 78, 255), 4);
            using SolidBrush punto = new SolidBrush(Color.FromArgb(50, 220, 255));

            for (int i = 0; i < 4; i++)
            {
                int y = area.Top + (area.Height / 3) * i;
                e.Graphics.DrawLine(lineaGuia, area.Left, y, area.Right, y);
            }

            Point[] puntos =
            {
                new Point(area.Left + 10, area.Bottom - 35),
                new Point(area.Left + 145, area.Bottom - 80),
                new Point(area.Left + 280, area.Bottom - 55),
                new Point(area.Left + 420, area.Bottom - 125),
                new Point(area.Left + 560, area.Bottom - 150),
                new Point(area.Left + 700, area.Bottom - 105)
            };

            e.Graphics.DrawLines(linea, puntos);

            foreach (Point p in puntos)
                e.Graphics.FillEllipse(punto, p.X - 6, p.Y - 6, 12, 12);
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            MenuEstructura estructura = new MenuEstructura(rolUsuario);
            estructura.Show();
            Hide();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            Hide();
        }
    }
}
