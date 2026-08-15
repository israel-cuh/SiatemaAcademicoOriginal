using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaAcademico1
{
    public class CiclosAnidados : Form
    {
        private TextBox txtCodigo;
        private TextBox txtSalida;
        private Button btnEjecutar;
        private Button btnLimpiar;
        private Button btnVolver;

        public CiclosAnidados()
        {
            Text = "Ciclos Anidados";
            StartPosition = FormStartPosition.CenterParent;
            Size = new Size(800, 600);

            if (System.ComponentModel.LicenseManager.UsageMode != System.ComponentModel.LicenseUsageMode.Designtime)
            {
                MenuLateralHelper.AgregarMenu(this, "Ciclos");
                ControlesVentanaHelper.Agregar(this, cerrarAplicacion: true);
            }

            InitializeComponents();
        }

        private void InitializeComponents()
        {
            txtCodigo = new TextBox
            {
                Multiline = true,
                ReadOnly = true,
                Font = new Font("Consolas", 10F, FontStyle.Regular, GraphicsUnit.Point),
                Location = new Point(20, 20),
                Size = new Size(ClientSize.Width - 60, 160),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            };

            txtCodigo.Text = "for (int i = 1; i <= 3; i++)\r\n{\r\n    for (int j = 1; j <= 3; j++)\r\n    {\r\n        Console.WriteLine($\"i={i}, j={j}\");\r\n    }\r\n}";

            txtSalida = new TextBox
            {
                Multiline = true,
                ReadOnly = true,
                Location = new Point(20, 200),
                Size = new Size(ClientSize.Width - 60, ClientSize.Height - 300),
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right
            };

            btnEjecutar = new Button
            {
                Text = "Ejecutar",
                Location = new Point(20, ClientSize.Height - 80),
                Anchor = AnchorStyles.Bottom | AnchorStyles.Left
            };
            btnEjecutar.Click += BtnEjecutar_Click;

            btnLimpiar = new Button
            {
                Text = "Limpiar",
                Location = new Point(120, ClientSize.Height - 80),
                Anchor = AnchorStyles.Bottom | AnchorStyles.Left
            };
            btnLimpiar.Click += (_, _) => txtSalida.Clear();

            btnVolver = new Button
            {
                Text = "Volver",
                Location = new Point(ClientSize.Width - 120, ClientSize.Height - 80),
                Anchor = AnchorStyles.Bottom | AnchorStyles.Right
            };
            btnVolver.Click += BtnVolver_Click;

            Controls.Add(txtCodigo);
            Controls.Add(txtSalida);
            Controls.Add(btnEjecutar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnVolver);
        }

        private void BtnEjecutar_Click(object? sender, EventArgs e)
        {
            txtSalida.Clear();

            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    txtSalida.AppendText($"i={i}, j={j}" + Environment.NewLine);
                }
            }
        }

        private void InitializeComponent()
        {

        }

        private void BtnVolver_Click(object? sender, EventArgs e)
        {
            MenuTemaDoWhile ventana = new MenuTemaDoWhile();
            ventana.Show();
            Close();
        }
    }
}
