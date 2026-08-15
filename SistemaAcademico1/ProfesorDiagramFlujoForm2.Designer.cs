using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace SistemaAcademico1
{
    partial class ProfesorDiagramFlujoForm2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfesorDiagramFlujoForm2));
            lblSigcha1 = new Label();
            textTeoria = new TextBox();
            bGuardarTeoria = new Button();
            btnRegresarMenu = new Button();
            panelAtajos = new Panel();
            btnConectorFuera = new Button();
            btnConectorEnPagina = new Button();
            btnTeclado = new Button();
            btnEntrada = new Button();
            btnConcepto = new Button();
            btnLinea = new Button();
            btnPantalla = new Button();
            btnImpresora = new Button();
            btnEntredaSalida = new Button();
            btnDecision = new Button();
            btnProceso = new Button();
            btnInicio = new Button();
            picSimbolo = new PictureBox();
            btnSubirImagen = new Button();
            panelAtajos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picSimbolo).BeginInit();
            SuspendLayout();
            // 
            // lblSigcha1
            // 
            lblSigcha1.AutoSize = true;
            lblSigcha1.Font = new System.Drawing.Font("Segoe UI Black", 18F, FontStyle.Bold);
            lblSigcha1.ForeColor = Color.FromArgb(182, 102, 255);
            lblSigcha1.Location = new Point(181, 24);
            lblSigcha1.Name = "lblSigcha1";
            lblSigcha1.Size = new Size(566, 41);
            lblSigcha1.TabIndex = 0;
            lblSigcha1.Text = "Sección docente - Diagramas de Flujo";
            // 
            // textTeoria
            // 
            textTeoria.BackColor = Color.FromArgb(13, 35, 79);
            textTeoria.BorderStyle = BorderStyle.FixedSingle;
            textTeoria.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            textTeoria.ForeColor = Color.White;
            textTeoria.Location = new Point(354, 130);
            textTeoria.Margin = new Padding(3, 2, 3, 2);
            textTeoria.Multiline = true;
            textTeoria.Name = "textTeoria";
            textTeoria.Size = new Size(600, 350);
            textTeoria.TabIndex = 1;
            textTeoria.TextChanged += textTeoria_TextChanged;
            // 
            // bGuardarTeoria
            // 
            bGuardarTeoria.BackColor = Color.FromArgb(17, 18, 34);
            bGuardarTeoria.FlatAppearance.BorderColor = Color.Magenta;
            bGuardarTeoria.FlatStyle = FlatStyle.Flat;
            bGuardarTeoria.Font = new System.Drawing.Font("Segoe UI Black", 12F, FontStyle.Bold);
            bGuardarTeoria.ForeColor = Color.Magenta;
            bGuardarTeoria.Location = new Point(506, 604);
            bGuardarTeoria.Margin = new Padding(3, 2, 3, 2);
            bGuardarTeoria.Name = "bGuardarTeoria";
            bGuardarTeoria.Size = new Size(290, 89);
            bGuardarTeoria.TabIndex = 2;
            bGuardarTeoria.Text = "✅ Guardar y Publicar";
            bGuardarTeoria.UseVisualStyleBackColor = false;
            bGuardarTeoria.Click += bGuardarTeoria_Click_1;
            // 
            // btnRegresarMenu
            // 
            btnRegresarMenu.BackColor = Color.FromArgb(17, 18, 34);
            btnRegresarMenu.FlatAppearance.BorderColor = Color.Magenta;
            btnRegresarMenu.FlatStyle = FlatStyle.Flat;
            btnRegresarMenu.Font = new System.Drawing.Font("Segoe UI Black", 12F, FontStyle.Bold);
            btnRegresarMenu.ForeColor = Color.Magenta;
            btnRegresarMenu.Location = new Point(912, 604);
            btnRegresarMenu.Margin = new Padding(3, 2, 3, 2);
            btnRegresarMenu.Name = "btnRegresarMenu";
            btnRegresarMenu.Size = new Size(290, 88);
            btnRegresarMenu.TabIndex = 3;
            btnRegresarMenu.Text = "⬅️ Regresar";
            btnRegresarMenu.UseVisualStyleBackColor = false;
            btnRegresarMenu.Click += btnRegresarMenu_Click_1;
            // 
            // panelAtajos
            // 
            panelAtajos.AutoScroll = true;
            panelAtajos.BackColor = Color.FromArgb(15, 23, 42);
            panelAtajos.BorderStyle = BorderStyle.FixedSingle;
            panelAtajos.Controls.Add(btnConectorFuera);
            panelAtajos.Controls.Add(btnConectorEnPagina);
            panelAtajos.Controls.Add(btnTeclado);
            panelAtajos.Controls.Add(btnEntrada);
            panelAtajos.Controls.Add(btnConcepto);
            panelAtajos.Controls.Add(btnLinea);
            panelAtajos.Controls.Add(btnPantalla);
            panelAtajos.Controls.Add(btnImpresora);
            panelAtajos.Controls.Add(btnEntredaSalida);
            panelAtajos.Controls.Add(btnDecision);
            panelAtajos.Controls.Add(btnProceso);
            panelAtajos.Controls.Add(btnInicio);
            panelAtajos.Location = new Point(26, 130);
            panelAtajos.Margin = new Padding(3, 2, 3, 2);
            panelAtajos.Name = "panelAtajos";
            panelAtajos.Size = new Size(280, 520);
            panelAtajos.TabIndex = 4;
            // 
            // btnConectorFuera
            // 
            btnConectorFuera.BackColor = Color.FromArgb(15, 13, 12);
            btnConectorFuera.FlatStyle = FlatStyle.Flat;
            btnConectorFuera.Font = new System.Drawing.Font("Segoe UI Black", 9F, FontStyle.Bold);
            btnConectorFuera.ForeColor = Color.White;
            btnConectorFuera.Location = new Point(30, 705);
            btnConectorFuera.Margin = new Padding(3, 2, 3, 2);
            btnConectorFuera.Name = "btnConectorFuera";
            btnConectorFuera.Size = new Size(196, 44);
            btnConectorFuera.TabIndex = 7;
            btnConectorFuera.Text = "[CONECTOR 🔻]";
            btnConectorFuera.UseVisualStyleBackColor = false;
            btnConectorFuera.Click += btnConectorFuera_Click;
            // 
            // btnConectorEnPagina
            // 
            btnConectorEnPagina.BackColor = Color.FromArgb(15, 13, 12);
            btnConectorEnPagina.FlatStyle = FlatStyle.Flat;
            btnConectorEnPagina.Font = new System.Drawing.Font("Segoe UI Black", 9F, FontStyle.Bold);
            btnConectorEnPagina.ForeColor = Color.White;
            btnConectorEnPagina.Location = new Point(30, 642);
            btnConectorEnPagina.Margin = new Padding(3, 2, 3, 2);
            btnConectorEnPagina.Name = "btnConectorEnPagina";
            btnConectorEnPagina.Size = new Size(196, 45);
            btnConectorEnPagina.TabIndex = 7;
            btnConectorEnPagina.Text = "[CONECTOR 🔘]";
            btnConectorEnPagina.UseVisualStyleBackColor = false;
            btnConectorEnPagina.Click += btnConectorEnPagina_Click;
            // 
            // btnTeclado
            // 
            btnTeclado.BackColor = Color.FromArgb(15, 13, 12);
            btnTeclado.FlatStyle = FlatStyle.Flat;
            btnTeclado.Font = new System.Drawing.Font("Segoe UI Black", 9F, FontStyle.Bold);
            btnTeclado.ForeColor = Color.White;
            btnTeclado.Location = new Point(30, 578);
            btnTeclado.Margin = new Padding(3, 2, 3, 2);
            btnTeclado.Name = "btnTeclado";
            btnTeclado.Size = new Size(196, 45);
            btnTeclado.TabIndex = 7;
            btnTeclado.Text = "[TECLADO]";
            btnTeclado.UseVisualStyleBackColor = false;
            btnTeclado.Click += btnTeclado_Click;
            // 
            // btnEntrada
            // 
            btnEntrada.BackColor = Color.FromArgb(15, 13, 12);
            btnEntrada.FlatStyle = FlatStyle.Flat;
            btnEntrada.Font = new System.Drawing.Font("Segoe UI Black", 9F, FontStyle.Bold);
            btnEntrada.ForeColor = Color.White;
            btnEntrada.Location = new Point(30, 515);
            btnEntrada.Margin = new Padding(3, 2, 3, 2);
            btnEntrada.Name = "btnEntrada";
            btnEntrada.Size = new Size(196, 45);
            btnEntrada.TabIndex = 7;
            btnEntrada.Text = "[ENTRADA]";
            btnEntrada.UseVisualStyleBackColor = false;
            btnEntrada.Click += btnEntrada_Click;
            // 
            // btnConcepto
            // 
            btnConcepto.BackColor = Color.FromArgb(15, 13, 12);
            btnConcepto.FlatStyle = FlatStyle.Flat;
            btnConcepto.Font = new System.Drawing.Font("Segoe UI Black", 9F, FontStyle.Bold);
            btnConcepto.ForeColor = Color.White;
            btnConcepto.Location = new Point(30, 19);
            btnConcepto.Margin = new Padding(3, 2, 3, 2);
            btnConcepto.Name = "btnConcepto";
            btnConcepto.Size = new Size(196, 45);
            btnConcepto.TabIndex = 7;
            btnConcepto.Text = "[CONCEPTO]";
            btnConcepto.UseVisualStyleBackColor = false;
            btnConcepto.Click += btnConcepto_Click_1;
            // 
            // btnLinea
            // 
            btnLinea.BackColor = Color.FromArgb(15, 13, 12);
            btnLinea.FlatStyle = FlatStyle.Flat;
            btnLinea.Font = new System.Drawing.Font("Segoe UI Black", 9F, FontStyle.Bold);
            btnLinea.ForeColor = Color.White;
            btnLinea.Location = new Point(30, 142);
            btnLinea.Margin = new Padding(3, 2, 3, 2);
            btnLinea.Name = "btnLinea";
            btnLinea.Size = new Size(196, 45);
            btnLinea.TabIndex = 7;
            btnLinea.Text = "[LINEA DE FLUJO]";
            btnLinea.UseVisualStyleBackColor = false;
            btnLinea.Click += btnLinea_Click;
            // 
            // btnPantalla
            // 
            btnPantalla.BackColor = Color.FromArgb(15, 13, 12);
            btnPantalla.FlatStyle = FlatStyle.Flat;
            btnPantalla.Font = new System.Drawing.Font("Segoe UI Black", 9F, FontStyle.Bold);
            btnPantalla.ForeColor = Color.White;
            btnPantalla.Location = new Point(30, 454);
            btnPantalla.Margin = new Padding(3, 2, 3, 2);
            btnPantalla.Name = "btnPantalla";
            btnPantalla.Size = new Size(196, 45);
            btnPantalla.TabIndex = 7;
            btnPantalla.Text = "[PANTALLA]";
            btnPantalla.UseVisualStyleBackColor = false;
            btnPantalla.Click += btnPantalla_Click;
            // 
            // btnImpresora
            // 
            btnImpresora.BackColor = Color.FromArgb(15, 13, 12);
            btnImpresora.FlatStyle = FlatStyle.Flat;
            btnImpresora.Font = new System.Drawing.Font("Segoe UI Black", 9F, FontStyle.Bold);
            btnImpresora.ForeColor = Color.White;
            btnImpresora.Location = new Point(30, 392);
            btnImpresora.Margin = new Padding(3, 2, 3, 2);
            btnImpresora.Name = "btnImpresora";
            btnImpresora.Size = new Size(196, 45);
            btnImpresora.TabIndex = 7;
            btnImpresora.Text = "[IMPRESORA]";
            btnImpresora.UseVisualStyleBackColor = false;
            btnImpresora.Click += btnImpresora_Click;
            // 
            // btnEntredaSalida
            // 
            btnEntredaSalida.BackColor = Color.FromArgb(15, 13, 12);
            btnEntredaSalida.FlatStyle = FlatStyle.Flat;
            btnEntredaSalida.Font = new System.Drawing.Font("Segoe UI Black", 9F, FontStyle.Bold);
            btnEntredaSalida.ForeColor = Color.White;
            btnEntredaSalida.Location = new Point(30, 268);
            btnEntredaSalida.Margin = new Padding(3, 2, 3, 2);
            btnEntredaSalida.Name = "btnEntredaSalida";
            btnEntredaSalida.Size = new Size(196, 45);
            btnEntredaSalida.TabIndex = 7;
            btnEntredaSalida.Text = "[ENTRADA/SALIDA]";
            btnEntredaSalida.UseVisualStyleBackColor = false;
            btnEntredaSalida.Click += btnEntredaSalida_Click;
            // 
            // btnDecision
            // 
            btnDecision.BackColor = Color.FromArgb(15, 13, 12);
            btnDecision.FlatStyle = FlatStyle.Flat;
            btnDecision.Font = new System.Drawing.Font("Segoe UI Black", 9F, FontStyle.Bold);
            btnDecision.ForeColor = Color.White;
            btnDecision.Location = new Point(30, 330);
            btnDecision.Margin = new Padding(3, 2, 3, 2);
            btnDecision.Name = "btnDecision";
            btnDecision.Size = new Size(196, 45);
            btnDecision.TabIndex = 7;
            btnDecision.Text = "[DECISIÓN]";
            btnDecision.UseVisualStyleBackColor = false;
            btnDecision.Click += btnDecision_Click;
            // 
            // btnProceso
            // 
            btnProceso.BackColor = Color.FromArgb(15, 13, 12);
            btnProceso.FlatStyle = FlatStyle.Flat;
            btnProceso.Font = new System.Drawing.Font("Segoe UI Black", 9F, FontStyle.Bold);
            btnProceso.ForeColor = Color.White;
            btnProceso.Location = new Point(30, 205);
            btnProceso.Margin = new Padding(3, 2, 3, 2);
            btnProceso.Name = "btnProceso";
            btnProceso.Size = new Size(196, 45);
            btnProceso.TabIndex = 7;
            btnProceso.Text = "[PROCESO]";
            btnProceso.UseVisualStyleBackColor = false;
            btnProceso.Click += btnProceso_Click;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.FromArgb(15, 13, 12);
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new System.Drawing.Font("Segoe UI Black", 9F, FontStyle.Bold);
            btnInicio.ForeColor = Color.White;
            btnInicio.Location = new Point(30, 80);
            btnInicio.Margin = new Padding(3, 2, 3, 2);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(196, 45);
            btnInicio.TabIndex = 7;
            btnInicio.Text = "[INICIO / FIN]";
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += btnInicio_Click_1;
            // 
            // picSimbolo
            // 
            picSimbolo.BackColor = Color.FromArgb(13, 35, 79);
            picSimbolo.BorderStyle = BorderStyle.FixedSingle;
            picSimbolo.Cursor = Cursors.No;
            picSimbolo.Image = (System.Drawing.Image)resources.GetObject("picSimbolo.Image");
            picSimbolo.Location = new Point(975, 130);
            picSimbolo.Margin = new Padding(3, 2, 3, 2);
            picSimbolo.Name = "picSimbolo";
            picSimbolo.Size = new Size(265, 277);
            picSimbolo.SizeMode = PictureBoxSizeMode.Zoom;
            picSimbolo.TabIndex = 5;
            picSimbolo.TabStop = false;
            // 
            // btnSubirImagen
            // 
            btnSubirImagen.BackColor = Color.FromArgb(17, 18, 34);
            btnSubirImagen.FlatStyle = FlatStyle.Flat;
            btnSubirImagen.Font = new System.Drawing.Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnSubirImagen.ForeColor = Color.Magenta;
            btnSubirImagen.Location = new Point(1021, 426);
            btnSubirImagen.Margin = new Padding(3, 2, 3, 2);
            btnSubirImagen.Name = "btnSubirImagen";
            btnSubirImagen.Size = new Size(181, 54);
            btnSubirImagen.TabIndex = 6;
            btnSubirImagen.Text = "Subir Ejemplo 🖼️";
            btnSubirImagen.UseVisualStyleBackColor = false;
            btnSubirImagen.Click += btnSubirImagen_Click_1;
            // 
            // ProfesorDiagramFlujoForm2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(6, 16, 41);
            ClientSize = new Size(1262, 752);
            Controls.Add(btnSubirImagen);
            Controls.Add(picSimbolo);
            Controls.Add(panelAtajos);
            Controls.Add(btnRegresarMenu);
            Controls.Add(bGuardarTeoria);
            Controls.Add(textTeoria);
            Controls.Add(lblSigcha1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ProfesorDiagramFlujoForm2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProfesorDiagramFlujoForm2";
            panelAtajos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picSimbolo).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Label lblSigcha1;
        private TextBox textTeoria;
        private Button bGuardarTeoria;
        private Button btnRegresarMenu;
        private Panel panelAtajos;
        private PictureBox picSimbolo;
        private Button btnSubirImagen;
        private Button btnEntredaSalida;
        private Button btnDecision;
        private Button btnProceso;
        private Button btnInicio;
        private Button btnImpresora;
        private Button btnLinea;
        private Button btnConcepto;
        private Button btnTeclado;
        private Button btnEntrada;
        private Button btnConectorEnPagina;
        private Button btnConectorFuera;
        private Button btnPantalla;
    }
}
