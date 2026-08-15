using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaAcademico1
{
    public partial class FrmTiposDatos : Form
    {
        Control puntoSeleccionado = null;

        Dictionary<Control, Control> conexiones =
            new Dictionary<Control, Control>();
        bool comprobado = false;

        public FrmTiposDatos()
        {
            InitializeComponent();
        }

        private void lblRegresar_Click(object sender, EventArgs e)
        {
            pnlRegresar_Click(sender, e);
        }

        private void pnlRegresar_Click(object sender, EventArgs e)
        {
            Menuvariables menu = new Menuvariables();
            menu.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnComprobar_Click(object sender, EventArgs e)
        {
            if (conexiones.Count < 5)
            {
                lblResultado.Text = "Debes realizar las 5 conexiones antes de comprobar.";
                lblResultado.ForeColor = Color.Orange;
                return;
            }

            int correctas = 0;

            if (conexiones.ContainsKey(btnPunto18) &&
                conexiones[btnPunto18] == btnPuntoInt)
                correctas++;

            if (conexiones.ContainsKey(btnPuntoMaria) &&
                conexiones[btnPuntoMaria] == btnPuntoString)
                correctas++;

            if (conexiones.ContainsKey(btnPunto95) &&
                conexiones[btnPunto95] == btnPuntoDouble)
                correctas++;

            if (conexiones.ContainsKey(btnPuntoA) &&
                conexiones[btnPuntoA] == btnPuntoChar)
                correctas++;

            if (conexiones.ContainsKey(btnPuntoTrue) &&
                conexiones[btnPuntoTrue] == btnPuntoBool)
                correctas++;

            comprobado = true;

            pnlConexiones.Invalidate();

            if (correctas == 5)
            {
                lblResultado.Text = "✓ ¡Excelente! 5/5 relaciones correctas.";
                lblResultado.ForeColor = Color.LimeGreen;
            }
            else
            {
                lblResultado.Text = "Tienes " + correctas + "/5 relaciones correctas.";
                lblResultado.ForeColor = Color.Orange;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lbl95_Click(object sender, EventArgs e)
        {

        }

        private void PuntoIzquierda_Click(object sender, EventArgs e)
        {
            puntoSeleccionado = (Control)sender;

        }

        private void PuntoDerecha_Click(object sender, EventArgs e)
        {
            if (puntoSeleccionado == null)
                return;

            Control puntoDerecha = (Control)sender;

            conexiones[puntoSeleccionado] = puntoDerecha;

            puntoSeleccionado = null;

            pnlConexiones.Invalidate();
        }

        private void pnlConexiones_Paint(object sender, PaintEventArgs e)
        {
            foreach (var conexion in conexiones)
            {
                Control izquierda = conexion.Key;
                Control derecha = conexion.Value;

                Color colorLinea = Color.DeepSkyBlue;

                if (comprobado)
                {
                    bool correcta = false;

                    if (izquierda == btnPunto18 && derecha == btnPuntoInt)
                        correcta = true;
                    else if (izquierda == btnPuntoMaria && derecha == btnPuntoString)
                        correcta = true;
                    else if (izquierda == btnPunto95 && derecha == btnPuntoDouble)
                        correcta = true;
                    else if (izquierda == btnPuntoA && derecha == btnPuntoChar)
                        correcta = true;
                    else if (izquierda == btnPuntoTrue && derecha == btnPuntoBool)
                        correcta = true;

                    colorLinea = correcta ? Color.LimeGreen : Color.Red;
                }

                using (Pen lapiz = new Pen(colorLinea, 3))
                {
                    Point inicio = new Point(
                        izquierda.Left + izquierda.Width / 2,
                        izquierda.Top + izquierda.Height / 2
                    );

                    Point fin = new Point(
                        derecha.Left + derecha.Width / 2,
                        derecha.Top + derecha.Height / 2
                    );

                    e.Graphics.DrawLine(lapiz, inicio, fin);
                }
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            FrmTiposNumericos frm = new FrmTiposNumericos();
            frm.Show();
            this.Close();
        }
    }
}
