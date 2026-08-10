using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SistemaAcademico1.Models;
using SistemaAcademico1.Services;

namespace SistemaAcademico1
{
    public partial class GestorTareas : Form
    {
        private List<Tarea> tareasCargadas;
        private Tarea tareaSeleccionada;

        public GestorTareas()
        {
            InitializeComponent();
            tareasCargadas = new List<Tarea>();
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
                Text = "📋 Gestor de Tareas para Docentes",
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                ForeColor = Color.White,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(20, 0, 0, 0)
            };

            panelSuperior.Controls.Add(lblTitulo);
            Controls.Add(panelSuperior);

            // Panel Derecho - Formulario
            Panel panelFormulario = new Panel
            {
                Dock = DockStyle.Right,
                Width = 400,
                BackColor = Color.WhiteSmoke,
                Padding = new Padding(15)
            };

            int posY = 10;

            // Título
            Label lblTituloField = new Label
            {
                Text = "Título de la Tarea",
                Location = new Point(10, posY),
                AutoSize = true,
                Font = new Font("Segoe UI", 10, FontStyle.Bold)
            };
            panelFormulario.Controls.Add(lblTituloField);

            TextBox txtTitulo = new TextBox
            {
                Name = "txtTitulo",
                Location = new Point(10, posY + 25),
                Width = 370,
                Height = 35,
                Multiline = false,
                Font = new Font("Segoe UI", 10)
            };
            panelFormulario.Controls.Add(txtTitulo);
            posY += 70;

            // Descripción
            Label lblDescripcion = new Label
            {
                Text = "Descripción",
                Location = new Point(10, posY),
                AutoSize = true,
                Font = new Font("Segoe UI", 10, FontStyle.Bold)
            };
            panelFormulario.Controls.Add(lblDescripcion);

            TextBox txtDescripcion = new TextBox
            {
                Name = "txtDescripcion",
                Location = new Point(10, posY + 25),
                Width = 370,
                Height = 70,
                Multiline = true,
                Font = new Font("Segoe UI", 10),
                ScrollBars = ScrollBars.Vertical
            };
            panelFormulario.Controls.Add(txtDescripcion);
            posY += 110;

            // Fecha de Entrega
            Label lblFecha = new Label
            {
                Text = "Fecha de Entrega",
                Location = new Point(10, posY),
                AutoSize = true,
                Font = new Font("Segoe UI", 10, FontStyle.Bold)
            };
            panelFormulario.Controls.Add(lblFecha);

            DateTimePicker dtpFecha = new DateTimePicker
            {
                Name = "dtpFecha",
                Location = new Point(10, posY + 25),
                Width = 370,
                Height = 35,
                Format = DateTimePickerFormat.Short,
                Font = new Font("Segoe UI", 10)
            };
            panelFormulario.Controls.Add(dtpFecha);
            posY += 70;

            // Tema Asociado
            Label lblTema = new Label
            {
                Text = "Tema Asociado",
                Location = new Point(10, posY),
                AutoSize = true,
                Font = new Font("Segoe UI", 10, FontStyle.Bold)
            };
            panelFormulario.Controls.Add(lblTema);

