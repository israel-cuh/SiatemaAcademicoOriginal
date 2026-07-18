namespace SistemaAcademico1
{
    partial class CicloFor
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
            panelTitulo = new Panel();
            lblSubtitulo = new Label();
            lblTituloAzul = new Label();
            lblTitulo = new Label();
            panelIzquierdo = new Panel();
            lblImportante = new Label();
            lblExplicacion = new Label();
            lblSintaxis = new Label();
            txtSintaxis = new RichTextBox();
            lblDescripcionTema = new Label();
            lblTituloTema = new Label();
            panelDerecho = new Panel();
            lblQuePasa = new Label();
            lblExplicacionCodigo = new Label();
            btnLimpiar = new Button();
            btnEjecutar = new Button();
            lblSalida = new Label();
            txtSalida = new RichTextBox();
            lblCodigo = new Label();
            txtCodigo = new RichTextBox();
            panelInferior = new Panel();
            btnAnterior = new Button();
            btnSiguiente = new Button();
            btnPracticar = new Button();
            panelTitulo.SuspendLayout();
            panelIzquierdo.SuspendLayout();
            panelDerecho.SuspendLayout();
            panelInferior.SuspendLayout();
            SuspendLayout();
            // 
            // panelTitulo
            // 
            panelTitulo.BackColor = Color.FromArgb(8, 22, 56);
            panelTitulo.Controls.Add(lblSubtitulo);
            panelTitulo.Controls.Add(lblTituloAzul);
            panelTitulo.Controls.Add(lblTitulo);
            panelTitulo.Location = new Point(30, 25);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(1200, 120);
            panelTitulo.TabIndex = 0;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitulo.ForeColor = Color.Gainsboro;
            lblSubtitulo.Location = new Point(32, 70);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(627, 25);
            lblSubtitulo.TabIndex = 2;
            lblSubtitulo.Text = "Comprende cómo funcionan los ciclos for para repetir instrucciones.";
            // 
            // lblTituloAzul
            // 
            lblTituloAzul.AutoSize = true;
            lblTituloAzul.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloAzul.ForeColor = Color.FromArgb(132, 78, 255);
            lblTituloAzul.Location = new Point(242, 18);
            lblTituloAzul.Name = "lblTituloAzul";
            lblTituloAzul.Size = new Size(180, 50);
            lblTituloAzul.TabIndex = 1;
            lblTituloAzul.Text = "Ciclo For";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(32, 18);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(212, 50);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Aprender";
            // 
            // panelIzquierdo
            // 
            panelIzquierdo.BackColor = Color.FromArgb(8, 22, 56);
            panelIzquierdo.Controls.Add(lblImportante);
            panelIzquierdo.Controls.Add(lblExplicacion);
            panelIzquierdo.Controls.Add(lblSintaxis);
            panelIzquierdo.Controls.Add(txtSintaxis);
            panelIzquierdo.Controls.Add(lblDescripcionTema);
            panelIzquierdo.Controls.Add(lblTituloTema);
            panelIzquierdo.Location = new Point(30, 165);
            panelIzquierdo.Name = "panelIzquierdo";
            panelIzquierdo.Size = new Size(580, 520);
            panelIzquierdo.TabIndex = 1;
            // 
            // lblImportante
            // 
            lblImportante.BackColor = Color.FromArgb(27, 28, 75);
            lblImportante.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblImportante.ForeColor = Color.FromArgb(190, 140, 255);
            lblImportante.Location = new Point(28, 430);
            lblImportante.Name = "lblImportante";
            lblImportante.Size = new Size(520, 62);
            lblImportante.TabIndex = 5;
            lblImportante.Text = "ⓘ  Importante\r\nEl ciclo for es ideal cuando sabes cuántas veces se repetirá una acción.";
            // 
            // lblExplicacion
            // 
            lblExplicacion.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblExplicacion.ForeColor = Color.WhiteSmoke;
            lblExplicacion.Location = new Point(28, 285);
            lblExplicacion.Name = "lblExplicacion";
            lblExplicacion.Size = new Size(520, 132);
            lblExplicacion.TabIndex = 4;
            lblExplicacion.Text = "Explicación\r\n1. Se inicializa la variable de control.\r\n2. Se evalúa la condición.\r\n3. Si es verdadera, se ejecuta el bloque.\r\n4. Se realiza el incremento.\r\n5. Se repite hasta que la condición sea falsa.";
            // 
            // lblSintaxis
            // 
            lblSintaxis.AutoSize = true;
            lblSintaxis.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSintaxis.ForeColor = Color.White;
            lblSintaxis.Location = new Point(28, 125);
            lblSintaxis.Name = "lblSintaxis";
            lblSintaxis.Size = new Size(83, 28);
            lblSintaxis.TabIndex = 3;
            lblSintaxis.Text = "Sintaxis";
            // 
            // txtSintaxis
            // 
            txtSintaxis.BackColor = Color.FromArgb(6, 16, 41);
            txtSintaxis.BorderStyle = BorderStyle.FixedSingle;
            txtSintaxis.Font = new Font("Consolas", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSintaxis.ForeColor = Color.White;
            txtSintaxis.Location = new Point(28, 160);
            txtSintaxis.Name = "txtSintaxis";
            txtSintaxis.ReadOnly = true;
            txtSintaxis.Size = new Size(520, 105);
            txtSintaxis.TabIndex = 2;
            txtSintaxis.Text = "for (inicialización; condición; incremento)\n{\n    // instrucciones a ejecutar\n}";
            // 
            // lblDescripcionTema
            // 
            lblDescripcionTema.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescripcionTema.ForeColor = Color.Gainsboro;
            lblDescripcionTema.Location = new Point(28, 58);
            lblDescripcionTema.Name = "lblDescripcionTema";
            lblDescripcionTema.Size = new Size(520, 60);
            lblDescripcionTema.TabIndex = 1;
            lblDescripcionTema.Text = "El ciclo for permite repetir un bloque de código un número determinado de veces.";
            // 
            // lblTituloTema
            // 
            lblTituloTema.AutoSize = true;
            lblTituloTema.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloTema.ForeColor = Color.White;
            lblTituloTema.Location = new Point(28, 18);
            lblTituloTema.Name = "lblTituloTema";
            lblTituloTema.Size = new Size(127, 37);
            lblTituloTema.TabIndex = 0;
            lblTituloTema.Text = "Ciclo For";
            // 
            // panelDerecho
            // 
            panelDerecho.BackColor = Color.FromArgb(8, 22, 56);
            panelDerecho.Controls.Add(lblQuePasa);
            panelDerecho.Controls.Add(lblExplicacionCodigo);
            panelDerecho.Controls.Add(btnLimpiar);
            panelDerecho.Controls.Add(btnEjecutar);
            panelDerecho.Controls.Add(lblSalida);
            panelDerecho.Controls.Add(txtSalida);
            panelDerecho.Controls.Add(lblCodigo);
            panelDerecho.Controls.Add(txtCodigo);
            panelDerecho.Location = new Point(630, 165);
            panelDerecho.Name = "panelDerecho";
            panelDerecho.Size = new Size(600, 520);
            panelDerecho.TabIndex = 2;
            // 
            // lblQuePasa
            // 
            lblQuePasa.AutoSize = true;
            lblQuePasa.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuePasa.ForeColor = Color.White;
            lblQuePasa.Location = new Point(28, 420);
            lblQuePasa.Name = "lblQuePasa";
            lblQuePasa.Size = new Size(192, 25);
            lblQuePasa.TabIndex = 7;
            lblQuePasa.Text = "¿Qué está pasando?";
            // 
            // lblExplicacionCodigo
            // 
            lblExplicacionCodigo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblExplicacionCodigo.ForeColor = Color.Gainsboro;
            lblExplicacionCodigo.Location = new Point(28, 450);
            lblExplicacionCodigo.Name = "lblExplicacionCodigo";
            lblExplicacionCodigo.Size = new Size(545, 55);
            lblExplicacionCodigo.TabIndex = 6;
            lblExplicacionCodigo.Text = "El ciclo comienza en i = 1. Mientras i sea menor o igual a 5, imprime su valor y luego aumenta en 1.";
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(132, 78, 255);
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(365, 218);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(95, 34);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEjecutar
            // 
            btnEjecutar.BackColor = Color.FromArgb(132, 78, 255);
            btnEjecutar.FlatStyle = FlatStyle.Flat;
            btnEjecutar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEjecutar.ForeColor = Color.White;
            btnEjecutar.Location = new Point(475, 218);
            btnEjecutar.Name = "btnEjecutar";
            btnEjecutar.Size = new Size(98, 34);
            btnEjecutar.TabIndex = 4;
            btnEjecutar.Text = "Ejecutar";
            btnEjecutar.UseVisualStyleBackColor = false;
            btnEjecutar.Click += btnEjecutar_Click;
            // 
            // lblSalida
            // 
            lblSalida.AutoSize = true;
            lblSalida.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSalida.ForeColor = Color.White;
            lblSalida.Location = new Point(28, 222);
            lblSalida.Name = "lblSalida";
            lblSalida.Size = new Size(164, 25);
            lblSalida.TabIndex = 3;
            lblSalida.Text = "Salida en consola";
            // 
            // txtSalida
            // 
            txtSalida.BackColor = Color.FromArgb(6, 16, 41);
            txtSalida.BorderStyle = BorderStyle.FixedSingle;
            txtSalida.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSalida.ForeColor = Color.Lime;
            txtSalida.Location = new Point(28, 260);
            txtSalida.Name = "txtSalida";
            txtSalida.ReadOnly = true;
            txtSalida.Size = new Size(545, 145);
            txtSalida.TabIndex = 2;
            txtSalida.Text = "";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCodigo.ForeColor = Color.White;
            lblCodigo.Location = new Point(28, 18);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(190, 28);
            lblCodigo.TabIndex = 1;
            lblCodigo.Text = "Ejemplo interactivo";
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = Color.FromArgb(6, 16, 41);
            txtCodigo.BorderStyle = BorderStyle.FixedSingle;
            txtCodigo.Font = new Font("Consolas", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCodigo.ForeColor = Color.White;
            txtCodigo.Location = new Point(28, 58);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.ReadOnly = true;
            txtCodigo.Size = new Size(545, 145);
            txtCodigo.TabIndex = 0;
            txtCodigo.Text = "int i;\n\nfor (i = 1; i <= 5; i++)\n{\n    Console.WriteLine(i);\n}";
            // 
            // panelInferior
            // 
            panelInferior.BackColor = Color.FromArgb(8, 22, 56);
            panelInferior.Controls.Add(btnAnterior);
            panelInferior.Controls.Add(btnSiguiente);
            panelInferior.Controls.Add(btnPracticar);
            panelInferior.Location = new Point(30, 705);
            panelInferior.Name = "panelInferior";
            panelInferior.Size = new Size(1200, 85);
            panelInferior.TabIndex = 3;
            // 
            // btnAnterior
            // 
            btnAnterior.BackColor = Color.FromArgb(10, 25, 65);
            btnAnterior.FlatStyle = FlatStyle.Flat;
            btnAnterior.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAnterior.ForeColor = Color.White;
            btnAnterior.Location = new Point(170, 18);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(180, 50);
            btnAnterior.TabIndex = 0;
            btnAnterior.Text = "← Anterior\r\nCiclo While";
            btnAnterior.UseVisualStyleBackColor = false;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.BackColor = Color.FromArgb(132, 78, 255);
            btnSiguiente.FlatStyle = FlatStyle.Flat;
            btnSiguiente.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSiguiente.ForeColor = Color.White;
            btnSiguiente.Location = new Point(380, 18);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(190, 50);
            btnSiguiente.TabIndex = 1;
            btnSiguiente.Text = "Siguiente →\r\nCiclo Do While";
            btnSiguiente.UseVisualStyleBackColor = false;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // btnPracticar
            // 
            btnPracticar.BackColor = Color.FromArgb(10, 25, 65);
            btnPracticar.FlatStyle = FlatStyle.Flat;
            btnPracticar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPracticar.ForeColor = Color.White;
            btnPracticar.Location = new Point(950, 18);
            btnPracticar.Name = "btnPracticar";
            btnPracticar.Size = new Size(220, 50);
            btnPracticar.TabIndex = 2;
            btnPracticar.Text = "🎮 Practicar lo aprendido";
            btnPracticar.UseVisualStyleBackColor = false;
            btnPracticar.Click += btnPracticar_Click;
            // 
            // CicloFor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(6, 16, 41);
            ClientSize = new Size(1270, 820);
            Controls.Add(panelInferior);
            Controls.Add(panelDerecho);
            Controls.Add(panelIzquierdo);
            Controls.Add(panelTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CicloFor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ciclo For";
            panelTitulo.ResumeLayout(false);
            panelTitulo.PerformLayout();
            panelIzquierdo.ResumeLayout(false);
            panelIzquierdo.PerformLayout();
            panelDerecho.ResumeLayout(false);
            panelDerecho.PerformLayout();
            panelInferior.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTitulo;
        private Label lblSubtitulo;
        private Label lblTituloAzul;
        private Label lblTitulo;
        private Panel panelIzquierdo;
        private Label lblImportante;
        private Label lblExplicacion;
        private Label lblSintaxis;
        private RichTextBox txtSintaxis;
        private Label lblDescripcionTema;
        private Label lblTituloTema;
        private Panel panelDerecho;
        private Label lblQuePasa;
        private Label lblExplicacionCodigo;
        private Button btnLimpiar;
        private Button btnEjecutar;
        private Label lblSalida;
        private RichTextBox txtSalida;
        private Label lblCodigo;
        private RichTextBox txtCodigo;
        private Panel panelInferior;
        private Button btnAnterior;
        private Button btnSiguiente;
        private Button btnPracticar;
    }
}
