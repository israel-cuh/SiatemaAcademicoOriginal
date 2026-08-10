using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using SistemaAcademico1.Models;
using SistemaAcademico1.Services;

namespace SistemaAcademico1
{
    public partial class VisorTareasEstudiante : Form
    {
        private List<Tarea> todasLasTareas;
        private List<Tarea> tareasActivas;
        private List<TareaCompletada> historialCompletadas;
        private Tarea tareaSeleccionada;

        public VisorTareasEstudiante()
        {
            InitializeComponent();
            todasLasTareas = new List<Tarea>();
            tareasActivas = new List<Tarea>();
            historialCompletadas = new List<TareaCompletada>();
            ConfigurarFormulario();
            CargarTareas();
        }

        private void ConfigurarFormulario()
        {
            // Panel Superior con Título
            Panel panelSuperior = new Panel
            {
                Dock = DockStyle.Top,
                Height = 60,
                BackColor = Color.FromArgb(132, 78, 255)
            };

            Label lblTitulo = new Label
            {
                Text = "📚 Mis Tareas - Estudiante",
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                ForeColor = Color.White,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(20, 0, 0, 0)
            };

            panelSuperior.Controls.Add(lblTitulo);
            Controls.Add(panelSuperior);

            // Panel de Búsqueda y Filtros
            Panel panelBusqueda = new Panel
            {
                Dock = DockStyle.Top,
                Height = 80,
                BackColor = Color.FromArgb(240, 240, 240),
                BorderStyle = BorderStyle.FixedSingle,
                Padding = new Padding(10)
            };

            Label lblBuscar = new Label
            {
                Text = "🔍 Buscar:",
                Location = new Point(10, 10),
                AutoSize = true,
                Font = new Font("Segoe UI", 10, FontStyle.Bold)
            };
            panelBusqueda.Controls.Add(lblBuscar);

            TextBox txtBusqueda = new TextBox
            {
                Name = "txtBusqueda",
                Location = new Point(80, 8),
                Width = 250,
                Height = 28,
                Font = new Font("Segoe UI", 10),
                PlaceholderText = "Título, descripción o tema..."
            };
            txtBusqueda.TextChanged += (s, e) => FiltrarTareas(txtBusqueda.Text, (ComboBox)panelBusqueda.Controls["cmbFiltroTema"]);
            panelBusqueda.Controls.Add(txtBusqueda);

            Label lblFiltro = new Label
            {
                Text = "Tema:",
                Location = new Point(350, 10),
                AutoSize = true,
                Font = new Font("Segoe UI", 10, FontStyle.Bold)
            };
            panelBusqueda.Controls.Add(lblFiltro);

            ComboBox cmbFiltroTema = new ComboBox
            {
                Name = "cmbFiltroTema",
                Location = new Point(400, 8),
                Width = 150,
                Height = 28,
                Font = new Font("Segoe UI", 10),
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cmbFiltroTema.Items.Add("Todos");
            cmbFiltroTema.Items.AddRange(new string[] { "Ciclos", "Variables", "Condicionales", "Algoritmos", "General" });
            cmbFiltroTema.SelectedIndex = 0;
            cmbFiltroTema.SelectedIndexChanged += (s, e) => FiltrarTareas(txtBusqueda.Text, cmbFiltroTema);
            panelBusqueda.Controls.Add(cmbFiltroTema);

            Label lblEstado = new Label
            {
                Text = "Estado:",
                Location = new Point(570, 10),
                AutoSize = true,
                Font = new Font("Segoe UI", 10, FontStyle.Bold)
            };
            panelBusqueda.Controls.Add(lblEstado);

            ComboBox cmbEstado = new ComboBox
            {
                Name = "cmbEstado",
                Location = new Point(630, 8),
                Width = 150,
                Height = 28,
                Font = new Font("Segoe UI", 10),
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cmbEstado.Items.AddRange(new string[] { "Todas", "Pendientes", "Completadas", "Próximas a vencer" });
            cmbEstado.SelectedIndex = 0;
            cmbEstado.SelectedIndexChanged += (s, e) => FiltrarTareas(txtBusqueda.Text, cmbFiltroTema);
            panelBusqueda.Controls.Add(cmbEstado);

            Button btnLimpiarFiltros = new Button
            {
                Text = "🧹 Limpiar",
                Location = new Point(800, 8),
                Width = 80,
                Height = 28,
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                BackColor = Color.FromArgb(255, 152, 0),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btnLimpiarFiltros.Click += (s, e) =>
            {
                txtBusqueda.Clear();
                cmbFiltroTema.SelectedIndex = 0;
                cmbEstado.SelectedIndex = 0;
                ActualizarDataGridView(todasLasTareas);
            };
            panelBusqueda.Controls.Add(btnLimpiarFiltros);

            Label lblAvisos = new Label
            {
                Text = "🔔 Avisos de tareas próximas a vencer:",
                Location = new Point(10, 45),
                AutoSize = true,
                Font = new Font("Segoe UI", 9, FontStyle.Bold)
            };
            panelBusqueda.Controls.Add(lblAvisos);

            Label lblAvisosContenido = new Label
            {
                Name = "lblAvisosContenido",
                Text = "No hay tareas próximas a vencer.",
                Location = new Point(270, 45),
                AutoSize = true,
                Font = new Font("Segoe UI", 9),
                ForeColor = Color.FromArgb(76, 175, 80)
            };
            panelBusqueda.Controls.Add(lblAvisosContenido);

            Controls.Add(panelBusqueda);

            // Panel Central - Tabs
            TabControl tabControl = new TabControl
            {
                Name = "tabControl",
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 10)
            };

            // Tab 1: Tareas Activas
            TabPage tabActivas = new TabPage("📋 Tareas Activas");
            DataGridView dgvTareasActivas = CrearDataGridViewTareas("dgvTareasActivas");
            dgvTareasActivas.Dock = DockStyle.Fill;
            dgvTareasActivas.CellClick += (s, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    int idTarea = (int)dgvTareasActivas.Rows[e.RowIndex].Cells["Id"].Value;
                    tareaSeleccionada = TareaService.ObtenerTareaPorId(idTarea);
                    MostrarDetallesTarea();
                }
            };

            Panel panelActivas = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White
            };
            panelActivas.Controls.Add(dgvTareasActivas);
            tabActivas.Controls.Add(panelActivas);
            tabControl.TabPages.Add(tabActivas);

            // Tab 2: Historial de Completadas
            TabPage tabHistorial = new TabPage("✅ Historial Completadas");
            DataGridView dgvHistorial = new DataGridView
            {
                Name = "dgvHistorial",
                Dock = DockStyle.Fill,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                MultiSelect = false,
                Font = new Font("Segoe UI", 9),
                BackgroundColor = Color.WhiteSmoke,
                BorderStyle = BorderStyle.Fixed3D,
                ReadOnly = true
            };

            dgvHistorial.Columns.Add("Id", "ID");
            dgvHistorial.Columns.Add("Titulo", "Título");
            dgvHistorial.Columns.Add("TemaAsociado", "Tema");
            dgvHistorial.Columns.Add("FechaEntrega", "Fecha Entrega");
            dgvHistorial.Columns.Add("FechaCompletada", "Fecha Completada");

            Panel panelHistorial = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White
            };
            panelHistorial.Controls.Add(dgvHistorial);
            tabHistorial.Controls.Add(panelHistorial);
            tabControl.TabPages.Add(tabHistorial);

