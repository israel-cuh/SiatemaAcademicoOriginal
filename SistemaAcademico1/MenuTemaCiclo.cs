using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaAcademico1
{
    public partial class MenuTemaCiclo : Form
    {
        private enum TemaCiclo
        {
            While,
            For,
            DoWhile,
            Anidados
        }

        private TemaCiclo temaActual = TemaCiclo.While;

        public object Items { get; private set; }

        public MenuTemaCiclo()
        {
            InitializeComponent();

            if (System.ComponentModel.LicenseManager.UsageMode != System.ComponentModel.LicenseUsageMode.Designtime)
            {
                MenuLateralHelper.AgregarMenu(this, "Ciclos");
                AjustarDistribucionGrande();
                ControlesVentanaHelper.Agregar(this, cerrarAplicacion: true);
                Resize += (_, _) =>
                {
                    if (WindowState != FormWindowState.Minimized)
                        AjustarDistribucionGrande();
                };
            }

            btnWhile.Click += (_, _) => MostrarWhile();
            btnFor.Click += (_, _) => AbrirCicloFor();
            btnDoWhile.Click += (_, _) => MostrarDoWhile();
            btnAnidados.Click += (_, _) => MostrarAnidados();
            btnjuego.Click += btnjuego_Click;

            ConfigurarBotonesSubMenu();
            PrepararLabelExplicacion();

            txtCodigo.ReadOnly = true;
            txtCodigo.TabStop = false;
            richTextBox1.ReadOnly = true;
            richTextBox1.TabStop = false;

            OcultarTextosFijosDeWhile();
            MostrarWhile();
        }

        private void ConfigurarBotonesSubMenu()
        {
            Button[] botones = { btnWhile, btnFor, btnDoWhile, btnAnidados };

            foreach (Button boton in botones)
            {
                boton.UseVisualStyleBackColor = false;
                boton.FlatStyle = FlatStyle.Flat;
                boton.FlatAppearance.BorderSize = 1;
                boton.FlatAppearance.BorderColor = Color.FromArgb(16, 35, 80);
                boton.FlatAppearance.MouseOverBackColor = Color.FromArgb(28, 49, 105);
                boton.FlatAppearance.MouseDownBackColor = Color.FromArgb(132, 78, 255);
                boton.BackColor = Color.FromArgb(6, 16, 41);
                boton.ForeColor = Color.White;
            }
        }

        private void PrepararLabelExplicacion()
        {
            label12.AutoSize = false;
            label12.Location = new Point(12, 260);
            label12.Size = new Size(455, 140);
            label12.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            label12.ForeColor = Color.WhiteSmoke;
            label12.BackColor = Color.Transparent;
        }

        private void AjustarDistribucionGrande()
        {
            int margenIzquierdo = 290;
            int margenSuperior = 18;
            int anchoContenido = Math.Max(900, ClientSize.Width - margenIzquierdo - 30);
            int altoPaneles = Math.Max(535, ClientSize.Height - 315);
            int posicionPanelInferior = Math.Max(705, ClientSize.Height - 145);

            panel2.Location = new Point(margenIzquierdo, margenSuperior);
            panel2.Size = new Size(250, Math.Max(430, altoPaneles - 105));

            panelConsejo.Location = new Point(margenIzquierdo, Math.Max(475, ClientSize.Height - 375));
            panelConsejo.Size = new Size(250, 165);

            panel1.Location = new Point(margenIzquierdo + 270, margenSuperior);
            panel1.Size = new Size(Math.Max(620, anchoContenido - 270), 118);

            panel4.Location = new Point(margenIzquierdo + 270, 145);
            panel4.Size = new Size(500, altoPaneles);
            panelImportante.Location = new Point(12, panel4.Height - 105);
            panelImportante.Size = new Size(468, 87);
            label12.Size = new Size(panel4.Width - 45, 140);

            panel5.Location = new Point(margenIzquierdo + 790, 145);
            panel5.Size = new Size(Math.Max(420, anchoContenido - 790), altoPaneles);
            txtCodigo.Size = new Size(panel5.Width - 54, 160);
            txtSalida.Size = new Size(panel5.Width - 54, Math.Max(175, panel5.Height - 360));
            label3.Location = new Point(label3.Left, txtSalida.Bottom + 10);
            label3.Size = new Size(panel5.Width - 54, 55);
            btnLimpiar.Location = new Point(panel5.Width - 248, 205);
            btnEjecutar.Location = new Point(panel5.Width - 128, 205);

            panel6.Location = new Point(margenIzquierdo, posicionPanelInferior);
            panel6.Size = new Size(anchoContenido, 105);
            button1.Location = new Point(45, 38);
            btnjuego.Location = new Point(panel6.Width - btnjuego.Width - 28, 28);
        }

        private void MostrarTema(
            TemaCiclo tema,
            Button botonActivo,
            string titulo,
            string descripcion,
            string sintaxis,
            string ejemplo,
            string explicacion)
        {
            temaActual = tema;
            lblTituloTema.Text = titulo;
            lblDescripcionTema.Text = descripcion;
            richTextBox1.Text = sintaxis;
            txtCodigo.Text = ejemplo;
            label3.Text = explicacion;
            label12.Text = ObtenerExplicacionTema(tema);
            label12.Visible = true;
            txtSalida.Clear();
            MarcarBotonActivo(botonActivo);
        }

        private string ObtenerExplicacionTema(TemaCiclo tema)
        {
            return tema switch
            {
                TemaCiclo.While => "Explicación\n1. Se evalúa la condición.\n2. Si es verdadera, se ejecutan las instrucciones.\n3. Luego vuelve a evaluarse la condición.\n4. El ciclo termina cuando la condición es falsa.",
                TemaCiclo.For => "Explicación\n1. Se inicializa la variable de control.\n2. Se evalúa la condición.\n3. Si es verdadera, se ejecuta el bloque.\n4. Se realiza el incremento.\n5. El proceso se repite hasta que la condición sea falsa.",
                TemaCiclo.DoWhile => "Explicación\n1. Primero se ejecutan las instrucciones.\n2. Después se evalúa la condición.\n3. Si es verdadera, el ciclo vuelve a repetirse.\n4. Siempre se ejecuta al menos una vez.",
                TemaCiclo.Anidados => "Explicación\n1. El ciclo externo inicia una repetición.\n2. El ciclo interno se ejecuta completo.\n3. Luego el ciclo externo continúa.\n4. Es útil para tablas, matrices o recorridos dobles.",
                _ => string.Empty
            };
        }

        private void MostrarWhile()
        {
            MostrarTema(
                TemaCiclo.While,
                btnWhile,
                "Ciclo While",
                "Ejecuta un bloque mientras la condición sea verdadera.",
                "while (condicion)\n{\n    instrucciones;\n}",
                "int i = 1;\n\nwhile (i <= 5)\n{\n    Console.WriteLine(i);\n    i++;\n}",
                "Comienza en 1, imprime el número y lo incrementa hasta llegar a 5.");
        }

        private void AbrirCicloFor()
        {
            MenuTemaFor ventana = new MenuTemaFor();
            ventana.Show();
            Hide();
        }

        private void MostrarDoWhile()
        {
            MostrarTema(
                TemaCiclo.DoWhile,
                btnDoWhile,
                "Ciclo Do While",
                "Ejecuta primero el bloque y después comprueba la condición.",
                "do\n{\n    instrucciones;\n}\nwhile (condicion);",
                "int i = 1;\n\ndo\n{\n    Console.WriteLine(i);\n    i++;\n}\nwhile (i <= 5);",
                "Este ciclo se ejecuta al menos una vez porque evalúa la condición al final.");
        }

        private void MostrarAnidados()
        {
            MostrarTema(
                TemaCiclo.Anidados,
                btnAnidados,
                "Ciclos Anidados",
                "Un ciclo anidado es un ciclo colocado dentro de otro.",
                "for (...)\n{\n    for (...)\n    {\n        instrucciones;\n    }\n}",
                "for (int i = 1; i <= 3; i++)\n{\n    for (int j = 1; j <= 2; j++)\n    {\n        Console.WriteLine($\"i={i}, j={j}\");\n    }\n}",
                "Por cada repetición del ciclo externo, el ciclo interno se ejecuta completamente.");
        }

        private void MarcarBotonActivo(Button botonActivo)
        {
            Button[] botones = { btnWhile, btnFor, btnDoWhile, btnAnidados };

            foreach (Button boton in botones)
            {
                boton.UseVisualStyleBackColor = false;
                boton.FlatStyle = FlatStyle.Flat;
                boton.FlatAppearance.BorderSize = 1;
                boton.FlatAppearance.BorderColor = Color.FromArgb(16, 35, 80);
                boton.BackColor = Color.FromArgb(6, 16, 41);
                boton.ForeColor = Color.White;
            }

            botonActivo.BackColor = Color.FromArgb(132, 78, 255);
            botonActivo.ForeColor = Color.White;
            botonActivo.FlatAppearance.BorderColor = Color.FromArgb(160, 120, 255);
        }

        private void OcultarTextosFijosDeWhile()
        {
            Control[] textosFijos =
            {
                label4, label5, label6, label7, label8,
                label13, label14, label15, label16,
                label17, label18, label19, panel3
            };

            foreach (Control control in textosFijos)
                control.Visible = false;
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            txtSalida.Clear();

            switch (temaActual)
            {
                case TemaCiclo.While:
                    int numeroWhile = 1;
                    while (numeroWhile <= 5)
                    {
                        txtSalida.AppendText(numeroWhile + Environment.NewLine);
                        numeroWhile++;
                    }
                    break;

                case TemaCiclo.For:
                    for (int i = 1; i <= 5; i++)
                        txtSalida.AppendText(i + Environment.NewLine);
                    break;

                case TemaCiclo.DoWhile:
                    int numeroDoWhile = 1;
                    do
                    {
                        txtSalida.AppendText(numeroDoWhile + Environment.NewLine);
                        numeroDoWhile++;
                    }
                    while (numeroDoWhile <= 5);
                    break;

                case TemaCiclo.Anidados:
                    for (int i = 1; i <= 3; i++)
                    {
                        for (int j = 1; j <= 2; j++)
                            txtSalida.AppendText($"i={i}, j={j}{Environment.NewLine}");
                    }
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuEstructura ventana = new MenuEstructura();
            ventana.Show();
            Hide();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtSalida.Clear();
        }

        private void txtSalida_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
        }

        private void richTextBox2Explicacion_TextChanged(object sender, EventArgs e)
        {
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void btnjuego_Click(object? sender, EventArgs e)
        {
            using MinijuegoOrdenarCodigo juego = new();
            juego.ShowDialog(this);
        }
    }
}
