using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAcademico1
{
    public partial class LogiFlowLvl2 : Form
    {
        public LogiFlowLvl2()
        {
            InitializeComponent();

            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                MenuLateralHelper.AgregarMenu(this, "Juego");
                ControlesVentanaHelper.Agregar(this, cerrarAplicacion: true);
            }
        }

        // Método que se ejecuta al cargar el formulario
        private void LogiFlowLvl2_Load(object sender, EventArgs e)
        {
            CargarPiezasAleatoriasNivel2();
        }

        // >>> MÉTODOS DE LÓGICA DEL NIVEL 2 (TABLERO 4x3) <<<

        private void CargarPiezasAleatoriasNivel2()
        {
            // Apunta al panel izquierdo de piezas del Nivel 2 (puedes ajustar el nombre si tu panel izquierdo se llama distinto)
            flPanelPiezas2.Controls.Clear();

            // Secuencia exacta de las 12 piezas basadas en la matriz 4x3 (columnas y filas)
            string[] nombresCorrectosNivel2 = new string[]
            {
                "pieza2_00", "pieza2_10", "pieza2_20", "pieza2_30",
                "pieza2_01", "pieza2_11", "pieza2_21", "pieza2_31",
                "pieza2_02", "pieza2_12", "pieza2_22", "pieza2_32"
            };

            var listaNombresParaPanelIzquierdo = new List<string>(nombresCorrectosNivel2);
            Random rnd = new Random();
            var listaMezclada = listaNombresParaPanelIzquierdo.OrderBy(x => rnd.Next()).ToList();

            foreach (var nombre in listaMezclada)
            {
                Image img = (Image)Properties.Resources.ResourceManager.GetObject(nombre);
                if (img != null)
                {
                    PictureBox pic = CrearPictureBoxPieza(nombre, img);
                    flPanelPiezas2.Controls.Add(pic);
                }
            }
        }

        private PictureBox CrearPictureBoxPieza(string tag, Image imagen)
        {
            PictureBox pic = new PictureBox();
            pic.Image = imagen;
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            pic.Tag = tag;

            int hDeseada = 90;
            double relacion = (double)imagen.Width / imagen.Height;
            pic.Size = new Size((int)(hDeseada * relacion), hDeseada);

            pic.BackColor = Color.FromArgb(17, 18, 34);
            pic.Cursor = Cursors.Hand;
            pic.Margin = new Padding(4);
            pic.Padding = new Padding(0);

            // Evento MouseDown para iniciar el arrastre
            pic.MouseDown += (s, ev) =>
            {
                if (ev.Button == MouseButtons.Left)
                {
                    pic.DoDragDrop(pic, DragDropEffects.Move);
                }
            };

            return pic;
        }

        // >>> EVENTOS DE ARRASTRE Y SUELTA PARA EL TABLELAYOUTPANEL (135px) <<<

        private void tableLayoutPanel1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(PictureBox)))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void tableLayoutPanel1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(PictureBox)))
            {
                PictureBox picArrastrada = (PictureBox)e.Data.GetData(typeof(PictureBox));

                Point clientPoint = tableLayoutPanel2.PointToClient(new Point(e.X, e.Y));

                int col = -1, row = -1;
                int w = 0, h = 0;

                for (int i = 0; i < tableLayoutPanel2.ColumnCount; i++)
                {
                    w += tableLayoutPanel2.GetColumnWidths()[i];
                    if (clientPoint.X < w) { col = i; break; }
                }
                if (col == -1) col = tableLayoutPanel2.ColumnCount - 1;

                for (int j = 0; j < tableLayoutPanel2.RowCount; j++)
                {
                    h += tableLayoutPanel2.GetRowHeights()[j];
                    if (clientPoint.Y < h) { row = j; break; }
                }
                if (row == -1) row = tableLayoutPanel2.RowCount - 1;

                TableLayoutPanel parentTable = picArrastrada.Parent as TableLayoutPanel;
                if (parentTable != null && parentTable != tableLayoutPanel2)
                {
                    parentTable.Controls.Remove(picArrastrada);
                }
                else if (picArrastrada.Parent is FlowLayoutPanel flp)
                {
                    flp.Controls.Remove(picArrastrada);
                }

                // Si ya hay una pieza en esa celda, la regresamos al panel de piezas izquierdo
                Control controlExistente = tableLayoutPanel2.GetControlFromPosition(col, row);
                if (controlExistente != null && controlExistente != picArrastrada)
                {
                    tableLayoutPanel2.Controls.Remove(controlExistente);

                    int hDeseada = 90;
                    if (controlExistente is PictureBox picEx && picEx.Image != null)
                    {
                        double relacion = (double)picEx.Image.Width / picEx.Image.Height;
                        picEx.Size = new Size((int)(hDeseada * relacion), hDeseada);
                        picEx.Margin = new Padding(4);
                        flPanelPiezas2.Controls.Add(picEx);
                    }
                }

                // Ajustamos el tamaño de la pieza al entrar al TableLayoutPanel (130x130 para celdas de 135)
                picArrastrada.Size = new Size(130, 130);
                picArrastrada.Margin = new Padding(0);

                tableLayoutPanel2.Controls.Add(picArrastrada, col, row);
            }
        }


        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            tableLayoutPanel2.Controls.Clear();
            CargarPiezasAleatoriasNivel2();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Genial! Próximamente pasaremos al siguiente nivel.", "CodeNova", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            MenuLevelFlujogramForm menuNiveles = new MenuLevelFlujogramForm();
            menuNiveles.Show();
            this.Close();
        }

        // Método intocable para mantener sincronizado el diseñador de Visual Studio
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnRegresar23_Click(object sender, EventArgs e)
        {
            MenuLevelFlujogramForm menuNiveles = new MenuLevelFlujogramForm();
            menuNiveles.Show();
            this.Close();
        }

        private void btnComprobar_Click_1(object sender, EventArgs e)
        {
            var piezasColocadas = tableLayoutPanel2.Controls.OfType<PictureBox>().ToList();

            if (piezasColocadas.Count != 12)
            {
                MessageBox.Show("¡Aviso! El diagrama debe contener exactamente las 12 piezas para el Nivel 2.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnSiguiente.Visible = false;
                return;
            }

            bool ordenCorrecto = true;

            for (int i = 0; i < tableLayoutPanel2.RowCount; i++)
            {
                for (int j = 0; j < tableLayoutPanel2.ColumnCount; j++)
                {
                    Control control = tableLayoutPanel2.GetControlFromPosition(j, i);

                    if (control is PictureBox pic && pic.Tag != null)
                    {
                        string tagActual = pic.Tag.ToString();
                        string tagEsperado = $"pieza2_{j}{i}";

                        if (tagActual != tagEsperado)
                        {
                            ordenCorrecto = false;
                            break;
                        }
                    }
                    else
                    {
                        ordenCorrecto = false;
                        break;
                    }
                }
                if (!ordenCorrecto) break;
            }

            if (ordenCorrecto)
            {
                MessageBox.Show("¡IMPRESIONANTE! Has completado el diagrama de flujo del Nivel 2 correctamente.", "¡Nivel 2 Superado!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                btnSiguiente.Visible = true;
            }
            else
            {
                MessageBox.Show("El diagrama no está correctamente armado. Revisa la posición de las piezas.", "Error de Lógica", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSiguiente.Visible = false;
            }
        }

        private void btnSiguiente_Click_1(object sender, EventArgs e)
        {
            LogiFlowLvl3 nivel3 = new LogiFlowLvl3();
            nivel3.Show();
            this.Close();
        }

        private void ReiniciarNivel() 
        {
            tiempoRestante = 35;
            tableLayoutPanel2.Controls.Clear();
            CargarPiezasAleatoriasNivel2();
        }


        private int tiempoRestante = 35; // O 40 según prefieras
        private void timer2_Tick(object sender, EventArgs e)
        {
            tiempoRestante--;
            lblTiempo2.Text = "Time: " + tiempoRestante + "s";

            if (tiempoRestante <= 0)
            {
                timer2.Stop();

                DialogResult resultado = MessageBox.Show(
                    "Se acabó el tiempo, ¿le gustaría volver a intentar?",
                    "CodeNova",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (resultado == DialogResult.Yes)
                {
                    ReiniciarNivel();
                    tiempoRestante = 35;
                    timer2.Start();
                }
                else
                {
                    MenuLevelFlujogramForm menu = new MenuLevelFlujogramForm();
                    menu.Show();
                    this.Hide();
                    this.Dispose();
                }
            }

            

        }

        private void btnIniciar2_Click(object sender, EventArgs e)
        {
            timer2.Start();
            btnIniciar2.Enabled = false;
        }
    }
}

