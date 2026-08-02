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
        private int tiempo = 20;
        public CodeMemo2()
        {
            InitializeComponent();
            timerJuego2.Interval = 1000;
            // timerJuego2.Tick += TimerJuego2_Tick;

            pictureBox1.Click += PictureBox1_Click;
            pictureBox2.Click += PictureBox2_Click;
            pictureBox3.Click += PictureBox3_Click;
            pictureBox4.Click += PictureBox4_Click;
        }

        private void PrepararPregunta()
        {
            lblPregunta.Text = "¿Qué estructura se utiliza para almacenar un valor durante la ejecución de un programa?";
            respuestas = new List<string>
            {
                "Variable",
                "Entero",
                "Cadena",
                "Booleano"
            };
            respuestaCorrecta = "Variable";
            MezclarRespuestas();
            MostrarCartasReverso();

        }
        private void MezclarRespuestas()
        {
            respuestas = respuestas.OrderBy(x => random.Next()).ToList();
        }
        private void MostrarCartasReverso()
        {
            if(respuestas==null||respuestas.Count<4)
            {
                return;
            }
            pictureBox1.Tag = respuestas[0];
            pictureBox2.Tag = respuestas[1];
            pictureBox3.Tag = respuestas[2];
            pictureBox4.Tag = respuestas[3];

            pictureBox1.Image = Properties.Resources.Volteada;
            pictureBox2.Image= Properties.Resources.Volteada;
            pictureBox3.Image= Properties.Resources.Volteada;
            pictureBox4.Image= Properties.Resources.Volteada;

            cartasOcultas = true;
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
            if (!cartasOcultas)
            {
                return;
            }
            MostrarImagenCarta(cartaSeleccionada);
            cartasOcultas = false;
            string respuestaSeleccionada = cartaSeleccionada.Tag.ToString();
            if (respuestaSeleccionada == respuestaCorrecta)
            {
                timerJuego2.Stop();
                MessageBox.Show("CORRECTO", "RESPUESTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnIniciarJuego.Enabled = true;
                btnReiniciar.Enabled = true;
            }
            else
            {
                MessageBox.Show("RESPUESTA INCORRECTA", "RESPUESTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cartaSeleccionada.Image = Properties.Resources.Volteada;
                cartasOcultas = true;
            }
        }

        private void PictureBox4_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void PictureBox3_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void PictureBox2_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void PictureBox1_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

       
        private void MostrarRespuestas()
        {
            if(respuestas==null || respuestas.Count()<4)
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
            lblTiempo.Text = "Tiempo:20";
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnIniciarJuego_Click(object sender, EventArgs e)
        {
            tiempo = 20;
            lblTiempo.Text = "Tiempo:" + tiempo;
            btnIniciarJuego.Enabled = false;
            btnReiniciar.Enabled = true;
            MezclarRespuestas();
            MostrarCartasReverso();
            timerJuego2.Start();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            timerJuego2.Stop();
            tiempo = 20;
            lblTiempo.Text = "Tiempo:" + tiempo;
            btnIniciarJuego.Enabled = true;
            btnReiniciar.Enabled = false;
            MezclarRespuestas();
            MostrarCartasReverso();

            cartasOcultas = true;
        }

    }
}