            Controls.Add(tabControl);

            // Panel Inferior - Detalles y Botones
            Panel panelInferior = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 200,
                BackColor = Color.FromArgb(245, 245, 245),
                BorderStyle = BorderStyle.FixedSingle,
                Padding = new Padding(15)
            };

            Label lblDetalles = new Label
            {
                Text = "📌 Detalles de la Tarea",
                Location = new Point(10, 5),
                AutoSize = true,
                Font = new Font("Segoe UI", 11, FontStyle.Bold)
            };
            panelInferior.Controls.Add(lblDetalles);

            RichTextBox rtxDetalles = new RichTextBox
            {
                Name = "rtxDetalles",
                Location = new Point(10, 30),
                Width = panelInferior.Width - 250,
                Height = 150,
                Font = new Font("Segoe UI", 9),
                ReadOnly = true,
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };
            panelInferior.Controls.Add(rtxDetalles);

            Button btnDescargar = new Button
            {
                Text = "📥 Descargar",
                Location = new Point(panelInferior.Width - 230, 30),
                Width = 100,
                Height = 40,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                BackColor = Color.FromArgb(33, 150, 243),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Name = "btnDescargar"
            };
            btnDescargar.Click += (s, e) => DescargarArchivo();
            panelInferior.Controls.Add(btnDescargar);

            Button btnMarcarCompletada = new Button
            {
                Text = "✅ Completar",
                Location = new Point(panelInferior.Width - 125, 30),
                Width = 110,
                Height = 40,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                BackColor = Color.FromArgb(76, 175, 80),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Name = "btnMarcarCompletada"
            };
            btnMarcarCompletada.Click += (s, e) => MarcarTareaCompletada();
            panelInferior.Controls.Add(btnMarcarCompletada);

