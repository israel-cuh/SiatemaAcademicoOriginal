using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;

namespace SistemaAcademico1
{
    public partial class ahorcadocs : Form
    {
        string[] palabras =
        {
            "DATOS",
            "CICLO",
            "VARIABLE",
            "FORMULARIO",
            "EVENTO",
            "CONTROL",
            "DELEGADO",
            "HERENCIA",
            "POLIMORFISMO"
        };

        string[] pistas =
        {
            "Información que usa un programa.",
            "Repite instrucciones varias veces.",
            "Guarda un valor que puede cambiar.",
            "Ventana principal de una aplicación.",
            "Ocurre cuando el usuario realiza una acción.",
            "Elemento que permite interactuar con la aplicación.",
            "Guarda una referencia a un método.",
            "Permite crear una clase basada en otra.",
            "Permite usar un mismo método de distintas formas."
        };

        int palabraActual = 0;
        string palabraMostrada = "";

        // ==========================================
        // VARIABLES PARA LAS IMÁGENES Y FALLOS
        // ==========================================
        int fallos = 0;
        Image[] imagenesAhorcado;

        // ==========================================
        // VARIABLE PARA EL CRONÓMETRO
        // ==========================================
        int tiempoRestante = 40;

        // ==========================================
        // VARIABLES PARA LAS VIDAS Y LAS ESTRELLAS
        // ==========================================
        int vidas = 3;
        int estrellas = 10;

        public ahorcadocs()
        {
            InitializeComponent();

            // Cargar tus 7 imágenes guardadas en Recursos
            imagenesAhorcado = new Image[]
            {
               Properties.Resources.primera,
                Properties.Resources.segunda,
                Properties.Resources.tercera,
                Properties.Resources.cuarta,
                Properties.Resources.quinta,
                Properties.Resources.sexta,
                Properties.Resources.sectima,
            };

            // Conectar el evento del temporizador
            timer1.Tick += new EventHandler(timer1_Tick);
        }

