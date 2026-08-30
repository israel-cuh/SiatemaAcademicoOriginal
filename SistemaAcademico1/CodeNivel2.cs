using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaAcademico1
{
    public partial class CodeNivel2 : Form
    {
        private List<string> respuestas = new List<string>();
        private string respuestaCorrecta;
        private bool cartasOcultas = false;
        private Random random = new Random();

        private int tiempo = 20;
        private int preguntaActual = 0;
        private int puntaje = 0;

        private System.Windows.Forms.Timer timerMemoria =
            new System.Windows.Forms.Timer();
        public CodeNivel2()
        {
            InitializeComponent();
            timerJuego2.Interval = 1000;
            timerJuego2.Tick += TimerJuego2_Tick;

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

            tiempo = 20;
            lblTiempo.Text = "Tiempo: " + tiempo;

            timerJuego2.Start();
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
                case "Int":
                    carta.Image = Properties.Resources.CartaInt2;
                    break;

                case "Double":
                    carta.Image = Properties.Resources.CartaDouble2;
                    break;

                case "String":
                    carta.Image = Properties.Resources.CartaString2;
                    break;

                case "Char":
                    carta.Image = Properties.Resources.CartaChar2;
                    break;

                case "Bool":
                    carta.Image = Properties.Resources.CartaBool2;
                    break;

                case "Float":
                    carta.Image = Properties.Resources.CartaFloat2;
                    break;
            }
        }
        private void TimerJuego2_Tick(object sender, EventArgs e)
        {
            tiempo--;

            lblTiempo.Text = "Tiempo: " + tiempo;

            if (tiempo <= 0)
            {
                timerJuego2.Stop();

                MessageBox.Show(
                    "Se acabó el tiempo.",
                    "TIEMPO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
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
                timerJuego2.Stop();

                // Sumar puntaje según la vida restante
                puntaje += progressBar1.Value;
                lblPuntaje.Text = "Puntaje: " + puntaje;

                cartasOcultas = false;

                MessageBox.Show(
                    "¡CORRECTO!",
                    "RESPUESTA",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // Pasar a la siguiente pregunta
                preguntaActual++;

                if (preguntaActual < 6)
                {
                    PrepararPregunta();

                    // Recuperar la barra para la nueva pregunta
                    progressBar1.Value = 100;

                    MezclarRespuestas();

                    // Asignar las nuevas posiciones
                    pictureBox1.Tag = respuestas[0];
                    pictureBox2.Tag = respuestas[1];
                    pictureBox3.Tag = respuestas[2];
                    pictureBox4.Tag = respuestas[3];
                    pictureBox5.Tag = respuestas[4];
                    pictureBox6.Tag = respuestas[5];

                    // Mostrar las 6 cartas
                    MostrarImagenCarta(pictureBox1);
                    MostrarImagenCarta(pictureBox2);
                    MostrarImagenCarta(pictureBox3);
                    MostrarImagenCarta(pictureBox4);
                    MostrarImagenCarta(pictureBox5);
                    MostrarImagenCarta(pictureBox6);

                    cartasOcultas = false;

                    lblTiempo.Text = "Memoriza";

                    // Esperar nuevamente los 10 segundos
                    timerMemoria.Start();

                    btnIniciarJuego.Enabled = false;
                    btnReiniciar.Enabled = true;
                }
                else
                {
                    // Terminó las 6 preguntas
                    timerJuego2.Stop();
                    timerMemoria.Stop();

                    MessageBox.Show(
                        "¡Nivel 2 completado!",
                        "FELICIDADES",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    btnIniciarJuego.Enabled = false;
                    btnReiniciar.Enabled = true;

                    // Desbloquear Nivel 3
                    btnNivel3.Enabled = true;
                }
            }

            // RESPUESTA INCORRECTA
            else
            {
                // Quitar 25 de vida
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

                // Volver a ocultar la carta incorrecta
                cartaSeleccionada.Image =
                    Properties.Resources.Volteada;

                // Todavía tiene intentos
                if (progressBar1.Value > 0)
                {
                    cartasOcultas = true;
                }

                // Se acabaron los intentos
                else
                {
                    timerJuego2.Stop();
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
        private void PrepararPregunta()
        {
            respuestas = new List<string>
    {
        "Int",
        "Double",
        "String",
        "Char",
        "Bool",
        "Float"
    };

            if (preguntaActual == 0)
            {
                lblPregunta.Text =
                    "¿Qué tipo de dato se utiliza para almacenar números enteros?";

                respuestaCorrecta = "Int";
            }
            else if (preguntaActual == 1)
            {
                lblPregunta.Text =
                    "¿Qué tipo de dato se utiliza para almacenar números con decimales?";

                respuestaCorrecta = "Double";
            }
            else if (preguntaActual == 2)
            {
                lblPregunta.Text =
                    "¿Qué tipo de dato se utiliza para almacenar texto?";

                respuestaCorrecta = "String";
            }
            else if (preguntaActual == 3)
            {
                lblPregunta.Text =
                    "¿Qué tipo de dato se utiliza para almacenar un solo carácter?";

                respuestaCorrecta = "Char";
            }
            else if (preguntaActual == 4)
            {
                lblPregunta.Text =
                    "¿Qué tipo de dato almacena valores true o false?";

                respuestaCorrecta = "Bool";
            }
            else if (preguntaActual == 5)
            {
                lblPregunta.Text =
                    "¿Qué tipo de dato decimal utiliza el sufijo f en C#?";

                respuestaCorrecta = "Float";
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void CodeNivel2_Load(object sender, EventArgs e)
        {
            PrepararPregunta();

            btnIniciarJuego.Enabled = true;
            btnReiniciar.Enabled = false;

            timerJuego2.Stop();
            timerMemoria.Stop();

            tiempo = 20;
            lblTiempo.Text = "Tiempo: 20";

            puntaje = 0;
            lblPuntaje.Text = "Puntaje: 0";

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 100;

        }

        private void btnIniciarJuego_Click(object sender, EventArgs e)
        {
            timerJuego2.Stop();
            timerMemoria.Stop();

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

            timerMemoria.Start();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            timerJuego2.Stop();
            timerMemoria.Stop();

            tiempo = 20;
            preguntaActual = 0;
            puntaje = 0;

            lblTiempo.Text = "Tiempo: 20";
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

        private void btnNivel3_Click(object sender, EventArgs e)
        {
            CodeNivel3 nivel3 = new CodeNivel3();
            nivel3.Show();
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            CodeMemo2 nivel1 = new CodeMemo2();
            nivel1.Show();
            this.Close();
        }
    }
}
