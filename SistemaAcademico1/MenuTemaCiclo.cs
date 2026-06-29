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

            btnWhile.Click += (_, _) => MostrarWhile();
            btnFor.Click += (_, _) => MostrarFor();
            btnDoWhile.Click += (_, _) => MostrarDoWhile();
            btnAnidados.Click += (_, _) => MostrarAnidados();
            btnjuego.Click += btnjuego_Click;

            txtCodigo.ReadOnly = true;
            txtCodigo.TabStop = false;
            richTextBox1.ReadOnly = true;
            richTextBox1.TabStop = false;

            OcultarTextosFijosDeWhile();
            MostrarWhile();
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
            txtSalida.Clear();
            MarcarBotonActivo(botonActivo);
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

        private void MostrarFor()
        {
            MostrarTema(
                TemaCiclo.For,
                btnFor,
                "Ciclo For",
                "Repite instrucciones una cantidad determinada de veces.",
                "for (inicio; condicion; incremento)\n{\n    instrucciones;\n}",
                "for (int i = 1; i <= 5; i++)\n{\n    Console.WriteLine(i);\n}",
                "El ciclo controla el inicio, la condición y el incremento en una sola línea.");
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
                boton.BackColor = Color.White;
                boton.ForeColor = Color.FromArgb(6, 16, 41);
                boton.FlatStyle = FlatStyle.Flat;
                boton.FlatAppearance.BorderSize = 0;
            }

            botonActivo.BackColor = Color.FromArgb(132, 78, 255);
            botonActivo.ForeColor = Color.White;
        }

        private void OcultarTextosFijosDeWhile()
        {
            Control[] textosFijos =
            {
                label4, label5, label6, label7, label8,
                label12, label13, label14, label15, label16,
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
