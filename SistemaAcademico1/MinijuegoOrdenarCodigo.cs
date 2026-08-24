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
                "Salida simple",
                "Ordena una instrucción básica de salida en consola.",
                new[] { "Console.WriteLine(\"Hola CodeNova\");" },
                "Es un nivel de calentamiento: solo debe quedar la instrucción de impresión.",
                "WriteLine muestra un mensaje en la consola. Este nivel sirve para reconocer una instrucción completa."
            ),
            new Ejercicio(
                "Variable y salida",
                "Ordena el código para guardar un nombre y luego mostrarlo.",
                new[] { "string nombre = \"Ana\";", "Console.WriteLine(nombre);" },
                "Primero se crea la variable y después se usa en pantalla.",
                "Una variable debe existir antes de poder utilizarse. Por eso la declaración va antes del WriteLine."
            ),
            new Ejercicio(
                "Condición if",
                "Ordena el código para comprobar si una nota está aprobada.",
                new[] { "int nota = 8;", "if (nota >= 7)", "{", "    Console.WriteLine(\"Aprobado\");", "}" },
                "Declara la nota, evalúa la condición y coloca la instrucción dentro de las llaves.",
                "El if ejecuta su bloque solamente cuando la condición es verdadera."
            ),
            new Ejercicio(
                "Condición if else",
                "Ordena el código para mostrar si un estudiante aprobó o reprobó.",
                new[] { "int nota = 5;", "if (nota >= 7)", "{", "    Console.WriteLine(\"Aprobado\");", "}", "else", "{", "    Console.WriteLine(\"Reprobado\");", "}" },
                "El else siempre va después de cerrar el bloque del if.",
                "if else permite tener dos caminos: uno cuando la condición se cumple y otro cuando no se cumple."
            ),
            new Ejercicio(
                "Ciclo while",
                "Ordena los bloques para imprimir los números del 1 al 5 con while.",
                new[] { "int i = 1;", "while (i <= 5)", "{", "    Console.WriteLine(i);", "    i++;", "}" },
                "Primero inicializa i. Dentro del ciclo imprime y luego incrementa.",
                "El while repite el bloque mientras la condición sea verdadera. El incremento evita un ciclo infinito."
            ),
            new Ejercicio(
                "Ciclo do while",
                "Ordena el código para ejecutar un bloque al menos una vez.",
                new[] { "int i = 1;", "do", "{", "    Console.WriteLine(i);", "    i++;", "}", "while (i <= 5);" },
                "En do while el bloque aparece antes de la condición final.",
                "do while evalúa la condición al final, por eso siempre ejecuta el bloque al menos una vez."
            ),
            new Ejercicio(
                "Ciclo for",
                "Ordena los bloques para imprimir los números del 0 al 4 con for.",
                new[] { "for (int i = 0; i < 5; i++)", "{", "    Console.WriteLine(i);", "}" },
                "El encabezado del for debe aparecer antes de las llaves.",
                "El ciclo for reúne inicialización, condición e incremento en una sola línea."
            ),
            new Ejercicio(
                "Switch básico",
                "Ordena el código para mostrar el nombre de un día usando switch.",
                new[] { "int dia = 2;", "switch (dia)", "{", "    case 1:", "        Console.WriteLine(\"Lunes\");", "        break;", "    case 2:", "        Console.WriteLine(\"Martes\");", "        break;", "}" },
                "Cada case tiene sus instrucciones y normalmente termina con break.",
                "switch permite elegir entre varias opciones según el valor de una variable."
            ),
            new Ejercicio(
                "For con if else",
                "Ordena el código para recorrer números y clasificar pares e impares.",
                new[] { "for (int i = 1; i <= 5; i++)", "{", "    if (i % 2 == 0)", "    {", "        Console.WriteLine(\"Par\");", "    }", "    else", "    {", "        Console.WriteLine(\"Impar\");", "    }", "}" },
                "El if else va dentro del for. Cuida bien el orden de las llaves.",
                "Este nivel combina repetición y decisión: por cada número se decide si es par o impar."
            ),
            new Ejercicio(
                "Desafío final",
                "Ordena el algoritmo completo: ciclo, decisión y switch trabajando juntos.",
                new[] { "for (int i = 1; i <= 3; i++)", "{", "    if (i == 1)", "    {", "        Console.WriteLine(\"Inicio\");", "    }", "    else", "    {", "        switch (i)", "        {", "            case 2:", "                Console.WriteLine(\"Proceso\");", "                break;", "            case 3:", "                Console.WriteLine(\"Final\");", "                break;", "        }", "    }", "}" },
                "Primero arma el for, luego el if, después el else y dentro de ese else coloca el switch completo.",
                "El desafío final mezcla for, if else y switch. Es más largo porque simula un flujo real de programa."
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
            ControlesVentanaHelper.Agregar(this, cerrarAplicacion: false);
            ConfigurarEventos();
            progreso.Maximum = ejercicios.Count;
            CargarNivel();
        }

        private void AjustarTamanoComun()
        {
            Size tamanoComun = new Size(1560, 850);
            ClientSize = tamanoComun;
            MinimumSize = tamanoComun;
            StartPosition = FormStartPosition.CenterScreen;

            tarjetaTiempo.Location = new Point(40, 25);
            tituloPrincipal.Location = new Point(430, 28);
            tituloPrincipal.Size = new Size(700, 50);
            subtitulo.Location = new Point(430, 80);
            subtitulo.Size = new Size(700, 30);
            tarjetaPuntos.Location = new Point(1290, 25);
            btnPausa.Location = new Point(1500, 38);

            contenedor.Location = new Point(40, 135);
            contenedor.Size = new Size(1480, 570);

            panelLateral.Location = new Point(22, 22);
            panelLateral.Size = new Size(330, 526);
            lblNivel.Size = new Size(285, 78);
            lblInstruccion.Size = new Size(285, 75);
            cajaPista.Size = new Size(292, 145);
            lblPista.Size = new Size(262, 88);
            btnReiniciar.Location = new Point(20, 455);
            btnRegresar.Location = new Point(170, 455);

            panelCodigo.Location = new Point(375, 22);
            panelCodigo.Size = new Size(1080, 526);
            tituloBloques.Location = new Point(25, 18);
            ayudaArrastre.Location = new Point(650, 20);
            ayudaArrastre.Size = new Size(390, 26);
            lstCodigo.Location = new Point(25, 60);
            lstCodigo.Size = new Size(930, 350);
            btnSubir.Location = new Point(980, 110);
            btnBajar.Location = new Point(980, 180);
            lblResultado.Location = new Point(25, 438);
            lblResultado.Size = new Size(1010, 60);

            lblProgreso.Location = new Point(45, 735);
            progreso.Location = new Point(45, 762);
            progreso.Size = new Size(640, 20);
            btnSiguiente.Location = new Point(940, 748);
            btnVerificar.Location = new Point(1230, 742);
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

            progreso.Maximum = ejercicios.Count;
            lblNivel.Text = $"NIVEL {nivelActual + 1}\n{ejercicio.Titulo}";
            lblInstruccion.Text = ejercicio.Instruccion;
            lblPista.Text = ejercicio.Pista;
            lblResultado.Text = "Selecciona y arrastra los bloques hasta completar el código.";
            lblResultado.ForeColor = Color.LightSkyBlue;
            lblProgreso.Text = $"PROGRESO  ·  NIVEL {nivelActual + 1} DE {ejercicios.Count}";
            progreso.Value = nivelActual;

            var lineas = ejercicio.Solucion.ToList();
            if (lineas.Count > 1)
            {
                do
                {
                    lineas = lineas.OrderBy(_ => random.Next()).ToList();
                }
                while (lineas.SequenceEqual(ejercicio.Solucion));
            }

            lstCodigo.Items.Clear();
            foreach (string linea in lineas)
                lstCodigo.Items.Add(linea);

            lstCodigo.SelectedIndex = lstCodigo.Items.Count > 0 ? 0 : -1;
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
                Color.FromArgb(115, 62, 53),
                Color.FromArgb(85, 52, 120)
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

        private void lstCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblTiempo_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {

        }
    }
}
