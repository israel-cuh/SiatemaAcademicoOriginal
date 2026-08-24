using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaAcademico1
{
    public partial class FrmReglasVariables : Form
    {
        public FrmReglasVariables()
        {
            InitializeComponent();
            MenuLateralHelper.AgregarMenu(this, "Variables");
            ControlesVentanaHelper.Agregar(this, cerrarAplicacion: true);
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

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void btnComprobar_Click(object sender, EventArgs e)
        {
            // Verificar que todas las preguntas tengan una respuesta
            if ((!rdbEdadDeportista.Checked &&
                 !rdb2Edad.Checked &&
                 !rdbEdadEspacio.Checked) ||

                (!rdbPromedioEspacio.Checked &&
                 !rdbPromedioFinal.Checked &&
                 !rdb1Promedio.Checked) ||

                (!rdbUsuarioActivo.Checked &&
                 !rdbActivoUsuario.Checked &&
                 !rdb0UsuarioActivo.Checked))
            {
                lblResultado.Text = "Debes responder las 3 preguntas.";
                lblResultado.ForeColor = Color.Orange;
                return;
            }

            int aciertos = 0;

            // Regresar todos los RadioButton a color blanco
            rdbEdadDeportista.ForeColor = Color.White;
            rdb2Edad.ForeColor = Color.White;
            rdbEdadEspacio.ForeColor = Color.White;

            rdbPromedioEspacio.ForeColor = Color.White;
            rdbPromedioFinal.ForeColor = Color.White;
            rdb1Promedio.ForeColor = Color.White;

            rdbUsuarioActivo.ForeColor = Color.White;
            rdbActivoUsuario.ForeColor = Color.White;
            rdb0UsuarioActivo.ForeColor = Color.White;

            // PREGUNTA 1
            if (rdbEdadDeportista.Checked)
            {
                aciertos++;
                rdbEdadDeportista.ForeColor = Color.LimeGreen;
            }
            else
            {
                if (rdb2Edad.Checked)
                    rdb2Edad.ForeColor = Color.Red;

                if (rdbEdadEspacio.Checked)
                    rdbEdadEspacio.ForeColor = Color.Red;

                rdbEdadDeportista.ForeColor = Color.LimeGreen;
            }

            // PREGUNTA 2
            if (rdbPromedioFinal.Checked)
            {
                aciertos++;
                rdbPromedioFinal.ForeColor = Color.LimeGreen;
            }
            else
            {
                if (rdbPromedioEspacio.Checked)
                    rdbPromedioEspacio.ForeColor = Color.Red;

                if (rdb1Promedio.Checked)
                    rdb1Promedio.ForeColor = Color.Red;

                rdbPromedioFinal.ForeColor = Color.LimeGreen;
            }

            // PREGUNTA 3
            if (rdbUsuarioActivo.Checked)
            {
                aciertos++;
                rdbUsuarioActivo.ForeColor = Color.LimeGreen;
            }
            else
            {
                if (rdbActivoUsuario.Checked)
                    rdbActivoUsuario.ForeColor = Color.Red;

                if (rdb0UsuarioActivo.Checked)
                    rdb0UsuarioActivo.ForeColor = Color.Red;

                rdbUsuarioActivo.ForeColor = Color.LimeGreen;
            }

            // Mostrar resultado
            if (aciertos == 3)
            {
                lblResultado.Text =
                    "✓ ¡Excelente! Todas las respuestas " +
                    "son correctas. 3/3";

                lblResultado.ForeColor = Color.LimeGreen;
            }
            else if (aciertos == 2)
            {
                lblResultado.Text =
                    "Casi lo tienes. Obtuviste 2/3 " +
                    "respuestas correctas.";

                lblResultado.ForeColor = Color.Orange;
            }
            else if (aciertos == 1)
            {
                lblResultado.Text =
                    "Obtuviste 1/3. Revisa nuevamente las reglas.";

                lblResultado.ForeColor = Color.OrangeRed;
            }
            else
            {
                lblResultado.Text =
                    "Obtuviste 0/3. Revisa las reglas" +
                    " e inténtalo otra vez.";

                lblResultado.ForeColor = Color.Red;
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            FrmAsignacionVariables frm = new FrmAsignacionVariables();
            frm.Show();
            this.Hide();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            FrmVariablesCompletado frm = new FrmVariablesCompletado();
            frm.Show();
            this.Hide();
        }
    }
}