        // ==========================================
        // CORRECCIÓN: DETENER TIMER AL SALIR O CERRAR
        // ==========================================
        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (!this.Visible && timer1 != null)
            {
                timer1.Stop(); // Apaga el temporizador si el formulario se oculta (Hide)
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (timer1 != null)
            {
                timer1.Stop(); // Apaga el temporizador si se cierra la ventana
            }
            base.OnFormClosing(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // DETENER EL RELOJ AL SALIR
            timer1.Stop();

            frmPrincipal fmr = new frmPrincipal();
            fmr.Show();
            Hide();
        }

        private void ahorcadocs_Load(object sender, EventArgs e)
        {
            // Ajustar el PictureBox principal del ahorcado
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            // CONFIGURACIÓN UNIFORME DE LOS 3 CORAZONES
            if (picVida1 != null)
            {
                picVida1.SizeMode = PictureBoxSizeMode.Zoom;
                picVida1.BackColor = Color.Transparent;
                picVida1.BorderStyle = BorderStyle.None;
            }
            if (picVida2 != null)
            {
                picVida2.SizeMode = PictureBoxSizeMode.Zoom;
                picVida2.BackColor = Color.Transparent;
                picVida2.BorderStyle = BorderStyle.None;
            }
            if (picVida3 != null)
            {
                picVida3.SizeMode = PictureBoxSizeMode.Zoom;
                picVida3.BackColor = Color.Transparent;
                picVida3.BorderStyle = BorderStyle.None;
            }

            // Mostrar los 3 corazones llenos y el puntaje al iniciar
            ActualizarCorazones();
            ActualizarPuntajeUI();

            CrearTeclado();
            MostrarPalabra();
        }

        // ==========================================
        // ACTUALIZAR IMÁGENES DE LOS CORAZONES
        // ==========================================
        private void ActualizarCorazones()
        {
            // Usar ResourceManager.GetObject evita referencias a propiedades fuertemente tipadas inexistentes.
            var rm = Properties.Resources.ResourceManager;
            if (picVida1 != null) picVida1.Image = (vidas >= 1) ? (Image)rm.GetObject("lleno") : (Image)rm.GetObject("vacio");
            if (picVida2 != null) picVida2.Image = (vidas >= 2) ? (Image)rm.GetObject("lleno") : (Image)rm.GetObject("vacio");
            if (picVida3 != null) picVida3.Image = (vidas >= 3) ? (Image)rm.GetObject("lleno") : (Image)rm.GetObject("vacio");
        }

        // ==========================================
        // ACTUALIZAR NUMERO Y COLOR DE LA ESTRELLA
        // ==========================================
        private void ActualizarPuntajeUI()
        {
            if (lblPuntos != null)
            {
                lblPuntos.Text = estrellas.ToString();
            }

            if (lblEstrella != null)
            {
                if (estrellas >= 8)
                {
                    lblEstrella.ForeColor = Color.Gold;
                }
                else
                {
                    lblEstrella.ForeColor = Color.Red;
                }
            }
        }

        // ==========================================
        // EVALUACIÓN AL FINALIZAR EL JUEGO (SOLO AL COMPLETAR)
        // ==========================================
        private void EvaluacionFinal()
        {
            if (estrellas >= 8)
            {
                MessageBox.Show($"¡Excelente! Obtuviste {estrellas} estrellas. 🏆 ¡Dominas muy bien el tema!", "¡Felicitaciones!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Obtuviste {estrellas} estrellas. 📚 ¡Buen intento, pero repasa más los temas para obtener un mejor puntaje!", "¡A estudiar!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ==========================================
        // REINICIAR TODO EL JUEGO AL INICIO / GAME OVER
        // ==========================================
        private void ReiniciarJuego()
        {
            timer1.Stop();
            palabraActual = 0;
            vidas = 3;
            estrellas = 10;

            ActualizarCorazones();
            ActualizarPuntajeUI();
            MostrarPalabra(); // Carga primera palabra, restablece interfaz y deja reloj congelado en 40s
        }

        // ==========================================
        // LÓGICA DEL CRONÓMETRO (SE EJECUTA CADA SEGUNDO)
        // ==========================================
        private void timer1_Tick(object sender, EventArgs e)
        {
            // CORRECCIÓN: Si el formulario no está visible, detiene inmediatamente el reloj
            if (!this.Visible)
            {
                timer1.Stop();
                return;
            }

            if (tiempoRestante > 0)
            {
                tiempoRestante--;
                lblTiempo.Text = $"00:{tiempoRestante:D2}";

                if (tiempoRestante <= 10)
                {
                    lblTiempo.ForeColor = Color.Red;
                }
            }
            else
            {
                timer1.Stop();
                vidas--;
                if (estrellas > 0) estrellas--;

                ActualizarCorazones();
                ActualizarPuntajeUI();

                if (vidas > 0)
                {
                    MessageBox.Show($"¡Tiempo agotado! Pierdes 1 vida. Te quedan {vidas}. La palabra era: {palabras[palabraActual]}", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    palabraActual++;

                    if (palabraActual < palabras.Length)
                    {
                        MostrarPalabra();
                    }
                    else
                    {
                        MessageBox.Show("¡Juego terminado!", "Fin del juego");
                        EvaluacionFinal();
                        ReiniciarJuego();
                    }
                }
                else
                {
                    // CORREGIDO: Se elimina EvaluacionFinal() en Game Over
                    MessageBox.Show($"¡Tiempo agotado y te quedaste sin vidas! GAME OVER. Obtuviste {estrellas} estrellas. 📚 ¡Debes repasar los temas e intentarlo de nuevo!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ReiniciarJuego();
                }
            }
        }

        private void CrearTeclado()
        {
            string letras = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            foreach (char letra in letras)
            {
                Button boton = new Button();

                boton.Text = letra.ToString();
                boton.Tag = letra.ToString();

                boton.Width = 45;
                boton.Height = 40;
                boton.Font = new Font("Arial", 12, FontStyle.Bold);

                boton.Click += BotonLetra_Click;

                panelTeclado.Controls.Add(boton);
            }
        }

        private void MostrarPalabra()
        {
            // Detener y pausar el cronómetro a 40 segundos
            timer1.Stop();
            tiempoRestante = 40;
            lblTiempo.Text = "00:40";
            lblTiempo.ForeColor = Color.Black;

            // Reiniciar fallos e imagen inicial al comenzar una palabra
            fallos = 0;
            if (imagenesAhorcado != null && imagenesAhorcado.Length > 0)
            {
                pictureBox1.Image = imagenesAhorcado[0];
            }

            string palabra = palabras[palabraActual];

            palabraMostrada = "";

            foreach (char letra in palabra)
            {
                palabraMostrada += "_";
            }

            MostrarGuiones();

            lblPista.Text = pistas[palabraActual];

            ReiniciarTeclado();

            ActualizarNivel();
        }

        private void MostrarGuiones()
        {
            string texto = "";

            foreach (char letra in palabraMostrada)
            {
                texto += letra + " ";
            }

            lblPalabra.Text = texto;
        }

        private void ReiniciarTeclado()
        {
            foreach (Control control in panelTeclado.Controls)
            {
                Button boton = control as Button;

                if (boton != null)
                {
                    boton.Enabled = true;
                    boton.BackColor = SystemColors.Control;
                }
            }
        }

        private void BotonLetra_Click(object sender, EventArgs e)
        {
            // SI EL TIEMPO ESTÁ PAUSADO, INICIA AL APRETAR LA PRIMERA TECLA
            if (!timer1.Enabled)
            {
                timer1.Start();
            }

            Button boton = (Button)sender;

            string letra = boton.Tag.ToString();

            string palabra = palabras[palabraActual];

            bool encontrada = false;

            for (int i = 0; i < palabra.Length; i++)
            {
                if (palabra[i].ToString() == letra)
                {
                    palabraMostrada = palabraMostrada.Remove(i, 1);
                    palabraMostrada = palabraMostrada.Insert(i, letra);

                    encontrada = true;
                }
            }

            if (encontrada)
            {
                boton.BackColor = Color.Green;
            }
            else
            {
                boton.BackColor = Color.Red;

                // ==========================================
                // CAMBIO DE IMAGEN AL EQUIVOCARSE
                // ==========================================
                fallos++;

                if (fallos < imagenesAhorcado.Length)
                {
                    pictureBox1.Image = imagenesAhorcado[fallos];
                }

                // Si llega al límite de 6 fallos (7ma imagen)
                if (fallos == 6)
                {
                    timer1.Stop();
                    vidas--;
                    if (estrellas > 0) estrellas--;

                    ActualizarCorazones();
                    ActualizarPuntajeUI();

                    if (vidas > 0)
                    {
                        MessageBox.Show($"¡Te ahorcaron! Pierdes 1 vida. Te quedan {vidas}. La palabra era: {palabras[palabraActual]}", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        palabraActual++;

                        if (palabraActual < palabras.Length)
                        {
                            MostrarPalabra();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("¡Juego terminado!", "Fin del juego");
                            EvaluacionFinal();
                            ReiniciarJuego();
                            return;
                        }
                    }
                    else
                    {
                        // CORREGIDO: Se elimina EvaluacionFinal() en Game Over
                        MessageBox.Show($"¡Te ahorcaron! Te quedaste sin vidas. La palabra era: {palabras[palabraActual]}. 📚 ¡Debes repasar los temas e intentarlo de nuevo!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ReiniciarJuego();
                        return;
                    }
                }
            }

            boton.Enabled = false;

            MostrarGuiones();

            ComprobarPalabra();
        }

        private void DeshabilitarTeclado()
        {
            foreach (Control control in panelTeclado.Controls)
            {
                Button boton = control as Button;
                if (boton != null)
                {
                    boton.Enabled = false;
                }
            }
        }

        private void ComprobarPalabra()
        {
            if (palabraMostrada == palabras[palabraActual])
            {
                timer1.Stop();
                MessageBox.Show("¡Palabra completada!");

                palabraActual++;

                if (palabraActual < palabras.Length)
                {
                    MostrarPalabra();
                }
                else
                {
                    MessageBox.Show("¡Felicidades! Has completado todos los niveles.");
                    EvaluacionFinal();
                    ReiniciarJuego();
                }
            }
        }

        private void ActualizarNivel()
        {
            if (palabraActual < 3)
            {
                label7.Text = "NIVEL 1";
                label8.Text = "FÁCIL";
            }
            else if (palabraActual < 6)
            {
                label7.Text = "NIVEL 2";
                label8.Text = "MEDIO";
            }
            else
            {
                label7.Text = "NIVEL 3";
                label8.Text = "DIFÍCIL";
            }
        }

        private void lblTiempo_Click(object sender, EventArgs e)
        {

        }

        private void picVida1_Click(object sender, EventArgs e)
        {

        }
    }
}