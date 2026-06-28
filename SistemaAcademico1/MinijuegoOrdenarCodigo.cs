using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
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
            public string Explicacion { get; }

            public Ejercicio(string titulo, string instruccion, string[] solucion, string pista, string explicacion)
            {
                Titulo = titulo;
                Instruccion = instruccion;
                Solucion = solucion;
                Pista = pista;
                Explicacion = explicacion;
            }
        }

        private readonly List<Ejercicio> ejercicios = new()
        {
            new Ejercicio(
                "Ciclo while",
                "Ordena los bloques para imprimir los números del 1 al 5.",
                new[]
                {
                    "int i = 1;",
                    "while (i <= 5)",
                    "{",
                    "    Console.WriteLine(i);",
                    "    i++;",
                    "}"
                },
                "Primero inicializa i. Dentro del ciclo imprime y luego incrementa.",
                "El ciclo comienza con i en 1, imprime su valor y aumenta uno hasta llegar a 5."
            ),
            new Ejercicio(
                "Ciclo for",
                "Ordena los bloques para imprimir los números del 0 al 4.",
                new[]
                {
                    "for (int i = 0; i < 5; i++)",
                    "{",
                    "    Console.WriteLine(i);",
                    "}"
                },
                "El encabezado del for debe aparecer antes de las llaves.",
                "El ciclo for reúne la inicialización, la condición y el incremento en una sola línea."
            ),
            new Ejercicio(
                "Condición dentro de un ciclo",
                "Ordena los bloques para mostrar únicamente los números pares.",
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
                "El if va dentro del for y necesita su propio par de llaves.",
                "El operador % obtiene el residuo. Si el residuo al dividir para 2 es cero, el número es par."
            )
        };

        private readonly Color fondo = Color.FromArgb(8, 10, 38);
        private readonly Color panel = Color.FromArgb(20, 24, 66);
        private readonly Color panelClaro = Color.FromArgb(30, 35, 88);
        private readonly Color morado = Color.FromArgb(132, 78, 255);
        private readonly Color azul = Color.FromArgb(56, 145, 255);
        private readonly Color verde = Color.FromArgb(55, 174, 52);

        private readonly Label lblTiempo = new();
        private readonly Label lblPuntuacion = new();
        private readonly Label lblNivel = new();
        private readonly Label lblInstruccion = new();
        private readonly Label lblPista = new();
        private readonly Label lblResultado = new();
        private readonly Label lblProgreso = new();
        private readonly ListBox lstCodigo = new();
        private readonly ProgressBar progreso = new();
        private readonly Button btnVerificar = new();
        private readonly Button btnSiguiente = new();
        private readonly Button btnPausa = new();
        private readonly System.Windows.Forms.Timer temporizador = new();

        private int nivelActual;
        private int puntuacion;
        private int intentosFallidos;
        private int segundosRestantes = 60;
        private int indiceArrastrado = -1;
        private bool pausado;
        private bool nivelResuelto;
        private readonly Random random = new();

        public MinijuegoOrdenarCodigo()
        {
            ConfigurarVentana();
            CrearInterfaz();
            ConfigurarEventos();
            CargarNivel();
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            using var pincel = new LinearGradientBrush(ClientRectangle, Color.FromArgb(7, 9, 34), Color.FromArgb(18, 14, 55), 25F);
            e.Graphics.FillRectangle(pincel, ClientRectangle);
        }

        private void ConfigurarVentana()
        {
            Text = "CodeNova - Ordena el código";
            StartPosition = FormStartPosition.CenterScreen;
            ClientSize = new Size(1220, 720);
            MinimumSize = new Size(1120, 680);
            BackColor = fondo;
            Font = new Font("Segoe UI", 10F);
            DoubleBuffered = true;
        }

        private void CrearInterfaz()
        {
            var tarjetaTiempo = CrearTarjeta(new Point(30, 22), new Size(230, 92));
            tarjetaTiempo.Controls.Add(CrearEtiqueta("◷", 20F, azul, new Point(22, 25), new Size(48, 48)));
            tarjetaTiempo.Controls.Add(CrearEtiqueta("TIEMPO", 10F, Color.LightSkyBlue, new Point(78, 15), new Size(120, 25), FontStyle.Bold));
            lblTiempo.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTiempo.ForeColor = Color.White;
            lblTiempo.Location = new Point(75, 38);
            lblTiempo.Size = new Size(135, 45);
            tarjetaTiempo.Controls.Add(lblTiempo);

            var titulo = CrearEtiqueta("ORDENA EL CÓDIGO", 24F, Color.White, new Point(365, 25), new Size(500, 50), FontStyle.Bold);
            titulo.TextAlign = ContentAlignment.MiddleCenter;
            var subtitulo = CrearEtiqueta("Arrastra los bloques para construir el programa correcto.", 11F, Color.Gainsboro, new Point(355, 75), new Size(520, 30));
            subtitulo.TextAlign = ContentAlignment.MiddleCenter;

            var tarjetaPuntos = CrearTarjeta(new Point(935, 22), new Size(205, 92));
            tarjetaPuntos.Controls.Add(CrearEtiqueta("★", 22F, Color.Gold, new Point(18, 25), new Size(50, 50)));
            tarjetaPuntos.Controls.Add(CrearEtiqueta("PUNTAJE", 10F, Color.LightSkyBlue, new Point(73, 15), new Size(115, 25), FontStyle.Bold));
            lblPuntuacion.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblPuntuacion.ForeColor = Color.White;
            lblPuntuacion.Location = new Point(70, 38);
            lblPuntuacion.Size = new Size(120, 45);
            tarjetaPuntos.Controls.Add(lblPuntuacion);

            btnPausa.Text = "Ⅱ";
            btnPausa.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            btnPausa.Location = new Point(1155, 35);
            btnPausa.Size = new Size(50, 58);
            EstilizarBoton(btnPausa, panelClaro);

            var contenedor = CrearTarjeta(new Point(30, 135), new Size(1175, 485));
            contenedor.Padding = new Padding(18);

            var panelLateral = new Panel
            {
                BackColor = Color.FromArgb(25, 25, 72),
                Location = new Point(18, 18),
                Size = new Size(315, 448)
            };
            panelLateral.Controls.Add(CrearEtiqueta("DESAFÍO ACTUAL", 13F, Color.FromArgb(185, 115, 255), new Point(22, 22), new Size(270, 30), FontStyle.Bold));

            lblNivel.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            lblNivel.ForeColor = Color.White;
            lblNivel.Location = new Point(22, 63);
            lblNivel.Size = new Size(270, 70);
            panelLateral.Controls.Add(lblNivel);

            lblInstruccion.Font = new Font("Segoe UI", 10.5F);
            lblInstruccion.ForeColor = Color.Gainsboro;
            lblInstruccion.Location = new Point(22, 135);
            lblInstruccion.Size = new Size(270, 75);
            panelLateral.Controls.Add(lblInstruccion);

            var cajaPista = new Panel
            {
                BackColor = Color.FromArgb(34, 43, 92),
                Location = new Point(18, 235),
                Size = new Size(280, 125)
            };
            cajaPista.Controls.Add(CrearEtiqueta("💡  PISTA", 11F, Color.LightSkyBlue, new Point(15, 12), new Size(240, 28), FontStyle.Bold));
            lblPista.ForeColor = Color.Gainsboro;
            lblPista.Location = new Point(15, 45);
            lblPista.Size = new Size(250, 68);
            cajaPista.Controls.Add(lblPista);
            panelLateral.Controls.Add(cajaPista);

            var btnReiniciar = new Button { Text = "↻  REINICIAR", Location = new Point(18, 382), Size = new Size(135, 44) };
            EstilizarBoton(btnReiniciar, Color.FromArgb(38, 48, 100), Color.LightSkyBlue);
            btnReiniciar.Click += (_, _) => CargarNivel();

            var btnRegresar = new Button { Text = "←  REGRESAR", Location = new Point(163, 382), Size = new Size(135, 44) };
            EstilizarBoton(btnRegresar, Color.FromArgb(70, 40, 83), Color.White);
            btnRegresar.Click += (_, _) => Close();
            panelLateral.Controls.AddRange(new Control[] { btnReiniciar, btnRegresar });

            var panelCodigo = new Panel
            {
                BackColor = Color.FromArgb(11, 14, 48),
                Location = new Point(350, 18),
                Size = new Size(805, 448)
            };
            panelCodigo.Controls.Add(CrearEtiqueta("BLOQUES DE CÓDIGO", 12F, Color.FromArgb(185, 115, 255), new Point(22, 15), new Size(240, 30), FontStyle.Bold));
            panelCodigo.Controls.Add(CrearEtiqueta("Arrastra una línea para cambiar su posición.", 9.5F, Color.Silver, new Point(455, 17), new Size(320, 26)));

            lstCodigo.Font = new Font("Consolas", 12F, FontStyle.Bold);
            lstCodigo.BackColor = Color.FromArgb(12, 16, 52);
            lstCodigo.ForeColor = Color.White;
            lstCodigo.BorderStyle = BorderStyle.None;
            lstCodigo.DrawMode = DrawMode.OwnerDrawFixed;
            lstCodigo.ItemHeight = 50;
            lstCodigo.Location = new Point(22, 58);
            lstCodigo.Size = new Size(670, 335);
            lstCodigo.AllowDrop = true;
            panelCodigo.Controls.Add(lstCodigo);

            var btnSubir = new Button { Text = "▲", Location = new Point(715, 95), Size = new Size(62, 55) };
            var btnBajar = new Button { Text = "▼", Location = new Point(715, 165), Size = new Size(62, 55) };
            EstilizarBoton(btnSubir, Color.FromArgb(67, 65, 160));
            EstilizarBoton(btnBajar, Color.FromArgb(67, 65, 160));
            btnSubir.Click += (_, _) => MoverLinea(-1);
            btnBajar.Click += (_, _) => MoverLinea(1);
            panelCodigo.Controls.AddRange(new Control[] { btnSubir, btnBajar });

            lblResultado.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblResultado.ForeColor = Color.LightSkyBlue;
            lblResultado.Location = new Point(22, 402);
            lblResultado.Size = new Size(755, 32);
            panelCodigo.Controls.Add(lblResultado);

            contenedor.Controls.AddRange(new Control[] { panelLateral, panelCodigo });

            lblProgreso.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblProgreso.ForeColor = Color.Gainsboro;
            lblProgreso.Location = new Point(35, 638);
            lblProgreso.Size = new Size(230, 25);

            progreso.Location = new Point(35, 665);
            progreso.Size = new Size(510, 18);
            progreso.Minimum = 0;
            progreso.Maximum = ejercicios.Count;

            btnSiguiente.Text = "SIGUIENTE NIVEL  →";
            btnSiguiente.Location = new Point(615, 650);
            btnSiguiente.Size = new Size(220, 48);
            EstilizarBoton(btnSiguiente, morado);

            btnVerificar.Text = "✓  VERIFICAR";
            btnVerificar.Location = new Point(925, 645);
            btnVerificar.Size = new Size(280, 55);
            btnVerificar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            EstilizarBoton(btnVerificar, verde);

            Controls.AddRange(new Control[]
            {
                tarjetaTiempo, titulo, subtitulo, tarjetaPuntos, btnPausa,
                contenedor, lblProgreso, progreso, btnSiguiente, btnVerificar
            });
        }

        private void ConfigurarEventos()
        {
            btnVerificar.Click += (_, _) => Comprobar();
            btnSiguiente.Click += (_, _) => SiguienteNivel();
            btnPausa.Click += (_, _) => AlternarPausa();
            temporizador.Interval = 1000;
            temporizador.Tick += (_, _) => ActualizarTiempo();

            lstCodigo.DrawItem += DibujarBloque;
            lstCodigo.MouseDown += IniciarArrastre;
            lstCodigo.DragOver += (_, e) => e.Effect = DragDropEffects.Move;
            lstCodigo.DragDrop += SoltarBloque;
        }

        private Panel CrearTarjeta(Point ubicacion, Size tamano)
        {
            return new Panel
            {
                BackColor = panel,
                Location = ubicacion,
                Size = tamano,
                BorderStyle = BorderStyle.FixedSingle
            };
        }

        private static Label CrearEtiqueta(string texto, float tamano, Color color, Point ubicacion, Size area, FontStyle estilo = FontStyle.Regular)
        {
            return new Label
            {
                Text = texto,
                Font = new Font("Segoe UI", tamano, estilo),
                ForeColor = color,
                BackColor = Color.Transparent,
                Location = ubicacion,
                Size = area
            };
        }

        private static void EstilizarBoton(Button boton, Color colorFondo, Color? colorTexto = null)
        {
            boton.BackColor = colorFondo;
            boton.ForeColor = colorTexto ?? Color.White;
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderSize = 0;
            boton.Cursor = Cursors.Hand;
            boton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        }

        private void CargarNivel()
        {
            var ejercicio = ejercicios[nivelActual];
            nivelResuelto = false;
            pausado = false;
            intentosFallidos = 0;
            segundosRestantes = 60;
            btnPausa.Text = "Ⅱ";
            btnVerificar.Enabled = true;
            btnSiguiente.Enabled = false;
            btnSiguiente.Text = nivelActual == ejercicios.Count - 1 ? "VER RESULTADO  →" : "SIGUIENTE NIVEL  →";

            lblNivel.Text = $"NIVEL {nivelActual + 1}\n{ejercicio.Titulo}";
            lblInstruccion.Text = ejercicio.Instruccion;
            lblPista.Text = ejercicio.Pista;
            lblResultado.Text = "Selecciona y arrastra los bloques hasta completar el código.";
            lblResultado.ForeColor = Color.LightSkyBlue;
            lblProgreso.Text = $"PROGRESO  ·  NIVEL {nivelActual + 1} DE {ejercicios.Count}";
            progreso.Value = nivelActual;

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
            ActualizarMarcadores();
            temporizador.Start();
        }

        private void DibujarBloque(object? sender, DrawItemEventArgs e)
        {
            if (e.Index < 0)
                return;

            bool seleccionado = (e.State & DrawItemState.Selected) == DrawItemState.Selected;
            Color[] colores =
            {
                Color.FromArgb(64, 45, 128),
                Color.FromArgb(35, 67, 126),
                Color.FromArgb(38, 92, 85),
                Color.FromArgb(115, 62, 53)
            };

            using var fondoBloque = new SolidBrush(seleccionado ? morado : colores[e.Index % colores.Length]);
            e.Graphics.FillRectangle(fondoBloque, e.Bounds.X + 4, e.Bounds.Y + 4, e.Bounds.Width - 8, e.Bounds.Height - 8);

            string numero = $"{e.Index + 1}";
            using var pincelNumero = new SolidBrush(Color.FromArgb(155, 165, 210));
            using var pincelTexto = new SolidBrush(Color.White);
            e.Graphics.DrawString(numero, new Font("Consolas", 11F, FontStyle.Bold), pincelNumero, e.Bounds.X + 15, e.Bounds.Y + 15);
            e.Graphics.DrawString(lstCodigo.Items[e.Index]?.ToString() ?? "", lstCodigo.Font, pincelTexto, e.Bounds.X + 55, e.Bounds.Y + 14);
            e.DrawFocusRectangle();
        }

        private void IniciarArrastre(object? sender, MouseEventArgs e)
        {
            indiceArrastrado = lstCodigo.IndexFromPoint(e.Location);
            if (indiceArrastrado != ListBox.NoMatches)
                lstCodigo.DoDragDrop(lstCodigo.Items[indiceArrastrado], DragDropEffects.Move);
        }

        private void SoltarBloque(object? sender, DragEventArgs e)
        {
            if (indiceArrastrado < 0 || indiceArrastrado >= lstCodigo.Items.Count)
                return;

            Point punto = lstCodigo.PointToClient(new Point(e.X, e.Y));
            int destino = lstCodigo.IndexFromPoint(punto);
            if (destino == ListBox.NoMatches)
                destino = lstCodigo.Items.Count - 1;

            object bloque = lstCodigo.Items[indiceArrastrado];
            lstCodigo.Items.RemoveAt(indiceArrastrado);
            lstCodigo.Items.Insert(destino, bloque);
            lstCodigo.SelectedIndex = destino;
            indiceArrastrado = -1;
        }

        private void MoverLinea(int desplazamiento)
        {
            int origen = lstCodigo.SelectedIndex;
            int destino = origen + desplazamiento;
            if (origen < 0 || destino < 0 || destino >= lstCodigo.Items.Count)
                return;

            object bloque = lstCodigo.Items[origen];
            lstCodigo.Items.RemoveAt(origen);
            lstCodigo.Items.Insert(destino, bloque);
            lstCodigo.SelectedIndex = destino;
        }

        private void Comprobar()
        {
            if (nivelResuelto)
                return;

            string[] respuesta = lstCodigo.Items.Cast<string>().ToArray();
            if (respuesta.SequenceEqual(ejercicios[nivelActual].Solucion))
            {
                nivelResuelto = true;
                temporizador.Stop();
                int puntosNivel = Math.Max(20, 100 + segundosRestantes - (intentosFallidos * 10));
                puntuacion += puntosNivel;
                progreso.Value = nivelActual + 1;
                lblResultado.Text = $"★ ¡Código completo! +{puntosNivel} puntos. {ejercicios[nivelActual].Explicacion}";
                lblResultado.ForeColor = Color.LightGreen;
                btnVerificar.Enabled = false;
                btnSiguiente.Enabled = true;
            }
            else
            {
                intentosFallidos++;
                lblResultado.Text = "El orden todavía no es correcto. Revisa la estructura y vuelve a intentarlo.";
                lblResultado.ForeColor = Color.Salmon;
            }

            ActualizarMarcadores();
        }

        private void SiguienteNivel()
        {
            if (!nivelResuelto)
                return;

            if (nivelActual < ejercicios.Count - 1)
            {
                nivelActual++;
                CargarNivel();
                return;
            }

            MessageBox.Show(
                $"¡Desafío completado!\n\nPuntuación final: {puntuacion}\nCompletaste los {ejercicios.Count} niveles.",
                "CodeNova - Código completo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            Close();
        }

        private void AlternarPausa()
        {
            pausado = !pausado;
            btnPausa.Text = pausado ? "▶" : "Ⅱ";
            if (pausado)
                temporizador.Stop();
            else if (!nivelResuelto)
                temporizador.Start();
        }

        private void ActualizarTiempo()
        {
            if (segundosRestantes > 0)
            {
                segundosRestantes--;
                ActualizarMarcadores();
                return;
            }

            temporizador.Stop();
            btnVerificar.Enabled = false;
            lblResultado.Text = "Se terminó el tiempo. Pulsa REINICIAR para intentarlo nuevamente.";
            lblResultado.ForeColor = Color.Salmon;
        }

        private void ActualizarMarcadores()
        {
            lblTiempo.Text = $"00:{segundosRestantes:00}";
            lblPuntuacion.Text = puntuacion.ToString();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            temporizador.Stop();
            temporizador.Dispose();
            base.OnFormClosed(e);
        }
    }
}
