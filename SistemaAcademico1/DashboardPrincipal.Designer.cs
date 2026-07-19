namespace SistemaAcademico1
{
    partial class DashboardPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelHeader = new Panel();
            lblUsuario = new Label();
            btnCerrarSesion = new Button();
            btnEntrar = new Button();
            lblSubtitulo = new Label();
            lblTitulo = new Label();
            panelTarjetas = new Panel();
            tarjetaRendimiento = new Panel();
            lblRendimientoTexto = new Label();
            lblRendimientoValor = new Label();
            tarjetaActividades = new Panel();
            lblActividadesTexto = new Label();
            lblActividadesValor = new Label();
            tarjetaProgreso = new Panel();
            lblProgresoTexto = new Label();
            lblProgresoValor = new Label();
            tarjetaDocentes = new Panel();
            lblDocentesTexto = new Label();
            lblDocentesValor = new Label();
            tarjetaEstudiantes = new Panel();
            lblEstudiantesTexto = new Label();
            lblEstudiantesValor = new Label();
            panelActividad = new Panel();
            lblAct5 = new Label();
            lblAct4 = new Label();
            lblAct3 = new Label();
            lblAct2 = new Label();
            lblAct1 = new Label();
            lblActividadTitulo = new Label();
            panelProgreso = new Panel();
            progressActividades = new ProgressBar();
            progressRendimiento = new ProgressBar();
            progressGeneral = new ProgressBar();
            lblBar3 = new Label();
            lblBar2 = new Label();
            lblBar1 = new Label();
            lblProgresoGeneralTitulo = new Label();
            panelGrafico = new Panel();
            lblGraficoSubtitulo = new Label();
            lblGraficoTitulo = new Label();
            panelHeader.SuspendLayout();
            panelTarjetas.SuspendLayout();
            tarjetaRendimiento.SuspendLayout();
            tarjetaActividades.SuspendLayout();
            tarjetaProgreso.SuspendLayout();
            tarjetaDocentes.SuspendLayout();
            tarjetaEstudiantes.SuspendLayout();
            panelActividad.SuspendLayout();
            panelProgreso.SuspendLayout();
            panelGrafico.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(9, 25, 62);
            panelHeader.Controls.Add(lblUsuario);
            panelHeader.Controls.Add(btnCerrarSesion);
            panelHeader.Controls.Add(btnEntrar);
            panelHeader.Controls.Add(lblSubtitulo);
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Location = new Point(35, 35);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1490, 155);
            panelHeader.TabIndex = 0;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.ForeColor = Color.FromArgb(95, 210, 255);
            lblUsuario.Location = new Point(43, 106);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(177, 23);
            lblUsuario.TabIndex = 4;
            lblUsuario.Text = "Vista administrador";
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.FromArgb(9, 25, 62);
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrarSesion.ForeColor = Color.White;
            btnCerrarSesion.Location = new Point(1120, 53);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(160, 50);
            btnCerrarSesion.TabIndex = 3;
            btnCerrarSesion.Text = "Cerrar sesión";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.FromArgb(132, 78, 255);
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.ForeColor = Color.White;
            btnEntrar.Location = new Point(1300, 53);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(155, 50);
            btnEntrar.TabIndex = 2;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitulo.ForeColor = Color.Gainsboro;
            lblSubtitulo.Location = new Point(40, 70);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(395, 32);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Este es el resumen general del sistema";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 27F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(35, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(719, 61);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Buenos días, Administrador 👋";
            // 
            // panelTarjetas
            // 
            panelTarjetas.BackColor = Color.Transparent;
            panelTarjetas.Controls.Add(tarjetaRendimiento);
            panelTarjetas.Controls.Add(tarjetaActividades);
            panelTarjetas.Controls.Add(tarjetaProgreso);
            panelTarjetas.Controls.Add(tarjetaDocentes);
            panelTarjetas.Controls.Add(tarjetaEstudiantes);
            panelTarjetas.Location = new Point(35, 215);
            panelTarjetas.Name = "panelTarjetas";
            panelTarjetas.Size = new Size(1490, 135);
            panelTarjetas.TabIndex = 1;
            // 
            // tarjetaRendimiento
            // 
            tarjetaRendimiento.BackColor = Color.FromArgb(13, 35, 79);
            tarjetaRendimiento.Controls.Add(lblRendimientoTexto);
            tarjetaRendimiento.Controls.Add(lblRendimientoValor);
            tarjetaRendimiento.Location = new Point(1190, 0);
            tarjetaRendimiento.Name = "tarjetaRendimiento";
            tarjetaRendimiento.Size = new Size(280, 125);
            tarjetaRendimiento.TabIndex = 4;
            // 
            // lblRendimientoTexto
            // 
            lblRendimientoTexto.AutoSize = true;
            lblRendimientoTexto.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRendimientoTexto.ForeColor = Color.Gainsboro;
            lblRendimientoTexto.Location = new Point(22, 76);
            lblRendimientoTexto.Name = "lblRendimientoTexto";
            lblRendimientoTexto.Size = new Size(239, 23);
            lblRendimientoTexto.TabIndex = 1;
            lblRendimientoTexto.Text = "Rendimiento académico prom.";
            // 
            // lblRendimientoValor
            // 
            lblRendimientoValor.AutoSize = true;
            lblRendimientoValor.Font = new Font("Segoe UI", 27F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRendimientoValor.ForeColor = Color.FromArgb(255, 190, 70);
            lblRendimientoValor.Location = new Point(20, 12);
            lblRendimientoValor.Name = "lblRendimientoValor";
            lblRendimientoValor.Size = new Size(106, 61);
            lblRendimientoValor.TabIndex = 0;
            lblRendimientoValor.Text = "8.9";
            // 
            // tarjetaActividades
            // 
            tarjetaActividades.BackColor = Color.FromArgb(13, 35, 79);
            tarjetaActividades.Controls.Add(lblActividadesTexto);
            tarjetaActividades.Controls.Add(lblActividadesValor);
            tarjetaActividades.Location = new Point(895, 0);
            tarjetaActividades.Name = "tarjetaActividades";
            tarjetaActividades.Size = new Size(280, 125);
            tarjetaActividades.TabIndex = 3;
            // 
            // lblActividadesTexto
            // 
            lblActividadesTexto.AutoSize = true;
            lblActividadesTexto.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblActividadesTexto.ForeColor = Color.Gainsboro;
            lblActividadesTexto.Location = new Point(22, 76);
            lblActividadesTexto.Name = "lblActividadesTexto";
            lblActividadesTexto.Size = new Size(135, 23);
            lblActividadesTexto.TabIndex = 1;
            lblActividadesTexto.Text = "Total actividades";
            // 
            // lblActividadesValor
            // 
            lblActividadesValor.AutoSize = true;
            lblActividadesValor.Font = new Font("Segoe UI", 27F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblActividadesValor.ForeColor = Color.FromArgb(80, 230, 160);
            lblActividadesValor.Location = new Point(20, 12);
            lblActividadesValor.Name = "lblActividadesValor";
            lblActividadesValor.Size = new Size(78, 61);
            lblActividadesValor.TabIndex = 0;
            lblActividadesValor.Text = "18";
            // 
            // tarjetaProgreso
            // 
            tarjetaProgreso.BackColor = Color.FromArgb(13, 35, 79);
            tarjetaProgreso.Controls.Add(lblProgresoTexto);
            tarjetaProgreso.Controls.Add(lblProgresoValor);
            tarjetaProgreso.Location = new Point(600, 0);
            tarjetaProgreso.Name = "tarjetaProgreso";
            tarjetaProgreso.Size = new Size(280, 125);
            tarjetaProgreso.TabIndex = 2;
            // 
            // lblProgresoTexto
            // 
            lblProgresoTexto.AutoSize = true;
            lblProgresoTexto.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProgresoTexto.ForeColor = Color.Gainsboro;
            lblProgresoTexto.Location = new Point(22, 76);
            lblProgresoTexto.Name = "lblProgresoTexto";
            lblProgresoTexto.Size = new Size(157, 23);
            lblProgresoTexto.TabIndex = 1;
            lblProgresoTexto.Text = "Progreso promedio";
            // 
            // lblProgresoValor
            // 
            lblProgresoValor.AutoSize = true;
            lblProgresoValor.Font = new Font("Segoe UI", 27F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProgresoValor.ForeColor = Color.FromArgb(132, 78, 255);
            lblProgresoValor.Location = new Point(20, 12);
            lblProgresoValor.Name = "lblProgresoValor";
            lblProgresoValor.Size = new Size(123, 61);
            lblProgresoValor.TabIndex = 0;
            lblProgresoValor.Text = "76%";
            // 
            // tarjetaDocentes
            // 
            tarjetaDocentes.BackColor = Color.FromArgb(13, 35, 79);
            tarjetaDocentes.Controls.Add(lblDocentesTexto);
            tarjetaDocentes.Controls.Add(lblDocentesValor);
            tarjetaDocentes.Location = new Point(305, 0);
            tarjetaDocentes.Name = "tarjetaDocentes";
            tarjetaDocentes.Size = new Size(280, 125);
            tarjetaDocentes.TabIndex = 1;
            // 
            // lblDocentesTexto
            // 
            lblDocentesTexto.AutoSize = true;
            lblDocentesTexto.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDocentesTexto.ForeColor = Color.Gainsboro;
            lblDocentesTexto.Location = new Point(22, 76);
            lblDocentesTexto.Name = "lblDocentesTexto";
            lblDocentesTexto.Size = new Size(118, 23);
            lblDocentesTexto.TabIndex = 1;
            lblDocentesTexto.Text = "Total docentes";
            // 
            // lblDocentesValor
            // 
            lblDocentesValor.AutoSize = true;
            lblDocentesValor.Font = new Font("Segoe UI", 27F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDocentesValor.ForeColor = Color.FromArgb(95, 210, 255);
            lblDocentesValor.Location = new Point(20, 12);
            lblDocentesValor.Name = "lblDocentesValor";
            lblDocentesValor.Size = new Size(52, 61);
            lblDocentesValor.TabIndex = 0;
            lblDocentesValor.Text = "4";
            // 
            // tarjetaEstudiantes
            // 
            tarjetaEstudiantes.BackColor = Color.FromArgb(13, 35, 79);
            tarjetaEstudiantes.Controls.Add(lblEstudiantesTexto);
            tarjetaEstudiantes.Controls.Add(lblEstudiantesValor);
            tarjetaEstudiantes.Location = new Point(10, 0);
            tarjetaEstudiantes.Name = "tarjetaEstudiantes";
            tarjetaEstudiantes.Size = new Size(280, 125);
            tarjetaEstudiantes.TabIndex = 0;
            // 
            // lblEstudiantesTexto
            // 
            lblEstudiantesTexto.AutoSize = true;
            lblEstudiantesTexto.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstudiantesTexto.ForeColor = Color.Gainsboro;
            lblEstudiantesTexto.Location = new Point(22, 76);
            lblEstudiantesTexto.Name = "lblEstudiantesTexto";
            lblEstudiantesTexto.Size = new Size(142, 23);
            lblEstudiantesTexto.TabIndex = 1;
            lblEstudiantesTexto.Text = "Total estudiantes";
            // 
            // lblEstudiantesValor
            // 
            lblEstudiantesValor.AutoSize = true;
            lblEstudiantesValor.Font = new Font("Segoe UI", 27F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstudiantesValor.ForeColor = Color.White;
            lblEstudiantesValor.Location = new Point(20, 12);
            lblEstudiantesValor.Name = "lblEstudiantesValor";
            lblEstudiantesValor.Size = new Size(78, 61);
            lblEstudiantesValor.TabIndex = 0;
            lblEstudiantesValor.Text = "45";
            // 
            // panelActividad
            // 
            panelActividad.BackColor = Color.FromArgb(9, 25, 62);
            panelActividad.Controls.Add(lblAct5);
            panelActividad.Controls.Add(lblAct4);
            panelActividad.Controls.Add(lblAct3);
            panelActividad.Controls.Add(lblAct2);
            panelActividad.Controls.Add(lblAct1);
            panelActividad.Controls.Add(lblActividadTitulo);
            panelActividad.Location = new Point(35, 375);
            panelActividad.Name = "panelActividad";
            panelActividad.Size = new Size(560, 405);
            panelActividad.TabIndex = 2;
            // 
            // lblAct5
            // 
            lblAct5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAct5.ForeColor = Color.Gainsboro;
            lblAct5.Location = new Point(35, 315);
            lblAct5.Name = "lblAct5";
            lblAct5.Size = new Size(485, 38);
            lblAct5.TabIndex = 5;
            lblAct5.Text = "📝 Se creó un nuevo cuestionario.";
            // 
            // lblAct4
            // 
            lblAct4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAct4.ForeColor = Color.Gainsboro;
            lblAct4.Location = new Point(35, 260);
            lblAct4.Name = "lblAct4";
            lblAct4.Size = new Size(485, 38);
            lblAct4.TabIndex = 4;
            lblAct4.Text = "🏆 Un estudiante desbloqueó un nivel.";
            // 
            // lblAct3
            // 
            lblAct3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAct3.ForeColor = Color.Gainsboro;
            lblAct3.Location = new Point(35, 205);
            lblAct3.Name = "lblAct3";
            lblAct3.Size = new Size(485, 38);
            lblAct3.TabIndex = 3;
            lblAct3.Text = "➕ Se agregó un nuevo ejercicio.";
            // 
            // lblAct2
            // 
            lblAct2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAct2.ForeColor = Color.Gainsboro;
            lblAct2.Location = new Point(35, 150);
            lblAct2.Name = "lblAct2";
            lblAct2.Size = new Size(485, 38);
            lblAct2.TabIndex = 2;
            lblAct2.Text = "⭐ Un estudiante obtuvo una calificación alta.";
            // 
            // lblAct1
            // 
            lblAct1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAct1.ForeColor = Color.Gainsboro;
            lblAct1.Location = new Point(35, 95);
            lblAct1.Name = "lblAct1";
            lblAct1.Size = new Size(485, 38);
            lblAct1.TabIndex = 1;
            lblAct1.Text = "✅ Un estudiante completó un tema.";
            // 
            // lblActividadTitulo
            // 
            lblActividadTitulo.AutoSize = true;
            lblActividadTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblActividadTitulo.ForeColor = Color.White;
            lblActividadTitulo.Location = new Point(30, 28);
            lblActividadTitulo.Name = "lblActividadTitulo";
            lblActividadTitulo.Size = new Size(267, 41);
            lblActividadTitulo.TabIndex = 0;
            lblActividadTitulo.Text = "Actividad reciente";
            // 
            // panelProgreso
            // 
            panelProgreso.BackColor = Color.FromArgb(9, 25, 62);
            panelProgreso.Controls.Add(progressActividades);
            panelProgreso.Controls.Add(progressRendimiento);
            panelProgreso.Controls.Add(progressGeneral);
            panelProgreso.Controls.Add(lblBar3);
            panelProgreso.Controls.Add(lblBar2);
            panelProgreso.Controls.Add(lblBar1);
            panelProgreso.Controls.Add(lblProgresoGeneralTitulo);
            panelProgreso.Location = new Point(625, 375);
            panelProgreso.Name = "panelProgreso";
            panelProgreso.Size = new Size(430, 405);
            panelProgreso.TabIndex = 3;
            // 
            // progressActividades
            // 
            progressActividades.Location = new Point(35, 315);
            progressActividades.Name = "progressActividades";
            progressActividades.Size = new Size(360, 22);
            progressActividades.TabIndex = 6;
            progressActividades.Value = 62;
            // 
            // progressRendimiento
            // 
            progressRendimiento.Location = new Point(35, 220);
            progressRendimiento.Name = "progressRendimiento";
            progressRendimiento.Size = new Size(360, 22);
            progressRendimiento.TabIndex = 5;
            progressRendimiento.Value = 89;
            // 
            // progressGeneral
            // 
            progressGeneral.Location = new Point(35, 125);
            progressGeneral.Name = "progressGeneral";
            progressGeneral.Size = new Size(360, 22);
            progressGeneral.TabIndex = 4;
            progressGeneral.Value = 76;
            // 
            // lblBar3
            // 
            lblBar3.AutoSize = true;
            lblBar3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBar3.ForeColor = Color.Gainsboro;
            lblBar3.Location = new Point(35, 282);
            lblBar3.Name = "lblBar3";
            lblBar3.Size = new Size(242, 25);
            lblBar3.TabIndex = 3;
            lblBar3.Text = "Actividades completadas 62%";
            // 
            // lblBar2
            // 
            lblBar2.AutoSize = true;
            lblBar2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBar2.ForeColor = Color.Gainsboro;
            lblBar2.Location = new Point(35, 187);
            lblBar2.Name = "lblBar2";
            lblBar2.Size = new Size(272, 25);
            lblBar2.TabIndex = 2;
            lblBar2.Text = "Rendimiento académico 89%";
            // 
            // lblBar1
            // 
            lblBar1.AutoSize = true;
            lblBar1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBar1.ForeColor = Color.Gainsboro;
            lblBar1.Location = new Point(35, 92);
            lblBar1.Name = "lblBar1";
            lblBar1.Size = new Size(200, 25);
            lblBar1.TabIndex = 1;
            lblBar1.Text = "Progreso general 76%";
            // 
            // lblProgresoGeneralTitulo
            // 
            lblProgresoGeneralTitulo.AutoSize = true;
            lblProgresoGeneralTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProgresoGeneralTitulo.ForeColor = Color.White;
            lblProgresoGeneralTitulo.Location = new Point(30, 28);
            lblProgresoGeneralTitulo.Name = "lblProgresoGeneralTitulo";
            lblProgresoGeneralTitulo.Size = new Size(251, 41);
            lblProgresoGeneralTitulo.TabIndex = 0;
            lblProgresoGeneralTitulo.Text = "Progreso general";
            // 
            // panelGrafico
            // 
            panelGrafico.BackColor = Color.FromArgb(9, 25, 62);
            panelGrafico.Controls.Add(lblGraficoSubtitulo);
            panelGrafico.Controls.Add(lblGraficoTitulo);
            panelGrafico.Location = new Point(1085, 375);
            panelGrafico.Name = "panelGrafico";
            panelGrafico.Size = new Size(440, 405);
            panelGrafico.TabIndex = 4;
            panelGrafico.Paint += panelGrafico_Paint;
            // 
            // lblGraficoSubtitulo
            // 
            lblGraficoSubtitulo.AutoSize = true;
            lblGraficoSubtitulo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGraficoSubtitulo.ForeColor = Color.Gainsboro;
            lblGraficoSubtitulo.Location = new Point(30, 70);
            lblGraficoSubtitulo.Name = "lblGraficoSubtitulo";
            lblGraficoSubtitulo.Size = new Size(277, 23);
            lblGraficoSubtitulo.TabIndex = 1;
            lblGraficoSubtitulo.Text = "Rendimiento semanal del sistema";
            // 
            // lblGraficoTitulo
            // 
            lblGraficoTitulo.AutoSize = true;
            lblGraficoTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGraficoTitulo.ForeColor = Color.White;
            lblGraficoTitulo.Location = new Point(30, 28);
            lblGraficoTitulo.Name = "lblGraficoTitulo";
            lblGraficoTitulo.Size = new Size(241, 41);
            lblGraficoTitulo.TabIndex = 0;
            lblGraficoTitulo.Text = "Gráfico moderno";
            // 
            // DashboardPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(6, 16, 41);
            ClientSize = new Size(1560, 850);
            Controls.Add(panelGrafico);
            Controls.Add(panelProgreso);
            Controls.Add(panelActividad);
            Controls.Add(panelTarjetas);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(1560, 850);
            Name = "DashboardPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard Principal";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelTarjetas.ResumeLayout(false);
            tarjetaRendimiento.ResumeLayout(false);
            tarjetaRendimiento.PerformLayout();
            tarjetaActividades.ResumeLayout(false);
            tarjetaActividades.PerformLayout();
            tarjetaProgreso.ResumeLayout(false);
            tarjetaProgreso.PerformLayout();
            tarjetaDocentes.ResumeLayout(false);
            tarjetaDocentes.PerformLayout();
            tarjetaEstudiantes.ResumeLayout(false);
            tarjetaEstudiantes.PerformLayout();
            panelActividad.ResumeLayout(false);
            panelActividad.PerformLayout();
            panelProgreso.ResumeLayout(false);
            panelProgreso.PerformLayout();
            panelGrafico.ResumeLayout(false);
            panelGrafico.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitulo;
        private Label lblSubtitulo;
        private Button btnEntrar;
        private Button btnCerrarSesion;
        private Label lblUsuario;
        private Panel panelTarjetas;
        private Panel tarjetaEstudiantes;
        private Label lblEstudiantesValor;
        private Label lblEstudiantesTexto;
        private Panel tarjetaDocentes;
        private Label lblDocentesTexto;
        private Label lblDocentesValor;
        private Panel tarjetaProgreso;
        private Label lblProgresoTexto;
        private Label lblProgresoValor;
        private Panel tarjetaActividades;
        private Label lblActividadesTexto;
        private Label lblActividadesValor;
        private Panel tarjetaRendimiento;
        private Label lblRendimientoTexto;
        private Label lblRendimientoValor;
        private Panel panelActividad;
        private Label lblActividadTitulo;
        private Label lblAct1;
        private Label lblAct2;
        private Label lblAct3;
        private Label lblAct4;
        private Label lblAct5;
        private Panel panelProgreso;
        private Label lblProgresoGeneralTitulo;
        private Label lblBar1;
        private Label lblBar2;
        private Label lblBar3;
        private ProgressBar progressGeneral;
        private ProgressBar progressRendimiento;
        private ProgressBar progressActividades;
        private Panel panelGrafico;
        private Label lblGraficoTitulo;
        private Label lblGraficoSubtitulo;
    }
}
