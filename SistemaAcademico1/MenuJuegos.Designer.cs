namespace SistemaAcademico1
{
    partial class MenuJuegos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuJuegos));
            panelTitulo = new Panel();
            btnRegresar = new Button();
            lblSubtitulo = new Label();
            lblTitulo = new Label();
            panelJuegos = new Panel();
            tarjetaJuego4 = new Panel();
            btnJuego4 = new Button();
            lblJuego4Descripcion = new Label();
            lblJuego4Titulo = new Label();
            tarjetaJuego3 = new Panel();
            btnJuego3 = new Button();
            lblJuego3Descripcion = new Label();
            LogiFlow = new Label();
            tarjetaJuego2 = new Panel();
            btnJuego2 = new Button();
            lblJuego2Descripcion = new Label();
            lblJuego2Titulo = new Label();
            tarjetaOrdenarCodigo = new Panel();
            button1 = new Button();
            btnOrdenarCodigo = new Button();
            lblOrdenarDescripcion = new Label();
            lblOrdenarTitulo = new Label();
            panelInfo = new Panel();
            lblInfoTitulo = new Label();
            panelTitulo.SuspendLayout();
            panelJuegos.SuspendLayout();
            tarjetaJuego4.SuspendLayout();
            tarjetaJuego3.SuspendLayout();
            tarjetaJuego2.SuspendLayout();
            tarjetaOrdenarCodigo.SuspendLayout();
            panelInfo.SuspendLayout();
            SuspendLayout();
            // 
            // panelTitulo
            // 
            panelTitulo.BackColor = Color.FromArgb(8, 22, 56);
            panelTitulo.BackgroundImage = (Image)resources.GetObject("panelTitulo.BackgroundImage");
            panelTitulo.Controls.Add(btnRegresar);
            panelTitulo.Controls.Add(lblSubtitulo);
            panelTitulo.Controls.Add(lblTitulo);
            panelTitulo.Location = new Point(40, 35);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(1200, 145);
            panelTitulo.TabIndex = 0;
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = Color.FromArgb(10, 25, 65);
            btnRegresar.FlatStyle = FlatStyle.Flat;
            btnRegresar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegresar.ForeColor = Color.White;
            btnRegresar.Location = new Point(1015, 50);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(145, 45);
            btnRegresar.TabIndex = 2;
            btnRegresar.Text = "← Regresar";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.BackColor = Color.Transparent;
            lblSubtitulo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitulo.ForeColor = Color.Gainsboro;
            lblSubtitulo.Location = new Point(35, 82);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(662, 28);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Selecciona un minijuego para practicar programación de forma interactiva.";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(30, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(426, 60);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Juegos Interactivos";
            // 
            // panelJuegos
            // 
            panelJuegos.BackColor = Color.Transparent;
            panelJuegos.Controls.Add(tarjetaJuego4);
            panelJuegos.Controls.Add(tarjetaJuego3);
            panelJuegos.Controls.Add(tarjetaJuego2);
            panelJuegos.Controls.Add(tarjetaOrdenarCodigo);
            panelJuegos.Location = new Point(40, 210);
            panelJuegos.Name = "panelJuegos";
            panelJuegos.Size = new Size(1200, 390);
            panelJuegos.TabIndex = 1;
            // 
            // tarjetaJuego4
            // 
            tarjetaJuego4.BackColor = Color.FromArgb(13, 35, 79);
            tarjetaJuego4.Controls.Add(btnJuego4);
            tarjetaJuego4.Controls.Add(lblJuego4Descripcion);
            tarjetaJuego4.Controls.Add(lblJuego4Titulo);
            tarjetaJuego4.Location = new Point(915, 10);
            tarjetaJuego4.Name = "tarjetaJuego4";
            tarjetaJuego4.Size = new Size(270, 355);
            tarjetaJuego4.TabIndex = 3;
            // 
            // btnJuego4
            // 
            btnJuego4.BackColor = Color.FromArgb(132, 78, 255);
            btnJuego4.FlatStyle = FlatStyle.Flat;
            btnJuego4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnJuego4.ForeColor = Color.White;
            btnJuego4.Location = new Point(25, 285);
            btnJuego4.Name = "btnJuego4";
            btnJuego4.Size = new Size(220, 45);
            btnJuego4.TabIndex = 2;
            btnJuego4.Text = "Pendiente";
            btnJuego4.UseVisualStyleBackColor = false;
            btnJuego4.Click += btnJuego4_Click;
            // 
            // lblJuego4Descripcion
            // 
            lblJuego4Descripcion.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblJuego4Descripcion.ForeColor = Color.Gainsboro;
            lblJuego4Descripcion.Location = new Point(25, 110);
            lblJuego4Descripcion.Name = "lblJuego4Descripcion";
            lblJuego4Descripcion.Size = new Size(220, 125);
            lblJuego4Descripcion.TabIndex = 1;
            lblJuego4Descripcion.Text = "Selecciona las letras que creas correctas y completa la palabra antes de quedarte sin intentos";
            // 
            // lblJuego4Titulo
            // 
            lblJuego4Titulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJuego4Titulo.ForeColor = Color.FromArgb(255, 190, 70);
            lblJuego4Titulo.Location = new Point(79, 19);
            lblJuego4Titulo.Name = "lblJuego4Titulo";
            lblJuego4Titulo.Size = new Size(220, 70);
            lblJuego4Titulo.TabIndex = 0;
            lblJuego4Titulo.Text = "Codix";
            // 
            // tarjetaJuego3
            // 
            tarjetaJuego3.BackColor = Color.FromArgb(13, 35, 79);
            tarjetaJuego3.Controls.Add(btnJuego3);
            tarjetaJuego3.Controls.Add(lblJuego3Descripcion);
            tarjetaJuego3.Controls.Add(LogiFlow);
            tarjetaJuego3.Location = new Point(620, 10);
            tarjetaJuego3.Name = "tarjetaJuego3";
            tarjetaJuego3.Size = new Size(270, 355);
            tarjetaJuego3.TabIndex = 2;
            // 
            // btnJuego3
            // 
            btnJuego3.BackColor = Color.FromArgb(132, 78, 255);
            btnJuego3.FlatStyle = FlatStyle.Flat;
            btnJuego3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnJuego3.ForeColor = Color.White;
            btnJuego3.Location = new Point(25, 285);
            btnJuego3.Name = "btnJuego3";
            btnJuego3.Size = new Size(220, 45);
            btnJuego3.TabIndex = 2;
            btnJuego3.Text = "Jugar";
            btnJuego3.UseVisualStyleBackColor = false;
            btnJuego3.Click += btnJuego3_Click;
            // 
            // lblJuego3Descripcion
            // 
            lblJuego3Descripcion.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblJuego3Descripcion.ForeColor = Color.Gainsboro;
            lblJuego3Descripcion.Location = new Point(25, 110);
            lblJuego3Descripcion.Name = "lblJuego3Descripcion";
            lblJuego3Descripcion.Size = new Size(220, 125);
            lblJuego3Descripcion.TabIndex = 1;
            lblJuego3Descripcion.Text = "Juego de rompecabezas en el que el jugador debe ordenar y unir las piezas correctamente para completar una imagen, poniendo a prueba su lógica, concentración y rapidez.\r\n";
            // 
            // LogiFlow
            // 
            LogiFlow.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogiFlow.ForeColor = Color.FromArgb(95, 210, 255);
            LogiFlow.Location = new Point(25, 19);
            LogiFlow.Name = "LogiFlow";
            LogiFlow.Size = new Size(220, 70);
            LogiFlow.TabIndex = 0;
            LogiFlow.Text = "LogiFlow";
            // 
            // tarjetaJuego2
            // 
            tarjetaJuego2.BackColor = Color.FromArgb(13, 35, 79);
            tarjetaJuego2.Controls.Add(btnJuego2);
            tarjetaJuego2.Controls.Add(lblJuego2Descripcion);
            tarjetaJuego2.Controls.Add(lblJuego2Titulo);
            tarjetaJuego2.Location = new Point(325, 10);
            tarjetaJuego2.Name = "tarjetaJuego2";
            tarjetaJuego2.Size = new Size(270, 355);
            tarjetaJuego2.TabIndex = 1;
            // 
            // btnJuego2
            // 
            btnJuego2.BackColor = Color.FromArgb(132, 78, 255);
            btnJuego2.FlatStyle = FlatStyle.Flat;
            btnJuego2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnJuego2.ForeColor = Color.White;
            btnJuego2.Location = new Point(25, 285);
            btnJuego2.Name = "btnJuego2";
            btnJuego2.Size = new Size(220, 45);
            btnJuego2.TabIndex = 2;
            btnJuego2.Text = "Jugar";
            btnJuego2.UseVisualStyleBackColor = false;
            btnJuego2.Click += btnJuego2_Click;
            // 
            // lblJuego2Descripcion
            // 
            lblJuego2Descripcion.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblJuego2Descripcion.ForeColor = Color.Gainsboro;
            lblJuego2Descripcion.Location = new Point(25, 110);
            lblJuego2Descripcion.Name = "lblJuego2Descripcion";
            lblJuego2Descripcion.Size = new Size(220, 125);
            lblJuego2Descripcion.TabIndex = 1;
            lblJuego2Descripcion.Text = "Juego de memoria CodiMemo: encuentra la carta correcta sobre variables.";
            // 
            // lblJuego2Titulo
            // 
            lblJuego2Titulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJuego2Titulo.ForeColor = Color.FromArgb(80, 230, 160);
            lblJuego2Titulo.Location = new Point(25, 30);
            lblJuego2Titulo.Name = "lblJuego2Titulo";
            lblJuego2Titulo.Size = new Size(220, 70);
            lblJuego2Titulo.TabIndex = 0;
            lblJuego2Titulo.Text = "CodiMemo";
            // 
            // tarjetaOrdenarCodigo
            // 
            tarjetaOrdenarCodigo.BackColor = Color.FromArgb(13, 35, 79);
            tarjetaOrdenarCodigo.Controls.Add(button1);
            tarjetaOrdenarCodigo.Controls.Add(btnOrdenarCodigo);
            tarjetaOrdenarCodigo.Controls.Add(lblOrdenarDescripcion);
            tarjetaOrdenarCodigo.Controls.Add(lblOrdenarTitulo);
            tarjetaOrdenarCodigo.Location = new Point(30, 10);
            tarjetaOrdenarCodigo.Name = "tarjetaOrdenarCodigo";
            tarjetaOrdenarCodigo.Size = new Size(270, 355);
            tarjetaOrdenarCodigo.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(132, 78, 255);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(25, 285);
            button1.Name = "button1";
            button1.Size = new Size(220, 45);
            button1.TabIndex = 3;
            button1.Text = "Tutorial";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnOrdenarCodigo
            // 
            btnOrdenarCodigo.BackColor = Color.FromArgb(132, 78, 255);
            btnOrdenarCodigo.FlatStyle = FlatStyle.Flat;
            btnOrdenarCodigo.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOrdenarCodigo.ForeColor = Color.White;
            btnOrdenarCodigo.Location = new Point(25, 226);
            btnOrdenarCodigo.Name = "btnOrdenarCodigo";
            btnOrdenarCodigo.Size = new Size(220, 45);
            btnOrdenarCodigo.TabIndex = 2;
            btnOrdenarCodigo.Text = "Jugar";
            btnOrdenarCodigo.UseVisualStyleBackColor = false;
            btnOrdenarCodigo.Click += btnOrdenarCodigo_Click;
            // 
            // lblOrdenarDescripcion
            // 
            lblOrdenarDescripcion.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOrdenarDescripcion.ForeColor = Color.Gainsboro;
            lblOrdenarDescripcion.Location = new Point(25, 110);
            lblOrdenarDescripcion.Name = "lblOrdenarDescripcion";
            lblOrdenarDescripcion.Size = new Size(220, 125);
            lblOrdenarDescripcion.TabIndex = 1;
            lblOrdenarDescripcion.Text = "Ordena bloques de código desde niveles básicos hasta un reto final con if, for y switch.";
            // 
            // lblOrdenarTitulo
            // 
            lblOrdenarTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrdenarTitulo.ForeColor = Color.FromArgb(132, 78, 255);
            lblOrdenarTitulo.Location = new Point(25, 30);
            lblOrdenarTitulo.Name = "lblOrdenarTitulo";
            lblOrdenarTitulo.Size = new Size(220, 70);
            lblOrdenarTitulo.TabIndex = 0;
            lblOrdenarTitulo.Text = "LoopMaster";
            // 
            // panelInfo
            // 
            panelInfo.BackColor = Color.FromArgb(8, 22, 56);
            panelInfo.BackgroundImage = (Image)resources.GetObject("panelInfo.BackgroundImage");
            panelInfo.Controls.Add(lblInfoTitulo);
            panelInfo.Location = new Point(40, 625);
            panelInfo.Name = "panelInfo";
            panelInfo.Size = new Size(1200, 120);
            panelInfo.TabIndex = 2;
            // 
            // lblInfoTitulo
            // 
            lblInfoTitulo.AutoSize = true;
            lblInfoTitulo.BackColor = Color.Transparent;
            lblInfoTitulo.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInfoTitulo.ForeColor = Color.White;
            lblInfoTitulo.Location = new Point(442, 42);
            lblInfoTitulo.Name = "lblInfoTitulo";
            lblInfoTitulo.Size = new Size(242, 35);
            lblInfoTitulo.TabIndex = 0;
            lblInfoTitulo.Text = "Centro de prácticas";
            // 
            // MenuJuegos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(6, 16, 41);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1290, 790);
            Controls.Add(panelInfo);
            Controls.Add(panelJuegos);
            Controls.Add(panelTitulo);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MenuJuegos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuJuegos";
            panelTitulo.ResumeLayout(false);
            panelTitulo.PerformLayout();
            panelJuegos.ResumeLayout(false);
            tarjetaJuego4.ResumeLayout(false);
            tarjetaJuego3.ResumeLayout(false);
            tarjetaJuego2.ResumeLayout(false);
            tarjetaOrdenarCodigo.ResumeLayout(false);
            panelInfo.ResumeLayout(false);
            panelInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTitulo;
        private Label lblTitulo;
        private Label lblSubtitulo;
        private Button btnRegresar;
        private Panel panelJuegos;
        private Panel tarjetaOrdenarCodigo;
        private Label lblOrdenarTitulo;
        private Label lblOrdenarDescripcion;
        private Button btnOrdenarCodigo;
        private Panel tarjetaJuego2;
        private Button btnJuego2;
        private Label lblJuego2Descripcion;
        private Label lblJuego2Titulo;
        private Panel tarjetaJuego3;
        private Button btnJuego3;
        private Label lblJuego3Descripcion;
        private Label LogiFlow;
        private Panel tarjetaJuego4;
        private Button btnJuego4;
        private Label lblJuego4Descripcion;
        private Label lblJuego4Titulo;
        private Panel panelInfo;
        private Label lblInfoTitulo;
        private Button button1;
    }
}
