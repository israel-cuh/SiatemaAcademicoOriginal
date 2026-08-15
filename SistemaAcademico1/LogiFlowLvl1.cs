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
    public partial class LogiFlowLvl1 : Form
    {
        public LogiFlowLvl1()
        {
            InitializeComponent();

            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                MenuLateralHelper.AgregarMenu(this, "Juego");
                ControlesVentanaHelper.Agregar(this, cerrarAplicacion: true);
            }
        }

        private void CargarPiezasAleatoriasNivel1()
        {
            flPanelPiezas.Controls.Clear();

            // Orden correcto basado en el diagrama por filas
            string[] nombresCorrectosNivel1 = new string[]
            {
                // Fila 0
                "pieza1_00", "pieza1_10", "pieza1_20",
                // Fila 1
                "pieza1_01", "pieza1_11", "pieza1_21",
                // Fila 2
                "pieza1_02", "pieza1_12", "pieza1_22"
            };

            var listaNombresParaPanelIzquierdo = new List<string>(nombresCorrectosNivel1);
            Random rnd = new Random();
            var listaMezclada = listaNombresParaPanelIzquierdo.OrderBy(x => rnd.Next()).ToList();

            foreach (var nombre in listaMezclada)
            {
                PictureBox pic = CrearPictureBoxPieza(nombre, (Image)Properties.Resources.ResourceManager.GetObject(nombre));
                flPanelPiezas.Controls.Add(pic);
            }
        }

        // Método auxiliar para crear las piezas con propiedades uniformes y evitar código repetido
        private PictureBox CrearPictureBoxPieza(string tag, Image imagen)
        {
            PictureBox pic = new PictureBox();
            pic.Image = imagen;
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            pic.Tag = tag;

            // Tamaño estético y pequeño para el panel de piezas izquierdo
            int hDeseada = 90;
            double relacion = (double)imagen.Width / imagen.Height;
            pic.Size = new Size((int)(hDeseada * relacion), hDeseada);

            pic.BackColor = Color.FromArgb(17, 18, 34);
            pic.Cursor = Cursors.Hand;
            pic.Margin = new Padding(4);
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

                Point clientPoint = tableLayoutPanel1.PointToClient(new Point(e.X, e.Y));

                int col = -1, row = -1;
                int w = 0, h = 0;

                for (int i = 0; i < tableLayoutPanel1.ColumnCount; i++)
                {
                    w += tableLayoutPanel1.GetColumnWidths()[i];
                    if (clientPoint.X < w) { col = i; break; }
                }
                if (col == -1) col = tableLayoutPanel1.ColumnCount - 1;

                for (int j = 0; j < tableLayoutPanel1.RowCount; j++)
                {
                    h += tableLayoutPanel1.GetRowHeights()[j];
                    if (clientPoint.Y < h) { row = j; break; }
                }
                if (row == -1) row = tableLayoutPanel1.RowCount - 1;

                // 1. Si la pieza ya estaba en otra celda del TableLayoutPanel, la desvinculamos
                TableLayoutPanel parentTable = picArrastrada.Parent as TableLayoutPanel;
                if (parentTable != null)
                {
                    parentTable.Controls.Remove(picArrastrada);
                }
                else
                {
                    // Si venía del panel izquierdo, la removemos de ahí
                    flPanelPiezas.Controls.Remove(picArrastrada);
                }

                // 2. Si la celda de destino ya tiene otra pieza, la regresamos al panel lateral con su tamaño pequeño
                Control controlExistente = tableLayoutPanel1.GetControlFromPosition(col, row);
                if (controlExistente != null && controlExistente != picArrastrada)
                {
                    tableLayoutPanel1.Controls.Remove(controlExistente);

                    int hDeseada = 90;
                    double relacion = (double)((PictureBox)controlExistente).Image.Width / ((PictureBox)controlExistente).Image.Height;
                    controlExistente.Size = new Size((int)(hDeseada * relacion), hDeseada);
                    ((PictureBox)controlExistente).Margin = new Padding(4);

                    flPanelPiezas.Controls.Add(controlExistente);
                }

                // 3. Al colocarla en el tablero, la expandimos a 130x130 y quitamos los márgenes
                picArrastrada.Size = new Size(130, 130);
                picArrastrada.Margin = new Padding(0);

                // Colocamos la pieza en la nueva celda del tablero
                tableLayoutPanel1.Controls.Add(picArrastrada, col, row);
            }
        }

        private void LogiFlowLvl1_Load(object sender, EventArgs e)
        {
            CargarPiezasAleatoriasNivel1();
        }

        private void btnRegresar23_Click(object sender, EventArgs e)
        {
            MenuLevelFlujogramForm menuNiveles = new MenuLevelFlujogramForm();
            menuNiveles.Show();
            this.Close();
        }

        private void btnComprobar_Click(object sender, EventArgs e)
        {
            var piezasColocadas = tableLayoutPanel1.Controls.OfType<PictureBox>().ToList();

            if (piezasColocadas.Count != 9)
            {
                MessageBox.Show("¡Aviso! El diagrama debe contener exactamente las 9 piezas para el Nivel 1.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnSiguiente.Visible = false;
                return;
            }

            bool ordenCorrecto = true;

            for (int i = 0; i < tableLayoutPanel1.RowCount; i++)
            {
                for (int j = 0; j < tableLayoutPanel1.ColumnCount; j++)
                {
                    Control control = tableLayoutPanel1.GetControlFromPosition(j, i);

                    if (control is PictureBox pic && pic.Tag != null)
                    {
                        string tagActual = pic.Tag.ToString();
                        string tagEsperado = $"pieza1_{j}{i}";

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
                MessageBox.Show("¡IMPRESIONANTE! Has completado el diagrama de flujo del Nivel 1 correctamente.", "¡Nivel 1 Superado!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                btnSiguiente.Visible = true;
            }
            else
            {
                MessageBox.Show("El diagrama no está correctamente armado. Revisa la posición de las piezas.", "Error de Lógica", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSiguiente.Visible = false;
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Clear();
            CargarPiezasAleatoriasNivel1();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            LogiFlowLvl2 nivel2 = new LogiFlowLvl2();
            nivel2.Show();
            this.Close();
        }

        private void flPanelPiezas_Paint(object sender, PaintEventArgs e) { }
        private void fLPanelUnion1_Paint(object sender, PaintEventArgs e) { }
        private void lblPartesFlujo_Click(object sender, EventArgs e) { }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e) { }
        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e) { }
        private void panel2_Paint(object sender, PaintEventArgs e) { }
        private void lblEnunciadoSig_Click(object sender, EventArgs e) { }
        private void fLPanelUnion1_DragDrop(object sender, DragEventArgs e) { }
        private void fLPanelUnion1_DragEnter(object sender, DragEventArgs e) { }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ReiniciarNivel()
        {
            tiempoRestante = 30; // Restablece los segundos

            tableLayoutPanel1.Controls.Clear();
            CargarPiezasAleatoriasNivel1();
        }

        private int tiempoRestante = 30; // Cambiar a 45 o 75 según el nive

        private void timer1_Tick(object sender, EventArgs e)
        {
            tiempoRestante--;
            label1.Text = "Time: " + tiempoRestante + "s";

            if (tiempoRestante <= 0)
            {
                timer1.Stop();

                // Mostramos el mensaje con botones Sí / No
                DialogResult resultado = MessageBox.Show(
                    "Se acabó el tiempo, ¿le gustaría volver a intentar?",
                    "CodeNova",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                // Evaluamos la respuesta del usuario
                if (resultado == DialogResult.Yes)
                {
                    // Aquí llamas a tu método para reiniciar las piezas y el tiempo
                    ReiniciarNivel();

                    // Vuelves a arrancar el temporizador
                    tiempoRestante = 30; // O el tiempo correspondiente al nivel
                    timer1.Start();
                }
                else
                {
                    MenuLevelFlujogramForm menu = new MenuLevelFlujogramForm();

                    // 2. Mostramos el menú
                    menu.Show();

                    // 3. Ocultamos el formulario actual en lugar de cerrarlo violentamente
                    this.Hide();
                }
            }
        }

        private void btnIniciar1_Click(object sender, EventArgs e)
        {
            timer1.Start();

            // 2. Deshabilita el botón para que no se pueda volver a presionar durante la partida
            btnIniciar1.Enabled = false;
        }
    }
}
