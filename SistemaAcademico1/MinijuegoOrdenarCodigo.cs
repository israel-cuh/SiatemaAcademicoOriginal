using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace SistemaAcademico1
{
    public partial class MinijuegoOrdenarCodigo : Form
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
                new[] { "int i = 1;", "while (i <= 5)", "{", "    Console.WriteLine(i);", "    i++;", "}" },
                "Primero inicializa i. Dentro del ciclo imprime y luego incrementa.",
                "El ciclo comienza con i en 1, imprime su valor y aumenta uno hasta llegar a 5."
            ),
            new Ejercicio(
                "Ciclo for",
                "Ordena los bloques para imprimir los números del 0 al 4.",
                new[] { "for (int i = 0; i < 5; i++)", "{", "    Console.WriteLine(i);", "}" },
                "El encabezado del for debe aparecer antes de las llaves.",
                "El ciclo for reúne la inicialización, la condición y el incremento en una sola línea."
            ),
            new Ejercicio(
                "Condición dentro de un ciclo",
                "Ordena los bloques para mostrar únicamente los números pares.",
                new[] { "for (int i = 1; i <= 5; i++)", "{", "    if (i % 2 == 0)", "    {", "        Console.WriteLine(i);", "    }", "}" },
                "El if va dentro del for y necesita su propio par de llaves.",
                "El operador % obtiene el residuo. Si el residuo al dividir para 2 es cero, el número es par."
            )
        };

        private readonly Color morado = Color.FromArgb(132, 78, 255);
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
            InitializeComponent();

            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return;

            AjustarTamanoComun();
            ConfigurarEventos();
            CargarNivel();
        }

        private void AjustarTamanoComun()
        {
            Size tamanoOriginal = ClientSize;
            Size tamanoComun = new Size(1560, 850);
            int moverX = (tamanoComun.Width - tamanoOriginal.Width) / 2;
            int moverY = (tamanoComun.Height - tamanoOriginal.Height) / 2;

            foreach (Control control in Controls.Cast<Control>().ToList())
            {
                control.Left += moverX;
                control.Top += moverY;
            }

            ClientSize = tamanoComun;
            MinimumSize = tamanoComun;
            StartPosition = FormStartPosition.CenterScreen;
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            using var pincel = new LinearGradientBrush(
                ClientRectangle,
                Color.FromArgb(7, 9, 34),
                Color.FromArgb(18, 14, 55),
                25F);
            e.Graphics.FillRectangle(pincel, ClientRectangle);
        }

        private void ConfigurarEventos()
        {
            btnVerificar.Click += (_, _) => Comprobar();
            btnSiguiente.Click += (_, _) => SiguienteNivel();
            btnPausa.Click += (_, _) => AlternarPausa();
            btnReiniciar.Click += (_, _) => CargarNivel();
            btnRegresar.Click += (_, _) => Close();
            btnSubir.Click += (_, _) => MoverLinea(-1);
            btnBajar.Click += (_, _) => MoverLinea(1);

            temporizador.Tick += (_, _) => ActualizarTiempo();
            lstCodigo.DrawItem += DibujarBloque;
            lstCodigo.MouseDown += IniciarArrastre;
            lstCodigo.DragOver += (_, e) => e.Effect = DragDropEffects.Move;
            lstCodigo.DragDrop += SoltarBloque;
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
            using var pincelNumero = new SolidBrush(Color.FromArgb(155, 165, 210));
            using var pincelTexto = new SolidBrush(Color.White);
            using var fuenteNumero = new Font("Consolas", 11F, FontStyle.Bold);

            e.Graphics.FillRectangle(fondoBloque, e.Bounds.X + 4, e.Bounds.Y + 4, e.Bounds.Width - 8, e.Bounds.Height - 8);
            e.Graphics.DrawString($"{e.Index + 1}", fuenteNumero, pincelNumero, e.Bounds.X + 15, e.Bounds.Y + 15);
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
            base.OnFormClosed(e);
        }

        private void tituloTiempo_Click(object sender, EventArgs e)
        {

        }

        private void MinijuegoOrdenarCodigo_Load(object sender, EventArgs e)
        {

        }
    }
}
