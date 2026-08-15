using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaAcademico1
{
    public partial class CodeNivel3 : Form
    {
        private List<string> respuestas = new List<string>();
        private string respuestaCorrecta;
        private bool cartasOcultas = false;
        private Random random = new Random();

        private int tiempo = 15;
        private int preguntaActual = 0;
        private int puntaje = 0;

        private System.Windows.Forms.Timer timerMemoria =
            new System.Windows.Forms.Timer();
        public CodeNivel3()
        {
            InitializeComponent();
            timerJuego3.Interval = 1000;
            timerJuego3.Tick += TimerJuego3_Tick;

            timerMemoria.Interval = 10000;
            timerMemoria.Tick += TimerMemoria_Tick;

            pictureBox1.Click += Carta_Click;
            pictureBox2.Click += Carta_Click;
            pictureBox3.Click += Carta_Click;
            pictureBox4.Click += Carta_Click;
            pictureBox5.Click += Carta_Click;
            pictureBox6.Click += Carta_Click;
        }
        private void TimerMemoria_Tick(object sender, EventArgs e)
        {
            timerMemoria.Stop();

            MezclarRespuestas();
            MostrarCartasReverso();

            tiempo = 15;
            lblTiempo.Text = "Tiempo: " + tiempo;

            timerJuego3.Start();
        }
        private void MezclarRespuestas()
        {
            respuestas = respuestas.OrderBy(x => random.Next()).ToList();
        }
        private void MostrarCartasReverso()
        {
            if (respuestas == null || respuestas.Count < 6)
            {
                return;
            }

            pictureBox1.Tag = respuestas[0];
            pictureBox2.Tag = respuestas[1];
            pictureBox3.Tag = respuestas[2];
            pictureBox4.Tag = respuestas[3];
            pictureBox5.Tag = respuestas[4];
            pictureBox6.Tag = respuestas[5];

            pictureBox1.Image = Properties.Resources.Volteada;
            pictureBox2.Image = Properties.Resources.Volteada;
            pictureBox3.Image = Properties.Resources.Volteada;
            pictureBox4.Image = Properties.Resources.Volteada;
            pictureBox5.Image = Properties.Resources.Volteada;
            pictureBox6.Image = Properties.Resources.Volteada;

            cartasOcultas = true;
        }
        private void MostrarImagenCarta(PictureBox carta)
        {
            string respuesta = carta.Tag.ToString();

            switch (respuesta)
            {
                case "And1":
                    carta.Image = Properties.Resources.And1;
                    break;

                case "And2":
                    carta.Image = Properties.Resources.And2;
                    break;

                case "Or1":
                    carta.Image = Properties.Resources.Or1;
                    break;

                case "Or2":
                    carta.Image = Properties.Resources.Or2;
                    break;

                case "Not1":
                    carta.Image = Properties.Resources.Not1;
                    break;

                case "Not2":
                    carta.Image = Properties.Resources.Not2;
                    break;
            }
        }
        private void PrepararPregunta()
        {
            respuestas = new List<string>
    {
        "And1",
        "And2",
        "Or1",
        "Or2",
        "Not1",
        "Not2"
    };

            if (preguntaActual == 0)
            {
                lblPregunta.Text =
                    "¿Qué expresión utiliza AND y da como resultado true?";

                respuestaCorrecta = "And1";
            }
            else if (preguntaActual == 1)
            {
                lblPregunta.Text =
                    "¿Qué expresión utiliza AND y da como resultado false?";

                respuestaCorrecta = "And2";
            }
            else if (preguntaActual == 2)
            {
                lblPregunta.Text =
                    "¿Qué expresión utiliza OR y da como resultado true?";

                respuestaCorrecta = "Or1";
            }
            else if (preguntaActual == 3)
            {
                lblPregunta.Text =
                    "¿Qué expresión utiliza OR y da como resultado false?";

                respuestaCorrecta = "Or2";
            }
            else if (preguntaActual == 4)
            {
                lblPregunta.Text =
                    "¿Qué expresión niega el valor true?";

                respuestaCorrecta = "Not1";
            }
            else if (preguntaActual == 5)
            {
                lblPregunta.Text =
                    "¿Qué expresión niega el valor false?";

                respuestaCorrecta = "Not2";
            }

            MezclarRespuestas();

            pictureBox1.Image = Properties.Resources.Volteada;
            pictureBox2.Image = Properties.Resources.Volteada;
            pictureBox3.Image = Properties.Resources.Volteada;
            pictureBox4.Image = Properties.Resources.Volteada;
            pictureBox5.Image = Properties.Resources.Volteada;
            pictureBox6.Image = Properties.Resources.Volteada;

            cartasOcultas = false;
        }
        private void TimerJuego3_Tick(object sender, EventArgs e)
        {
            tiempo--;

            lblTiempo.Text = "Tiempo: " + tiempo;

            if (tiempo <= 0)
            {
                timerJuego3.Stop();

                MessageBox.Show(
                    "Se acabó el tiempo.",
                    "TIEMPO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                btnIniciarJuego.Enabled = true;
                btnReiniciar.Enabled = true;
                cartasOcultas = false;
            }
        }
        private void Carta_Click(object sender, EventArgs e)
        {
            if (!cartasOcultas)
            {
                return;
            }

            PictureBox cartaSeleccionada = sender as PictureBox;

            if (cartaSeleccionada == null)
            {
                return;
            }

            MostrarImagenCarta(cartaSeleccionada);

            string respuestaSeleccionada =
                cartaSeleccionada.Tag.ToString();

            // RESPUESTA CORRECTA
            if (respuestaSeleccionada == respuestaCorrecta)
            {
                timerJuego3.Stop();

                // Sumar puntaje según la barra restante
                puntaje += progressBar1.Value;
                lblPuntaje.Text = "Puntaje: " + puntaje;

                cartasOcultas = false;

                MessageBox.Show(
                    "¡CORRECTO!",
                    "RESPUESTA",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                preguntaActual++;

                // Pasar a la siguiente pregunta
                if (preguntaActual < 6)
                {
                    PrepararPregunta();

                    progressBar1.Value = 100;

                    MezclarRespuestas();

                    pictureBox1.Tag = respuestas[0];
                    pictureBox2.Tag = respuestas[1];
                    pictureBox3.Tag = respuestas[2];
                    pictureBox4.Tag = respuestas[3];
                    pictureBox5.Tag = respuestas[4];
                    pictureBox6.Tag = respuestas[5];

                    MostrarImagenCarta(pictureBox1);
                    MostrarImagenCarta(pictureBox2);
                    MostrarImagenCarta(pictureBox3);
                    MostrarImagenCarta(pictureBox4);
                    MostrarImagenCarta(pictureBox5);
                    MostrarImagenCarta(pictureBox6);

                    cartasOcultas = false;

                    lblTiempo.Text = "Memoriza";

                    timerMemoria.Start();

                    btnIniciarJuego.Enabled = false;
                    btnReiniciar.Enabled = true;
                }
                else
                {
                    timerJuego3.Stop();
                    timerMemoria.Stop();

                    FrmJuegoCompletado completado = new FrmJuegoCompletado();
                    completado.Show();

                    this.Close();
                }
            }

            // RESPUESTA INCORRECTA
            else
            {
                if (progressBar1.Value >= 25)
                {
                    progressBar1.Value -= 25;
                }

                MessageBox.Show(
                    "RESPUESTA INCORRECTA",
                    "RESPUESTA",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                cartaSeleccionada.Image =
                    Properties.Resources.Volteada;

                if (progressBar1.Value > 0)
                {
                    cartasOcultas = true;
                }
                else
                {
                    timerJuego3.Stop();
                    cartasOcultas = false;

                    MessageBox.Show(
                        "Te quedaste sin intentos.\nLa respuesta correcta era: "
                        + respuestaCorrecta,
                        "FIN DEL JUEGO",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    btnIniciarJuego.Enabled = true;
                    btnReiniciar.Enabled = true;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            timerJuego3.Stop();
            timerMemoria.Stop();

            tiempo = 15;
            preguntaActual = 0;
            puntaje = 0;

            lblTiempo.Text = "Tiempo: 15";
            lblPuntaje.Text = "Puntaje: 0";

            progressBar1.Value = 100;

            PrepararPregunta();

            pictureBox1.Image = Properties.Resources.Volteada;
            pictureBox2.Image = Properties.Resources.Volteada;
            pictureBox3.Image = Properties.Resources.Volteada;
            pictureBox4.Image = Properties.Resources.Volteada;
            pictureBox5.Image = Properties.Resources.Volteada;
            pictureBox6.Image = Properties.Resources.Volteada;

            cartasOcultas = false;

            btnIniciarJuego.Enabled = true;
            btnReiniciar.Enabled = false;
        }

        private void CodeNivel3_Load(object sender, EventArgs e)
        {
            PrepararPregunta();

            btnIniciarJuego.Enabled = true;
            btnReiniciar.Enabled = false;

            timerJuego3.Stop();
            timerMemoria.Stop();

            tiempo = 15;
            lblTiempo.Text = "Tiempo: 15";

            puntaje = 0;
            lblPuntaje.Text = "Puntaje: 0";

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 100;
        }

        private void btnIniciarJuego_Click(object sender, EventArgs e)
        {
            timerJuego3.Stop();
            timerMemoria.Stop();

            puntaje = 0;
            lblPuntaje.Text = "Puntaje: 0";

            progressBar1.Value = 100;

            if (respuestas == null || respuestas.Count < 6)
            {
                PrepararPregunta();
            }

            btnIniciarJuego.Enabled = false;
            btnReiniciar.Enabled = true;

            MezclarRespuestas();

            pictureBox1.Tag = respuestas[0];
            pictureBox2.Tag = respuestas[1];
            pictureBox3.Tag = respuestas[2];
            pictureBox4.Tag = respuestas[3];
            pictureBox5.Tag = respuestas[4];
            pictureBox6.Tag = respuestas[5];

            MostrarImagenCarta(pictureBox1);
            MostrarImagenCarta(pictureBox2);
            MostrarImagenCarta(pictureBox3);
            MostrarImagenCarta(pictureBox4);
            MostrarImagenCarta(pictureBox5);
            MostrarImagenCarta(pictureBox6);

            cartasOcultas = false;

            lblTiempo.Text = "Memoriza";

            // Mostrar las cartas durante 10 segundos
            timerMemoria.Start();
        }
    }
}