            ComboBox cmbTema = new ComboBox
            {
                Name = "cmbTema",
                Location = new Point(10, posY + 25),
                Width = 370,
                Height = 35,
                Font = new Font("Segoe UI", 10),
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cmbTema.Items.AddRange(new string[] { "Ciclos", "Variables", "Condicionales", "Algoritmos", "General" });
            panelFormulario.Controls.Add(cmbTema);
            posY += 70;

            // Archivo Adjunto
            Label lblArchivo = new Label
            {
                Text = "Archivo Adjunto",
                Location = new Point(10, posY),
                AutoSize = true,
                Font = new Font("Segoe UI", 10, FontStyle.Bold)
            };
            panelFormulario.Controls.Add(lblArchivo);

            TextBox txtRutaArchivo = new TextBox
            {
                Name = "txtRutaArchivo",
                Location = new Point(10, posY + 25),
                Width = 280,
                Height = 35,
                ReadOnly = true,
                Font = new Font("Segoe UI", 10),
                BackColor = Color.White
            };
            panelFormulario.Controls.Add(txtRutaArchivo);

            Button btnExaminar = new Button
            {
                Text = "📁 Examinar",
                Location = new Point(295, posY + 25),
                Width = 85,
                Height = 35,
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                BackColor = Color.FromArgb(132, 78, 255),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Name = "btnExaminar"
            };
            btnExaminar.Click += (s, e) => ExaminarArchivo(txtRutaArchivo);
            panelFormulario.Controls.Add(btnExaminar);
            posY += 70;

            // Botones de Acción
            Button btnCrear = new Button
            {
                Text = "✅ Crear Tarea",
                Location = new Point(10, posY),
                Width = 170,
                Height = 40,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                BackColor = Color.FromArgb(76, 175, 80),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Name = "btnCrear"
            };
            btnCrear.Click += (s, e) => CrearTarea(txtTitulo, txtDescripcion, dtpFecha, cmbTema, txtRutaArchivo);
            panelFormulario.Controls.Add(btnCrear);

            Button btnActualizar = new Button
            {
                Text = "🔄 Actualizar",
                Location = new Point(185, posY),
                Width = 185,
                Height = 40,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                BackColor = Color.FromArgb(33, 150, 243),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Name = "btnActualizar"
            };
            btnActualizar.Click += (s, e) => ActualizarTarea(txtTitulo, txtDescripcion, dtpFecha, cmbTema, txtRutaArchivo);
            panelFormulario.Controls.Add(btnActualizar);
            posY += 50;

            Button btnEliminar = new Button
            {
                Text = "🗑️ Eliminar",
                Location = new Point(10, posY),
                Width = 370,
                Height = 40,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                BackColor = Color.FromArgb(244, 67, 54),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Name = "btnEliminar"
            };
            btnEliminar.Click += (s, e) => EliminarTarea();
            panelFormulario.Controls.Add(btnEliminar);
            posY += 50;

            Button btnLimpiar = new Button
            {
                Text = "🧹 Limpiar Formulario",
                Location = new Point(10, posY),
                Width = 370,
                Height = 40,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                BackColor = Color.FromArgb(255, 152, 0),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Name = "btnLimpiar"
            };
            btnLimpiar.Click += (s, e) => LimpiarFormulario(txtTitulo, txtDescripcion, dtpFecha, cmbTema, txtRutaArchivo);
            panelFormulario.Controls.Add(btnLimpiar);

            Controls.Add(panelFormulario);

            // Panel Central - Lista de Tareas
            Panel panelLista = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                Padding = new Padding(15)
            };

            Label lblTareasLabel = new Label
            {
                Text = "📝 Tareas Creadas",
                Location = new Point(10, 10),
                AutoSize = true,
                Font = new Font("Segoe UI", 12, FontStyle.Bold)
            };
            panelLista.Controls.Add(lblTareasLabel);

            // DataGridView para listar tareas
            DataGridView dgvTareas = new DataGridView
            {
                Name = "dgvTareas",
                Location = new Point(10, 40),
                Width = panelLista.Width - 25,
                Height = panelLista.Height - 120,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                MultiSelect = false,
                Font = new Font("Segoe UI", 9),
                BackgroundColor = Color.WhiteSmoke,
                BorderStyle = BorderStyle.Fixed3D
            };

            dgvTareas.Columns.Add("Id", "ID");
            dgvTareas.Columns.Add("Titulo", "Título");
            dgvTareas.Columns.Add("TemaAsociado", "Tema");
            dgvTareas.Columns.Add("FechaEntrega", "Fecha Entrega");
            dgvTareas.Columns.Add("Completada", "Completada");

            dgvTareas.CellClick += (s, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    int idTarea = (int)dgvTareas.Rows[e.RowIndex].Cells["Id"].Value;
                    tareaSeleccionada = TareaService.ObtenerTareaPorId(idTarea);
                    CargarTareaEnFormulario(txtTitulo, txtDescripcion, dtpFecha, cmbTema, txtRutaArchivo);
                }
            };

            panelLista.Controls.Add(dgvTareas);

            // Panel de Estadísticas
            Panel panelEstadisticas = new Panel
            {
                Location = new Point(10, dgvTareas.Bottom + 10),
                Width = panelLista.Width - 25,
                Height = 50,
                BackColor = Color.FromArgb(240, 240, 240),
                BorderStyle = BorderStyle.FixedSingle
            };

            Label lblEstadisticas = new Label
            {
                Name = "lblEstadisticas",
                Text = "🔔 Tareas subidas: 0 | Completadas: 0",
                Location = new Point(10, 10),
                AutoSize = true,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.FromArgb(132, 78, 255)
            };
            panelEstadisticas.Controls.Add(lblEstadisticas);
            panelLista.Controls.Add(panelEstadisticas);

            Controls.Add(panelLista);

            // Configuración del formulario
            Text = "Gestor de Tareas - Docentes";
            Size = new Size(1200, 700);
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.Sizable;
            BackColor = Color.White;

