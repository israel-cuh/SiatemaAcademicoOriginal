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
    public partial class LogiFlowLvl3 : Form
    {
        public LogiFlowLvl3()
        {
            InitializeComponent();

            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                MenuLateralHelper.AgregarMenu(this, "Juego");
                ControlesVentanaHelper.Agregar(this, cerrarAplicacion: true);
            }
        }

        private void LogiFlowLvl3_Load(object sender, EventArgs e)
        {
            CargarPiezasAleatoriasNivel3();
        }

        // >>> CARGAR Y MEZCLAR LAS 16 PIEZAS DEL NIVEL 3 <<<
        private void CargarPiezasAleatoriasNivel3()
        {
            flPanelPiezas3.Controls.Clear();

            // Secuencia exacta de las 16 piezas del Nivel 3 (Matriz 4x4)
            string[] nombresCorrectosNivel3 = new string[]
            {
                "pieza3_00", "pieza3_10", "pieza3_20", "pieza3_30",
                "pieza3_01", "pieza3_11", "pieza3_21", "pieza3_31",
                "pieza3_02", "pieza3_12", "pieza3_22", "pieza3_32",
                "pieza3_03", "pieza3_13", "pieza3_23", "pieza3_33"
            };

            var listaNombres = new List<string>(nombresCorrectosNivel3);
            Random rnd = new Random();
            var listaMezclada = listaNombres.OrderBy(x => rnd.Next()).ToList();

            foreach (var nombre in listaMezclada)
            {
                Image img = (Image)Properties.Resources.ResourceManager.GetObject(nombre);
                if (img != null)
                {
                    PictureBox pic = CrearPictureBoxPieza(nombre, img);
                    flPanelPiezas3.Controls.Add(pic);
                }
            }
        }

        // >>> CREAR CADA PICTUREBOX CON PROPORCIÓN HORIZONTAL <<<
        private PictureBox CrearPictureBoxPieza(string tag, Image imagen)
        {
            PictureBox pic = new PictureBox();
            pic.Image = imagen;
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            pic.Tag = tag;

            // Altura compacta para que entren holgadas en el panel izquierdo de piezas
            int hDeseada = 45; 
            double relacion = (double)imagen.Width / imagen.Height;
            pic.Size = new Size((int)(hDeseada * relacion), hDeseada);

            pic.BackColor = Color.FromArgb(17, 18, 34);
            pic.Cursor = Cursors.Hand;
            pic.Margin = new Padding(3);
            pic.Padding = new Padding(0);

            pic.MouseDown += (s, ev) =>
            {
                if (ev.Button == MouseButtons.Left)
                {
                    pic.DoDragDrop(pic, DragDropEffects.Move);
                }
            };

            return pic;
        }

        // >>> EVENTOS DE ARRASTRE Y SOLTADO (DRAG & DROP) <<<
        private void tableLayoutPanel3_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(PictureBox)))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }

        private void tableLayoutPanel3_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(PictureBox)))
            {
                PictureBox picArrastrada = (PictureBox)e.Data.GetData(typeof(PictureBox));
                Point clientPoint = tableLayoutPanel3.PointToClient(new Point(e.X, e.Y));

                int col = -1, row = -1;
                int w = 0, h = 0;

                for (int i = 0; i < tableLayoutPanel3.ColumnCount; i++)
                {
                    w += tableLayoutPanel3.GetColumnWidths()[i];
                    if (clientPoint.X < w) { col = i; break; }
                }
                if (col == -1) col = tableLayoutPanel3.ColumnCount - 1;

                for (int j = 0; j < tableLayoutPanel3.RowCount; j++)
                {
                    h += tableLayoutPanel3.GetRowHeights()[j];
                    if (clientPoint.Y < h) { row = j; break; }
                }
                if (row == -1) row = tableLayoutPanel3.RowCount - 1;

                // Remover del contenedor anterior
                TableLayoutPanel parentTable = picArrastrada.Parent as TableLayoutPanel;
                if (parentTable != null && parentTable != tableLayoutPanel3)
                {
                    parentTable.Controls.Remove(picArrastrada);
                }
                else if (picArrastrada.Parent is FlowLayoutPanel flp)
                {
                    flp.Controls.Remove(picArrastrada);
                }

                // Si hay control previo en la celda, regresarlo al panel izquierdo
                Control controlExistente = tableLayoutPanel3.GetControlFromPosition(col, row);
                if (controlExistente != null && controlExistente != picArrastrada)
                {
                    tableLayoutPanel3.Controls.Remove(controlExistente);

                    int hDeseada = 45;
                    if (controlExistente is PictureBox picEx && picEx.Image != null)
                    {
                        double relacion = (double)picEx.Image.Width / picEx.Image.Height;
                        picEx.Size = new Size((int)(hDeseada * relacion), hDeseada);
                        picEx.Margin = new Padding(3);
                        flPanelPiezas3.Controls.Add(picEx);
                    }
                }

                // Ajustar tamaño de la pieza al tamaño dinámico de la celda del tablero
                int cellWidth = tableLayoutPanel3.GetColumnWidths()[col];
                int cellHeight = tableLayoutPanel3.GetRowHeights()[row];
                picArrastrada.Size = new Size(cellWidth - 4, cellHeight - 4);
                picArrastrada.Margin = new Padding(2);

                tableLayoutPanel3.Controls.Add(picArrastrada, col, row);
            }
        }

        // >>> BOTÓN COMPROBAR (VALIDACIÓN DE LA MATRIZ 4X4) <<<
       

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            tableLayoutPanel3.Controls.Clear();
            CargarPiezasAleatoriasNivel3();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Genial! Has avanzado en el proyecto CodeNova.", "CodeNova", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            MenuLevelFlujogramForm menuNiveles = new MenuLevelFlujogramForm();
            menuNiveles.Show();
            this.Close();
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
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
            var piezasColocadas = tableLayoutPanel3.Controls.OfType<PictureBox>().ToList();

            if (piezasColocadas.Count != 16)
            {
                MessageBox.Show("¡Aviso! El diagrama debe contener exactamente las 16 piezas para el Nivel 3.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnSiguiente.Visible = false;
                return;
            }

            bool ordenCorrecto = true;

            for (int i = 0; i < tableLayoutPanel3.RowCount; i++)
            {
                for (int j = 0; j < tableLayoutPanel3.ColumnCount; j++)
                {
                    Control control = tableLayoutPanel3.GetControlFromPosition(j, i);

                    if (control is PictureBox pic && pic.Tag != null)
                    {
                        string tagActual = pic.Tag.ToString();
                        string tagEsperado = $"pieza3_{j}{i}";

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
                MessageBox.Show("¡IMPRESIONANTE! Has completado el diagrama de flujo del Nivel 3 correctamente.", "¡Nivel 3 Superado!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
            MessageBox.Show("¡Genial! Has avanzado con el LogiFlow.", "CodeNova", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MenuLevelFlujogramForm menuNiveles = new MenuLevelFlujogramForm();
            menuNiveles.Show();
            this.Close();
        }

        private void ReiniciarNivel()
        {
            tiempoRestante =45;
            tableLayoutPanel3.Controls.Clear();
            CargarPiezasAleatoriasNivel3();
        }

        private int tiempoRestante = 45;
        private void timer3_Tick(object sender, EventArgs e)
        {
            tiempoRestante--;
            lblTiempo3.Text = "Time: " + tiempoRestante + "s";

            if (tiempoRestante <= 0)
            {
                timer3.Stop();

                DialogResult resultado = MessageBox.Show(
                    "Se acabó el tiempo, ¿le gustaría volver a intentar?",
                    "CodeNova",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (resultado == DialogResult.Yes)
                {
                    ReiniciarNivel();
                    tiempoRestante = 45;
                    timer3.Start();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnIniciar3_Click(object sender, EventArgs e)
        {
            timer3.Start();

            btnIniciar3.Enabled = false;
        }
    }
}

