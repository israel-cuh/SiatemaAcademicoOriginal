using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemaAcademico1
{

    public partial class CodeMemo2 : Form
    {
        private List<string> respuestas = new List<string>();
        private string respuestaCorrecta;
        private bool cartasOcultas = false;
        private Random random = new Random();
        private int tiempo = 30;
        private int preguntaActual = 0;
        private int puntaje = 0;
        private System.Windows.Forms.Timer timerMemoria =
            new System.Windows.Forms.Timer();
        private Point posicion1;
        private Point posicion2;
        private Point posicion3;
        private Point posicion4;

        public CodeMemo2()
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
        }
        private void TimerMemoria_Tick(object sender, EventArgs e)
        {
            timerMemoria.Stop();

            MezclarRespuestas();
            MostrarCartasReverso();
            MezclarCartasVisualmente();

            tiempo = 30;
            lblTiempo.Text = "Tiempo: " + tiempo;

            timerJuego2.Start();
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
                    "Tiempo terminado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                btnIniciarJuego.Enabled = true;
                btnReiniciar.Enabled = true;
                cartasOcultas = false;
            }
        }

        private void PrepararPregunta()
        {
            respuestas = new List<string>
    {
        "Variable",
        "Entero",
        "Cadena",
        "Booleano"
    };

            if (preguntaActual == 0)
            {
                lblPregunta.Text =
                    "¿Qué estructura se utiliza para almacenar un valor durante la ejecución de un programa?";

                respuestaCorrecta = "Variable";
            }
            else if (preguntaActual == 1)
            {
                lblPregunta.Text =
                    "¿Qué tipo de dato se utiliza para almacenar números enteros?";

                respuestaCorrecta = "Entero";
            }
            else if (preguntaActual == 2)
            {
                lblPregunta.Text =
                    "¿Qué tipo de dato se utiliza para almacenar texto?";

                respuestaCorrecta = "Cadena";
            }
            else if (preguntaActual == 3)
            {
                lblPregunta.Text =
                    "¿Qué tipo de dato puede almacenar únicamente true o false?";

                respuestaCorrecta = "Booleano";
            }

            MezclarRespuestas();

            pictureBox1.Image = Properties.Resources.Volteada;
            pictureBox2.Image = Properties.Resources.Volteada;
            pictureBox3.Image = Properties.Resources.Volteada;
            pictureBox4.Image = Properties.Resources.Volteada;

        }
        private void MezclarRespuestas()
        {
            respuestas = respuestas.OrderBy(x => random.Next()).ToList();
        }
        private void MezclarCartasVisualmente()
        {
            List<Point> posiciones = new List<Point>
    {
        posicion1,
        posicion2,
        posicion3,
        posicion4
    };

            posiciones = posiciones.OrderBy(x => random.Next()).ToList();

            pictureBox1.Location = posiciones[0];
            pictureBox2.Location = posiciones[1];
            pictureBox3.Location = posiciones[2];
            pictureBox4.Location = posiciones[3];
        }
        private void MostrarCartasReverso()
        {
            if (respuestas == null || respuestas.Count < 4)
            {
                return;
            }
            pictureBox1.Tag = respuestas[0];
            pictureBox2.Tag = respuestas[1];
            pictureBox3.Tag = respuestas[2];
            pictureBox4.Tag = respuestas[3];

            pictureBox1.Image = Properties.Resources.Volteada;
            pictureBox2.Image = Properties.Resources.Volteada;
            pictureBox3.Image = Properties.Resources.Volteada;
            pictureBox4.Image = Properties.Resources.Volteada;

            cartasOcultas = true;
        }
        private void MostrarCartasFrente()
        {
            if (respuestas == null || respuestas.Count < 4)
                return;

            pictureBox1.Tag = respuestas[0];
            pictureBox2.Tag = respuestas[1];
            pictureBox3.Tag = respuestas[2];
            pictureBox4.Tag = respuestas[3];

            foreach (PictureBox carta in new[]
            {
        pictureBox1,
        pictureBox2,
        pictureBox3,
        pictureBox4
    })
            {
                string respuesta = carta.Tag.ToString();

                if (respuesta == "Variable")
                    carta.Image = Properties.Resources.Variable;
                else if (respuesta == "Entero")
                    carta.Image = Properties.Resources.Entero;
                else if (respuesta == "Cadena")
                    carta.Image = Properties.Resources.Cadena;
                else if (respuesta == "Booleano")
                    carta.Image = Properties.Resources.Booleano;
            }

            cartasOcultas = false;
        }
        private void MostrarImagenCarta(PictureBox carta)
        {
            string respuesta = carta.Tag.ToString();

            switch (respuesta)
            {
                case "Variable":
                    carta.Image = Properties.Resources.Variable;
                    break;
                case "Entero":
                    carta.Image = Properties.Resources.Entero;
                    break;
                case "Cadena":
                    carta.Image = Properties.Resources.Cadena;
                    break;
                case "Booleano":
                    carta.Image = Properties.Resources.Booleano;
                    break;
            }
        }
        private void Carta_Click(object sender, EventArgs e)
        {
            if (btnIniciarJuego.Enabled)
            {
                return;
            }

            PictureBox cartaSeleccionada = sender as PictureBox;

            if (cartaSeleccionada == null)
            {
                return;
            }

            // No permite escoger mientras están de frente
            if (!cartasOcultas)
            {
                return;
            }

            // Mostrar la carta escogida
            MostrarImagenCarta(cartaSeleccionada);

            cartasOcultas = false;

            string respuestaSeleccionada =
                cartaSeleccionada.Tag.ToString();

            // RESPUESTA CORRECTA
            if (respuestaSeleccionada == respuestaCorrecta)
            {
                timerJuego2.Stop();
                puntaje += progressBar1.Value;
                lblPuntaje.Text = "Puntaje: " + puntaje;

                MessageBox.Show(
                    "¡CORRECTO!",
                    "RESPUESTA",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                preguntaActual++;

                if (preguntaActual < 4)
                {
                    PrepararPregunta();

                    progressBar1.Value = 100;

                    MezclarRespuestas();

                    pictureBox1.Tag = respuestas[0];
                    pictureBox2.Tag = respuestas[1];
                    pictureBox3.Tag = respuestas[2];
                    pictureBox4.Tag = respuestas[3];

                    MostrarImagenCarta(pictureBox1);
                    MostrarImagenCarta(pictureBox2);
                    MostrarImagenCarta(pictureBox3);
                    MostrarImagenCarta(pictureBox4);

                    cartasOcultas = false;

                    lblTiempo.Text = "Memoriza";

                    timerMemoria.Start();

                    btnIniciarJuego.Enabled = false;
                    btnReiniciar.Enabled = true;
                }
                else
                {
                    MessageBox.Show(
                        "¡Nivel completado!",
                        "FELICIDADES",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    btnIniciarJuego.Enabled = false;
                    btnReiniciar.Enabled = true;
                    btnNivel2.Enabled = true;
                }
            }

            // RESPUESTA INCORRECTA
            else
            {
                MessageBox.Show(
                    "RESPUESTA INCORRECTA",
                    "RESPUESTA",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                // Volver a ocultar la carta
                cartaSeleccionada.Image =
                    Properties.Resources.Volteada;

                // Quitar 25 de vida
                if (progressBar1.Value >= 25)
                {
                    progressBar1.Value -= 25;
                }

                // Si todavía tiene vidas puede seguir intentando
                if (progressBar1.Value > 0)
                {
                    cartasOcultas = true;
                }
                else
                {
                    // Se quedó sin vidas
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
        private void MostrarRespuestas()
        {
            if (respuestas == null || respuestas.Count() < 4)
            {
                MessageBox.Show("");
                return;
            }


            // pictureBox1.Image = Properties.Resources.Variable;
            pictureBox2.Image = Properties.Resources.lapto;
            //pictureBox3.Image = Properties.Resources.
            pictureBox4.Image = Properties.Resources.profesor;

            /*pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;

            pictureBox1.BackColor = Color.White;
            pictureBox2.BackColor = Color.White;
            pictureBox3.BackColor = Color.White;
            pictureBox4.BackColor = Color.White;*/

            cartasOcultas = false;

        }
        private void CodeMemo2_Load(object sender, EventArgs e)
        {
            PrepararPregunta();
            btnIniciarJuego.Enabled = true;
            btnReiniciar.Enabled = false;

            timerJuego2.Interval = 1000;
            timerJuego2.Stop();

            lblTiempo.Text = "Tiempo: 30";

            // Barra de vidas
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 100;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnIniciarJuego_Click(object sender, EventArgs e)
        {

            timerJuego2.Stop();
            timerMemoria.Stop();

            puntaje = 0;
            lblPuntaje.Text = "Puntaje: 0";

            if (respuestas == null || respuestas.Count < 4)
            {
                PrepararPregunta();
            }

            btnIniciarJuego.Enabled = false;
            btnReiniciar.Enabled = true;

            // Barra llena al iniciar una partida
            progressBar1.Value = 100;

            // Guardar posiciones reales de las cartas
            posicion1 = pictureBox1.Location;
            posicion2 = pictureBox2.Location;
            posicion3 = pictureBox3.Location;
            posicion4 = pictureBox4.Location;


            // Mezclar las respuestas
            MezclarRespuestas();

            // Asignar una respuesta a cada carta
            pictureBox1.Tag = respuestas[0];
            pictureBox2.Tag = respuestas[1];
            pictureBox3.Tag = respuestas[2];
            pictureBox4.Tag = respuestas[3];

            // Mostrar directamente el contenido de cada carta
            MostrarImagenCarta(pictureBox1);
            MostrarImagenCarta(pictureBox2);
            MostrarImagenCarta(pictureBox3);
            MostrarImagenCarta(pictureBox4);

            cartasOcultas = false;

            lblTiempo.Text = "Memoriza";

            // Comenzar los 10 segundos
            timerMemoria.Start();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            timerJuego2.Stop();
            timerMemoria.Stop();

            tiempo = 30;

            lblTiempo.Text = "Tiempo: 30";

            // Recuperar todas las vidas
            progressBar1.Value = 100;

            // Regresar cartas a sus posiciones
            pictureBox1.Location = posicion1;
            pictureBox2.Location = posicion2;
            pictureBox3.Location = posicion3;
            pictureBox4.Location = posicion4;

            // Mostrar todas las cartas volteadas
            pictureBox1.Image = Properties.Resources.Volteada;
            pictureBox2.Image = Properties.Resources.Volteada;
            pictureBox3.Image = Properties.Resources.Volteada;
            pictureBox4.Image = Properties.Resources.Volteada;

            cartasOcultas = false;

            btnIniciarJuego.Enabled = true;
            btnReiniciar.Enabled = false;
        }

        private void btnNivel2_Click(object sender, EventArgs e)
        {
            CodeNivel2 nivel2 = new CodeNivel2();
            nivel2.Show();
            this.Close();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Menuvariables menu = new Menuvariables();
            menu.Show();
            this.Close();
        }
    }
}