            // Tag para acceso rápido a controles
            Tag = new Dictionary<string, Control>
            {
                { "dgvTareas", dgvTareas },
                { "lblEstadisticas", lblEstadisticas },
                { "txtTitulo", txtTitulo },
                { "txtDescripcion", txtDescripcion },
                { "dtpFecha", dtpFecha },
                { "cmbTema", cmbTema },
                { "txtRutaArchivo", txtRutaArchivo }
            };
        }

        private void CargarTareas()
        {
            tareasCargadas = TareaService.ObtenerTodasLasTareas();
            ActualizarDataGridView();
            ActualizarEstadisticas();
        }

        private void ActualizarDataGridView()
        {
            var dict = Tag as Dictionary<string, Control>;
            var dgvTareas = dict["dgvTareas"] as DataGridView;
            dgvTareas.Rows.Clear();

            foreach (var tarea in tareasCargadas)
            {
                dgvTareas.Rows.Add(
                    tarea.Id,
                    tarea.Titulo,
                    tarea.TemaAsociado,
                    tarea.FechaEntrega.ToString("dd/MM/yyyy"),
                    tarea.Completada ? "✓" : "✗"
                );
            }
        }

        private void ActualizarEstadisticas()
        {
            var dict = Tag as Dictionary<string, Control>;
            var lblEstadisticas = dict["lblEstadisticas"] as Label;
            int totalTareas = TareaService.ObtenerCantidadTareas();
            int completadas = TareaService.ObtenerCantidadTareasCompletadas();
            lblEstadisticas.Text = $"🔔 Tareas subidas: {totalTareas} | Completadas: {completadas}";
        }

        private void CrearTarea(TextBox txtTitulo, TextBox txtDescripcion, DateTimePicker dtpFecha, ComboBox cmbTema, TextBox txtRutaArchivo)
        {
            if (string.IsNullOrWhiteSpace(txtTitulo.Text))
            {
                MessageBox.Show("Por favor ingresa un título para la tarea.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Por favor ingresa una descripción para la tarea.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbTema.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor selecciona un tema.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                TareaService.CrearTarea(
                    txtTitulo.Text,
                    txtDescripcion.Text,
                    dtpFecha.Value,
                    txtRutaArchivo.Text,
                    cmbTema.SelectedItem.ToString()
                );

                MessageBox.Show("✅ Tarea creada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario(txtTitulo, txtDescripcion, dtpFecha, cmbTema, txtRutaArchivo);
                CargarTareas();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear la tarea: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarTarea(TextBox txtTitulo, TextBox txtDescripcion, DateTimePicker dtpFecha, ComboBox cmbTema, TextBox txtRutaArchivo)
        {
            if (tareaSeleccionada == null)
            {
                MessageBox.Show("Por favor selecciona una tarea de la lista para actualizar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTitulo.Text) || string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Por favor completa todos los campos requeridos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                TareaService.ActualizarTarea(
                    tareaSeleccionada.Id,
                    txtTitulo.Text,
                    txtDescripcion.Text,
                    dtpFecha.Value,
                    txtRutaArchivo.Text,
                    cmbTema.SelectedItem.ToString()
                );

                MessageBox.Show("✅ Tarea actualizada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario(txtTitulo, txtDescripcion, dtpFecha, cmbTema, txtRutaArchivo);
                tareaSeleccionada = null;
                CargarTareas();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar la tarea: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EliminarTarea()
        {
            if (tareaSeleccionada == null)
            {
                MessageBox.Show("Por favor selecciona una tarea de la lista para eliminar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resultado = MessageBox.Show(
                $"¿Estás seguro de que deseas eliminar la tarea '{tareaSeleccionada.Titulo}'?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    TareaService.EliminarTarea(tareaSeleccionada.Id);
                    MessageBox.Show("✅ Tarea eliminada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tareaSeleccionada = null;
                    CargarTareas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar la tarea: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CargarTareaEnFormulario(TextBox txtTitulo, TextBox txtDescripcion, DateTimePicker dtpFecha, ComboBox cmbTema, TextBox txtRutaArchivo)
        {
            if (tareaSeleccionada != null)
            {
                txtTitulo.Text = tareaSeleccionada.Titulo;
                txtDescripcion.Text = tareaSeleccionada.Descripcion;
                dtpFecha.Value = tareaSeleccionada.FechaEntrega;
                cmbTema.SelectedItem = tareaSeleccionada.TemaAsociado;
                txtRutaArchivo.Text = tareaSeleccionada.RutaArchivo;
            }
        }

        private void LimpiarFormulario(TextBox txtTitulo, TextBox txtDescripcion, DateTimePicker dtpFecha, ComboBox cmbTema, TextBox txtRutaArchivo)
        {
            txtTitulo.Clear();
            txtDescripcion.Clear();
            dtpFecha.Value = DateTime.Now.AddDays(7);
            cmbTema.SelectedIndex = -1;
            txtRutaArchivo.Clear();
            tareaSeleccionada = null;
        }

        private void ExaminarArchivo(TextBox txtRutaArchivo)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Todos los archivos (*.*)|*.*|Archivos PDF (*.pdf)|*.pdf|Archivos de Código (*.cs;*.java;*.cpp)|*.cs;*.java;*.cpp",
                Title = "Seleccionar archivo adjunto"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtRutaArchivo.Text = openFileDialog.FileName;
            }
        }
    }
}
