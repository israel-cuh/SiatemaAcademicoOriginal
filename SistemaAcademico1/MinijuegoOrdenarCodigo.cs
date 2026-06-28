using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SistemaAcademico1
{
    public class MinijuegoOrdenarCodigo : Form
    {
        private sealed class Ejercicio
        {
            public string Titulo { get; }
            public string Instruccion { get; }
            public string[] Solucion { get; }
            public string Pista { get; }

            public Ejercicio(string titulo, string instruccion, string[] solucion, string pista)
            {
                Titulo = titulo;
                Instruccion = instruccion;
                Solucion = solucion;
                Pista = pista;
            }
        }

        private readonly List<Ejercicio> ejercicios = new()
        {
            new Ejercicio(
                "Nivel 1 - Ciclo while",
                "Ordena el código para imprimir los números del 1 al 5.",
                new[]
                {
                    "int i = 1;",
                    "while (i <= 5)",
                    "{",
                    "    Console.WriteLine(i);",
                    "    i++;",
                    "}"
                },
                "Primero se inicializa i, después se evalúa la condición y al final se incrementa."
            ),
            new Ejercicio(
                "Nivel 2 - Ciclo for",
                "Ordena el código para imprimir los números del 0 al 4.",
                new[]
                {
                    "for (int i = 0; i < 5; i++)",
                    "{",
                    "    Console.WriteLine(i);",
                    "}"
                },
                "El encabezado del for va antes de las llaves."
            ),
            new Ejercicio(
                "Nivel 3 - Condición dentro de un ciclo",
                "Ordena el código para mostrar únicamente los números pares.",
                new[]
                {
                    "for (int i = 1; i <= 5; i++)",
                    "{",
                    "    if (i % 2 == 0)",
                    "    {",
                    "        Console.WriteLine(i);",
                    "    }",
                    "}"
                },
                "El if debe estar dentro del for y su instrucción dentro de sus propias llaves."
            )
        };

        private readonly Label lblNivel = new();
        private readonly Label lblInstruccion = new();
        private readonly Label lblPuntuacion = new();
        private readonly Label lblResultado = new();
        private readonly ListBox lstCodigo = new();
        private readonly Button btnSubir = new();
        private readonly Button btnBajar = new();
        private readonly Button btnComprobar = new();
        private readonly Button btnPista = new();
        private readonly Button btnSiguiente = new();
        private readonly Button btnReiniciar = new();
        private readonly Button btnRegresar = new();

        private int nivelActual;
        private int puntuacion = 100;
        private int intentosFallidos;
        private readonly Random random = new();

        public MinijuegoOrdenarCodigo()
        {
            ConfigurarVentana();
            CrearInterfaz();
            CargarNivel();
        }

        private void ConfigurarVentana()
        {
            Text = "Ordena el código";
            StartPosition = FormStartPosition.CenterScreen;
            ClientSize = new Size(980, 650);
            MinimumSize = new Size(900, 620);
            BackColor = Color.FromArgb(6, 16, 41);
            Font = new Font("Segoe UI", 10F);
        }

        private void CrearInterfaz()
        {
            var titulo = new Label
            {
                Text = "DESAFÍO: ORDENA EL CÓDIGO",
                Font = new Font("Segoe UI", 20F, FontStyle.Bold),
                ForeColor = Color.DeepSkyBlue,
                AutoSize = true,
                Location = new Point(35, 25)
            };

            lblNivel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblNivel.ForeColor = Color.White;
            lblNivel.AutoSize = true;
            lblNivel.Location = new Point(40, 85);

            lblInstruccion.ForeColor = Color.Gainsboro;
            lblInstruccion.AutoSize = false;
            lblInstruccion.Size = new Size(880, 50);
            lblInstruccion.Location = new Point(40, 125);

            lblPuntuacion.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPuntuacion.ForeColor = Color.Gold;
            lblPuntuacion.AutoSize = true;
            lblPuntuacion.Location = new Point(760, 90);

            lstCodigo.Font = new Font("Consolas", 12F);
            lstCodigo.BackColor = Color.FromArgb(18, 30, 58);
            lstCodigo.ForeColor = Color.White;
            lstCodigo.BorderStyle = BorderStyle.FixedSingle;
            lstCodigo.Location = new Point(40, 180);
            lstCodigo.Size = new Size(700, 300);

            ConfigurarBoton(btnSubir, "▲ Subir", 770, 200, Color.RoyalBlue);
            ConfigurarBoton(btnBajar, "▼ Bajar", 770, 260, Color.RoyalBlue);
            ConfigurarBoton(btnPista, "Ver pista", 770, 340, Color.DarkOrange);
            ConfigurarBoton(btnReiniciar, "Reiniciar", 770, 400, Color.DimGray);

            ConfigurarBoton(btnComprobar, "Comprobar", 40, 510, Color.MediumSeaGreen, 180);
            ConfigurarBoton(btnSiguiente, "Siguiente nivel", 240, 510, Color.MediumPurple, 180);
            ConfigurarBoton(btnRegresar, "Regresar", 770, 550, Color.Firebrick);

            lblResultado.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblResultado.ForeColor = Color.White;
            lblResultado.AutoSize = false;
            lblResultado.Size = new Size(320, 80);
            lblResultado.Location = new Point(440, 510);

            btnSubir.Click += (_, _) => MoverLinea(-1);
            btnBajar.Click += (_, _) => MoverLinea(1);
            btnComprobar.Click += (_, _) => Comprobar();
            btnPista.Click += (_, _) => MessageBox.Show(ejercicios[nivelActual].Pista, "Pista", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnSiguiente.Click += (_, _) => SiguienteNivel();
            btnReiniciar.Click += (_, _) => CargarNivel();
            btnRegresar.Click += (_, _) => Close();
            lstCodigo.DoubleClick += (_, _) => MoverLinea(-1);

            Controls.AddRange(new Control[]
            {
                titulo, lblNivel, lblInstruccion, lblPuntuacion, lstCodigo,
                btnSubir, btnBajar, btnPista, btnReiniciar, btnComprobar,
                btnSiguiente, btnRegresar, lblResultado
            });
        }

        private static void ConfigurarBoton(Button boton, string texto, int x, int y, Color color, int ancho = 160)
        {
            boton.Text = texto;
            boton.Location = new Point(x, y);
            boton.Size = new Size(ancho, 42);
            boton.BackColor = color;
            boton.ForeColor = Color.White;
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderSize = 0;
            boton.Cursor = Cursors.Hand;
        }

        private void CargarNivel()
        {
            var ejercicio = ejercicios[nivelActual];
            lblNivel.Text = ejercicio.Titulo;
            lblInstruccion.Text = ejercicio.Instruccion;
            lblResultado.Text = "Selecciona una línea y usa Subir o Bajar.";
            lblResultado.ForeColor = Color.Gainsboro;
            intentosFallidos = 0;
            btnSiguiente.Enabled = false;
            btnComprobar.Enabled = true;

            var lineas = ejercicio.Solucion.ToList();
            do
            {
                lineas = lineas.OrderBy(_ => random.Next()).ToList();
            }
            while (lineas.SequenceEqual(ejercicio.Solucion));

            lstCodigo.Items.Clear();
            foreach (string linea in lineas)
                lstCodigo.Items.Add(linea);

            lstCodigo.SelectedIndex = 0;
            ActualizarPuntuacion();
        }

        private void MoverLinea(int desplazamiento)
        {
            int origen = lstCodigo.SelectedIndex;
            int destino = origen + desplazamiento;

            if (origen < 0 || destino < 0 || destino >= lstCodigo.Items.Count)
                return;

            object linea = lstCodigo.Items[origen];
            lstCodigo.Items.RemoveAt(origen);
            lstCodigo.Items.Insert(destino, linea);
            lstCodigo.SelectedIndex = destino;
        }

        private void Comprobar()
        {
            string[] respuesta = lstCodigo.Items.Cast<string>().ToArray();
            bool correcto = respuesta.SequenceEqual(ejercicios[nivelActual].Solucion);

            if (correcto)
            {
                int puntosNivel = Math.Max(10, 100 - (intentosFallidos * 10));
                puntuacion += puntosNivel;
                lblResultado.Text = $"¡Correcto! Ganaste {puntosNivel} puntos.";
                lblResultado.ForeColor = Color.LightGreen;
                btnComprobar.Enabled = false;
                btnSiguiente.Enabled = true;

                if (nivelActual == ejercicios.Count - 1)
                    btnSiguiente.Text = "Ver resultado final";
            }
            else
            {
                intentosFallidos++;
                lblResultado.Text = "Todavía no está correcto. Revisa las llaves y el orden lógico.";
                lblResultado.ForeColor = Color.Salmon;
            }

            ActualizarPuntuacion();
        }

        private void SiguienteNivel()
        {
            if (nivelActual < ejercicios.Count - 1)
            {
                nivelActual++;
                CargarNivel();
                return;
            }

            MessageBox.Show(
                $"¡Completaste todos los niveles!\nPuntuación final: {puntuacion}",
                "Juego completado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            Close();
        }

        private void ActualizarPuntuacion()
        {
            lblPuntuacion.Text = $"Puntos: {puntuacion}";
        }
    }
}