            Label lblSinSeleccion = new Label
            {
                Name = "lblSinSeleccion",
                Text = "Selecciona una tarea para ver los detalles",
                Location = new Point(10, 70),
                Font = new Font("Segoe UI", 10, FontStyle.Italic),
                ForeColor = Color.Gray
            };
            panelInferior.Controls.Add(lblSinSeleccion);

            Controls.Add(panelInferior);

            // Configuración del formulario
            Tag = new Dictionary<string, Control>
            {
                { "txtBusqueda", txtBusqueda },
                { "cmbFiltroTema", cmbFiltroTema },
                { "cmbEstado", cmbEstado },
                { "dgvTareasActivas", dgvTareasActivas },
                { "dgvHistorial", dgvHistorial },
                { "rtxDetalles", rtxDetalles },
                { "lblSinSeleccion", lblSinSeleccion },
                { "lblAvisosContenido", lblAvisosContenido }
            };

            Text = "Mis Tareas - Estudiante";
            Size = new Size(1400, 800);
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.Sizable;
            BackColor = Color.White;
        }

        private DataGridView CrearDataGridViewTareas(string nombre)
        {
            DataGridView dgv = new DataGridView
            {
                Name = nombre,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                MultiSelect = false,
                Font = new Font("Segoe UI", 9),
                BackgroundColor = Color.WhiteSmoke,
                BorderStyle = BorderStyle.Fixed3D,
                ReadOnly = true
            };

            dgv.Columns.Add("Id", "ID");
            dgv.Columns.Add("Titulo", "Título");
            dgv.Columns.Add("TemaAsociado", "Tema");
            dgv.Columns.Add("FechaEntrega", "Fecha Entrega");
            dgv.Columns.Add("DiasRestantes", "Días Restantes");
            dgv.Columns.Add("Estado", "Estado");

            return dgv;
        }

        private void CargarTareas()
        {
            todasLasTareas = TareaService.ObtenerTodasLasTareas();
            tareasActivas = todasLasTareas.Where(t => !t.Completada).ToList();
            ActualizarDataGridView(tareasActivas);
            ActualizarAvisos();
        }

        private void ActualizarDataGridView(List<Tarea> tareas)
        {
            var dict = Tag as Dictionary<string, Control>;
            var dgvTareasActivas = dict["dgvTareasActivas"] as DataGridView;
            dgvTareasActivas.Rows.Clear();

            foreach (var tarea in tareas)
            {
                int diasRestantes = (int)(tarea.FechaEntrega - DateTime.Now).TotalDays;
                string estado = diasRestantes < 0 ? "Vencida" : (diasRestantes <= 3 ? "Próxima a vencer" : "Activa");

                dgvTareasActivas.Rows.Add(
                    tarea.Id,
                    tarea.Titulo,
                    tarea.TemaAsociado,
                    tarea.FechaEntrega.ToString("dd/MM/yyyy"),
                    diasRestantes < 0 ? "Vencida" : diasRestantes.ToString(),
                    estado
                );

                // Colorear según estado
                int lastRowIndex = dgvTareasActivas.Rows.Count - 1;
                if (estado == "Vencida")
                    dgvTareasActivas.Rows[lastRowIndex].DefaultCellStyle.BackColor = Color.FromArgb(255, 200, 200);
                else if (estado == "Próxima a vencer")
                    dgvTareasActivas.Rows[lastRowIndex].DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 200);
            }
        }

        private void ActualizarAvisos()
        {
            var dict = Tag as Dictionary<string, Control>;
            var lblAvisosContenido = dict["lblAvisosContenido"] as Label;

            var tareasProximas = todasLasTareas
                .Where(t => !t.Completada && (t.FechaEntrega - DateTime.Now).TotalDays <= 3 && (t.FechaEntrega - DateTime.Now).TotalDays > 0)
                .ToList();

            if (tareasProximas.Count > 0)
            {
                lblAvisosContenido.Text = $"⚠️ {tareasProximas.Count} tarea(s) próxima(s) a vencer: {string.Join(", ", tareasProximas.Select(t => t.Titulo))}";
                lblAvisosContenido.ForeColor = Color.FromArgb(244, 67, 54);
            }
            else
            {
                lblAvisosContenido.Text = "✅ No hay tareas próximas a vencer.";
                lblAvisosContenido.ForeColor = Color.FromArgb(76, 175, 80);
            }
        }

        private void FiltrarTareas(string busqueda, ComboBox cmbTema)
        {
            var tareasFiltradasPorTema = todasLasTareas
                .Where(t => !t.Completada &&
                    (cmbTema.SelectedIndex == 0 || t.TemaAsociado == cmbTema.SelectedItem.ToString()))
                .ToList();

            var tareasFiltradasPorBusqueda = tareasFiltradasPorTema
                .Where(t => string.IsNullOrEmpty(busqueda) ||
                    t.Titulo.IndexOf(busqueda, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    t.Descripcion.IndexOf(busqueda, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();

            ActualizarDataGridView(tareasFiltradasPorBusqueda);
        }

        private void MostrarDetallesTarea()
        {
            var dict = Tag as Dictionary<string, Control>;
            var rtxDetalles = dict["rtxDetalles"] as RichTextBox;
            var lblSinSeleccion = dict["lblSinSeleccion"] as Label;

            if (tareaSeleccionada != null)
            {
                rtxDetalles.Visible = true;
                lblSinSeleccion.Visible = false;

                int diasRestantes = (int)(tareaSeleccionada.FechaEntrega - DateTime.Now).TotalDays;
                string estado = diasRestantes < 0 ? "Vencida" : (diasRestantes <= 3 ? "Próxima a vencer" : "Activa");

                rtxDetalles.Clear();
                rtxDetalles.AppendText($"📌 TÍTULO: {tareaSeleccionada.Titulo}\n\n");
                rtxDetalles.AppendText($"📝 DESCRIPCIÓN:\n{tareaSeleccionada.Descripcion}\n\n");
                rtxDetalles.AppendText($"📚 TEMA: {tareaSeleccionada.TemaAsociado}\n");
                rtxDetalles.AppendText($"📅 FECHA ENTREGA: {tareaSeleccionada.FechaEntrega:dd/MM/yyyy}\n");
                rtxDetalles.AppendText($"⏳ ESTADO: {estado}\n");
                rtxDetalles.AppendText($"📎 ARCHIVO: {(string.IsNullOrEmpty(tareaSeleccionada.RutaArchivo) ? "No adjunto" : Path.GetFileName(tareaSeleccionada.RutaArchivo))}\n");
            }
            else
            {
                rtxDetalles.Visible = false;
                lblSinSeleccion.Visible = true;
            }
        }

        private void DescargarArchivo()
        {
            if (tareaSeleccionada == null)
            {
                MessageBox.Show("Por favor selecciona una tarea.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(tareaSeleccionada.RutaArchivo) || !File.Exists(tareaSeleccionada.RutaArchivo))
            {
                MessageBox.Show("Esta tarea no tiene archivo adjunto.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                FileName = Path.GetFileName(tareaSeleccionada.RutaArchivo),
                DefaultExt = Path.GetExtension(tareaSeleccionada.RutaArchivo),
                Filter = "Todos los archivos (*.*)|*.*"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.Copy(tareaSeleccionada.RutaArchivo, saveFileDialog.FileName, true);
                    MessageBox.Show("✅ Archivo descargado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al descargar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void MarcarTareaCompletada()
        {
            if (tareaSeleccionada == null)
            {
                MessageBox.Show("Por favor selecciona una tarea.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resultado = MessageBox.Show(
                $"¿Marcar la tarea '{tareaSeleccionada.Titulo}' como completada?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                TareaService.MarcarTareaComoCompletada(tareaSeleccionada.Id);
                historialCompletadas.Add(new TareaCompletada
                {
                    IdTarea = tareaSeleccionada.Id,
                    Titulo = tareaSeleccionada.Titulo,
                    TemaAsociado = tareaSeleccionada.TemaAsociado,
                    FechaEntrega = tareaSeleccionada.FechaEntrega,
                    FechaCompletada = DateTime.Now
                });

                MessageBox.Show("✅ Tarea marcada como completada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarTareas();
                ActualizarHistorial();
                MostrarDetallesTarea();
            }
        }

        private void ActualizarHistorial()
        {
            var dict = Tag as Dictionary<string, Control>;
            var dgvHistorial = dict["dgvHistorial"] as DataGridView;
            dgvHistorial.Rows.Clear();

            foreach (var tarea in historialCompletadas)
            {
                dgvHistorial.Rows.Add(
                    tarea.IdTarea,
                    tarea.Titulo,
                    tarea.TemaAsociado,
                    tarea.FechaEntrega.ToString("dd/MM/yyyy"),
                    tarea.FechaCompletada.ToString("dd/MM/yyyy HH:mm")
                );
            }
        }
    }
}
