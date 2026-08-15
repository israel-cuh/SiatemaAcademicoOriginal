using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
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

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ClientSize = new Size(1000, 600);
            this.Name = "VisorTareasEstudiante";
            this.Text = "Visor de Tareas";
            this.ResumeLayout(false);
        }

        public VisorTareasEstudiante()
        {
            InitializeComponent();
            this.ClientSize = new Size(1560, 850);
            this.MinimumSize = new Size(1560, 850);
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            if (System.ComponentModel.LicenseManager.UsageMode != System.ComponentModel.LicenseUsageMode.Designtime)
            {
                ControlesVentanaHelper.Agregar(this, cerrarAplicacion: false);
            }

            todasLasTareas = new List<Tarea>();
            tareasActivas = new List<Tarea>();
            historialCompletadas = new List<TareaCompletada>();
            ConfigurarFormulario();
            CargarTareas();
        }

        private void ConfigurarFormulario()
        {
            // 1. Panel Superior con Título (PRIMERO para que quede arriba)aaaaaaaaaaaaaaaaa
            Panel panelSuperior = new Panel
            {
                Dock = DockStyle.Top,
                Height = 40,
                BackColor = Color.FromArgb(12, 83, 175)
            };

            Label lblTitulo = new Label
            {
                Text = ",,,📚 Mis Tareas - Estudiante",
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                ForeColor = Color.White,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(20, 0, 0, 0)
            };
            // Botón de regreso al menú principal
            Button btnRegresar = new Button
            {
                Name = "btnRegresar",
                Text = "←",
                Width = 50,
                Dock = DockStyle.Left,
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(132, 78, 255),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 12, FontStyle.Bold)
            };
            btnRegresar.FlatAppearance.BorderSize = 0;
            btnRegresar.Click += (s, e) =>
            {
                MenuEstructura estructura = new MenuEstructura("Estudiante");
                estructura.Show();
                this.Close();
            };

            
            panelSuperior.Controls.Add(btnRegresar);
            panelSuperior.Controls.Add(lblTitulo);
            Controls.Add(panelSuperior);
            

            // 2. Panel de Búsqueda y Filtros (SEGUNDO para que quede debajo del título)
            Panel panelBusqueda = new Panel
            {
                Dock = DockStyle.Top,
                Height = 40,
                BackColor = Color.FromArgb(230, 243, 255),
                BorderStyle = BorderStyle.None,
                Padding = new Padding(10)
            };

            Label lblBuscar = new Label
            {
                Text = "🔍:",
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
                Text = "Tema",
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
                Text = "Estado",
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
            // Panel contenedor central (gestiona correctamente el espacio entre header y footer)
            Panel panelContenido = new Panel
            {
                Name = "panelContenido",
                Dock = DockStyle.Fill,
                BackColor = Color.Transparent,
                // Dejar espacio superior para separar encabezado/búsqueda de la lista
                Padding = new Padding(0, 80, 0, 0)
            };

            // 3. Panel Inferior - Detalles y Botones (DockStyle.Bottom antes del Fill)
            Panel panelInferior = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 200,
                BackColor = Color.FromArgb(245, 245, 245),
                BorderStyle = BorderStyle.None,
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

            Panel panelBotones = new Panel
            {
                Dock = DockStyle.Right,
                Width = 260,
                BackColor = Color.Transparent
            };

            Button btnDescargar = new Button
            {
                Text = "📥 Descargar",
                Location = new Point(20, 30),
                Width = 220,
                Height = 40,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                BackColor = Color.FromArgb(33, 150, 243),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Name = "btnDescargar"
            };
            btnDescargar.Click += (s, e) => DescargarArchivo();
            panelBotones.Controls.Add(btnDescargar);

            Button btnMarcarCompletada = new Button
            {
                Text = "✅ Completar",
                Location = new Point(20, 80),
                Width = 220,
                Height = 40,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                BackColor = Color.FromArgb(76, 175, 80),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Name = "btnMarcarCompletada"
            };
            btnMarcarCompletada.Click += (s, e) => MarcarTareaCompletada();
            panelBotones.Controls.Add(btnMarcarCompletada);

            panelInferior.Controls.Add(panelBotones);

            RichTextBox rtxDetalles = new RichTextBox
            {
                Name = "rtxDetalles",
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 9),
                ReadOnly = true,
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };
            panelInferior.Controls.Add(rtxDetalles);

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
            // Añadir el panelContenido después del panelInferior para que DockStyle.Bottom y DockStyle.Fill funcionen correctamente
            Controls.Add(panelContenido);

            // 4. Panel Central - Tabs (ÚLTIMO con DockStyle.Fill para ocupar el espacio restante del medio)
            TabControl tabControl = new TabControl
            {
                Name = "tabControl",
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 10),
                BackColor = Color.FromArgb(245, 250, 255)
            };

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
                BackColor = Color.FromArgb(250, 253, 255)
            };
            panelActivas.Controls.Add(dgvTareasActivas);
            tabActivas.Controls.Add(panelActivas);
            tabControl.TabPages.Add(tabActivas);

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
                BackColor = Color.FromArgb(250, 253, 255)
            };
            panelHistorial.Controls.Add(dgvHistorial);
            tabHistorial.Controls.Add(panelHistorial);
            tabControl.TabPages.Add(tabHistorial);

            panelContenido.Controls.Add(tabControl);

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

            FiltrarTareas(txtBusqueda.Text, cmbFiltroTema);

            Text = "Mis Tareas - Estudiante";
            Size = new Size(1560, 850);
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.None;
            BackColor = Color.FromArgb(245, 250, 255);
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
            try
            {
                var dict = Tag as Dictionary<string, Control>;
                if (dict == null)
                {
                    MessageBox.Show("Error interno: Tag no inicializado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var dgvTareasActivas = dict.ContainsKey("dgvTareasActivas") ? dict["dgvTareasActivas"] as DataGridView : null;
                if (dgvTareasActivas == null)
                {
                    MessageBox.Show("No se encontró el control dgvTareasActivas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                todasLasTareas = TareaService.ObtenerTodasLasTareas();

                // Asegurar que las columnas existen
                if (dgvTareasActivas.Columns.Count < 6)
                {
                    dgvTareasActivas.Columns.Clear();
                    dgvTareasActivas.Columns.Add("Id", "ID");
                    dgvTareasActivas.Columns.Add("Titulo", "Título");
                    dgvTareasActivas.Columns.Add("TemaAsociado", "Tema");
                    dgvTareasActivas.Columns.Add("FechaEntrega", "Fecha Entrega");
                    dgvTareasActivas.Columns.Add("DiasRestantes", "Días Restantes");
                    dgvTareasActivas.Columns.Add("Estado", "Estado");
                }

                dgvTareasActivas.Rows.Clear();

                // Añadir filas
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

                    int lastRowIndex = dgvTareasActivas.Rows.Count - 1;
                    if (estado == "Vencida")
                        dgvTareasActivas.Rows[lastRowIndex].DefaultCellStyle.BackColor = Color.FromArgb(255, 200, 200);
                    else if (estado == "Próxima a vencer")
                        dgvTareasActivas.Rows[lastRowIndex].DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 200);
                }

                // Asegurar que las columnas y filas se redimensionan y el control es visible
                try
                {
                    if (dgvTareasActivas.Rows.Count > 0)
                    {
                        dgvTareasActivas.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                        dgvTareasActivas.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
                    }
                    dgvTareasActivas.Visible = true;
                    dgvTareasActivas.ClearSelection();
                    dgvTareasActivas.Refresh();
                    dgvTareasActivas.BringToFront();
                // DEBUG: mostrar conteo para verificar que las filas se añadieron
                try
                {
                    
                }
                catch { }
                }
                catch { }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error actualizando la lista de tareas:\n{ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            ComboBox cmbEstado = Controls.Find("cmbEstado", true).FirstOrDefault() as ComboBox;
            var query = todasLasTareas.AsEnumerable();

            if (cmbTema != null && cmbTema.SelectedIndex > 0)
                query = query.Where(t => t.TemaAsociado == cmbTema.SelectedItem.ToString());

            if (cmbEstado != null)
            {
                string estadoSel = cmbEstado.SelectedItem?.ToString() ?? "Todas";
                if (estadoSel == "Pendientes")
                {
                    query = query.Where(t => !t.Completada);
                }
                else if (estadoSel == "Completadas")
                {
                    query = query.Where(t => t.Completada);
                }
                else if (estadoSel == "Próximas a vencer")
                {
                    query = query.Where(t => !t.Completada && (t.FechaEntrega - DateTime.Now).TotalDays <= 3 && (t.FechaEntrega - DateTime.Now).TotalDays > 0);
                }
            }
            else
            {
                query = query.Where(t => !t.Completada);
            }

            if (!string.IsNullOrEmpty(busqueda))
            {
                query = query.Where(t =>
                    (t.Titulo != null && t.Titulo.IndexOf(busqueda, StringComparison.OrdinalIgnoreCase) >= 0) ||
                    (t.Descripcion != null && t.Descripcion.IndexOf(busqueda, StringComparison.OrdinalIgnoreCase) >= 0));
            }

            var tareasFiltradas = query.ToList();
            ActualizarDataGridView(tareasFiltradas);
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