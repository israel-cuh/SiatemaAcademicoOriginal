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
            this.lblSigcha1 = new System.Windows.Forms.Label();
            this.textTeoria = new System.Windows.Forms.TextBox();
            this.bGuardarTeoria = new System.Windows.Forms.Button();
            this.btnRegresarMenu = new System.Windows.Forms.Button();
            this.panelAtajos = new System.Windows.Forms.Panel();
            this.btnConectorFuera = new System.Windows.Forms.Button();
            this.btnConectorEnPagina = new System.Windows.Forms.Button();
            this.btnTeclado = new System.Windows.Forms.Button();
            this.btnEntrada = new System.Windows.Forms.Button();
            this.btnConcepto = new System.Windows.Forms.Button();
            this.btnLinea = new System.Windows.Forms.Button();
            this.btnPantalla = new System.Windows.Forms.Button();
            this.btnImpresora = new System.Windows.Forms.Button();
            this.btnEntredaSalida = new System.Windows.Forms.Button();
            this.btnDecision = new System.Windows.Forms.Button();
            this.btnProceso = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.picSimbolo = new System.Windows.Forms.PictureBox();
            this.btnSubirImagen = new System.Windows.Forms.Button();
            this.panelAtajos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSimbolo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSigcha1
            // 
            this.lblSigcha1.AutoSize = true;
            this.lblSigcha1.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold);
            this.lblSigcha1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.lblSigcha1.Location = new System.Drawing.Point(181, 19);
            this.lblSigcha1.Name = "lblSigcha1";
            this.lblSigcha1.Size = new System.Drawing.Size(566, 41);
            this.lblSigcha1.TabIndex = 0;
            this.lblSigcha1.Text = "Sección docente - Diagramas de Flujo";
            // 
            // textTeoria
            // 
            this.textTeoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.textTeoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textTeoria.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.textTeoria.ForeColor = System.Drawing.Color.White;
            this.textTeoria.Location = new System.Drawing.Point(354, 104);
            this.textTeoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textTeoria.Multiline = true;
            this.textTeoria.Name = "textTeoria";
            this.textTeoria.Size = new System.Drawing.Size(600, 280);
            this.textTeoria.TabIndex = 1;
            this.textTeoria.TextChanged += new System.EventHandler(this.textTeoria_TextChanged);
            // 
            // bGuardarTeoria
            // 
            this.bGuardarTeoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(34)))));
            this.bGuardarTeoria.FlatAppearance.BorderColor = System.Drawing.Color.Magenta;
            this.bGuardarTeoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bGuardarTeoria.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.bGuardarTeoria.ForeColor = System.Drawing.Color.Magenta;
            this.bGuardarTeoria.Location = new System.Drawing.Point(506, 483);
            this.bGuardarTeoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bGuardarTeoria.Name = "bGuardarTeoria";
            this.bGuardarTeoria.Size = new System.Drawing.Size(290, 71);
            this.bGuardarTeoria.TabIndex = 2;
            this.bGuardarTeoria.Text = "✅ Guardar y Publicar";
            this.bGuardarTeoria.UseVisualStyleBackColor = false;
            this.bGuardarTeoria.Click += new System.EventHandler(this.bGuardarTeoria_Click_1);
            // 
            // btnRegresarMenu
            // 
            this.btnRegresarMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(34)))));
            this.btnRegresarMenu.FlatAppearance.BorderColor = System.Drawing.Color.Magenta;
            this.btnRegresarMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresarMenu.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.btnRegresarMenu.ForeColor = System.Drawing.Color.Magenta;
            this.btnRegresarMenu.Location = new System.Drawing.Point(912, 483);
            this.btnRegresarMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegresarMenu.Name = "btnRegresarMenu";
            this.btnRegresarMenu.Size = new System.Drawing.Size(290, 70);
            this.btnRegresarMenu.TabIndex = 3;
            this.btnRegresarMenu.Text = "⬅️ Regresar";
            this.btnRegresarMenu.UseVisualStyleBackColor = false;
            this.btnRegresarMenu.Click += new System.EventHandler(this.btnRegresarMenu_Click_1);
            // 
            // panelAtajos
            // 
            this.panelAtajos.AutoScroll = true;
            this.panelAtajos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.panelAtajos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAtajos.Controls.Add(this.btnConectorFuera);
            this.panelAtajos.Controls.Add(this.btnConectorEnPagina);
            this.panelAtajos.Controls.Add(this.btnTeclado);
            this.panelAtajos.Controls.Add(this.btnEntrada);
            this.panelAtajos.Controls.Add(this.btnConcepto);
            this.panelAtajos.Controls.Add(this.btnLinea);
            this.panelAtajos.Controls.Add(this.btnPantalla);
            this.panelAtajos.Controls.Add(this.btnImpresora);
            this.panelAtajos.Controls.Add(this.btnEntredaSalida);
            this.panelAtajos.Controls.Add(this.btnDecision);
            this.panelAtajos.Controls.Add(this.btnProceso);
            this.panelAtajos.Controls.Add(this.btnInicio);
            this.panelAtajos.Location = new System.Drawing.Point(26, 104);
            this.panelAtajos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelAtajos.Name = "panelAtajos";
            this.panelAtajos.Size = new System.Drawing.Size(280, 416);
            this.panelAtajos.TabIndex = 4;
            // 
            // btnConectorFuera
            // 
            this.btnConectorFuera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(13)))), ((int)(((byte)(12)))));
            this.btnConectorFuera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConectorFuera.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.btnConectorFuera.ForeColor = System.Drawing.Color.White;
            this.btnConectorFuera.Location = new System.Drawing.Point(30, 564);
            this.btnConectorFuera.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConectorFuera.Name = "btnConectorFuera";
            this.btnConectorFuera.Size = new System.Drawing.Size(196, 35);
            this.btnConectorFuera.TabIndex = 7;
            this.btnConectorFuera.Text = "[CONECTOR 🔻]";
            this.btnConectorFuera.UseVisualStyleBackColor = false;
            this.btnConectorFuera.Click += new System.EventHandler(this.btnConectorFuera_Click);
            // 
            // btnConectorEnPagina
            // 
            this.btnConectorEnPagina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(13)))), ((int)(((byte)(12)))));
            this.btnConectorEnPagina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConectorEnPagina.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.btnConectorEnPagina.ForeColor = System.Drawing.Color.White;
            this.btnConectorEnPagina.Location = new System.Drawing.Point(30, 514);
            this.btnConectorEnPagina.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConectorEnPagina.Name = "btnConectorEnPagina";
            this.btnConectorEnPagina.Size = new System.Drawing.Size(196, 36);
            this.btnConectorEnPagina.TabIndex = 7;
            this.btnConectorEnPagina.Text = "[CONECTOR 🔘]";
            this.btnConectorEnPagina.UseVisualStyleBackColor = false;
            this.btnConectorEnPagina.Click += new System.EventHandler(this.btnConectorEnPagina_Click);
            // 
            // btnTeclado
            // 
            this.btnTeclado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(13)))), ((int)(((byte)(12)))));
            this.btnTeclado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeclado.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.btnTeclado.ForeColor = System.Drawing.Color.White;
            this.btnTeclado.Location = new System.Drawing.Point(30, 462);
            this.btnTeclado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTeclado.Name = "btnTeclado";
            this.btnTeclado.Size = new System.Drawing.Size(196, 36);
            this.btnTeclado.TabIndex = 7;
            this.btnTeclado.Text = "[TECLADO]";
            this.btnTeclado.UseVisualStyleBackColor = false;
            this.btnTeclado.Click += new System.EventHandler(this.btnTeclado_Click);
            // 
            // btnEntrada
            // 
            this.btnEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(13)))), ((int)(((byte)(12)))));
            this.btnEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrada.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.btnEntrada.ForeColor = System.Drawing.Color.White;
            this.btnEntrada.Location = new System.Drawing.Point(30, 412);
            this.btnEntrada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Size = new System.Drawing.Size(196, 36);
            this.btnEntrada.TabIndex = 7;
            this.btnEntrada.Text = "[ENTRADA]";
            this.btnEntrada.UseVisualStyleBackColor = false;
            this.btnEntrada.Click += new System.EventHandler(this.btnEntrada_Click);
            // 
            // btnConcepto
            // 
            this.btnConcepto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(13)))), ((int)(((byte)(12)))));
            this.btnConcepto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConcepto.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.btnConcepto.ForeColor = System.Drawing.Color.White;
            this.btnConcepto.Location = new System.Drawing.Point(30, 15);
            this.btnConcepto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConcepto.Name = "btnConcepto";
            this.btnConcepto.Size = new System.Drawing.Size(196, 36);
            this.btnConcepto.TabIndex = 7;
            this.btnConcepto.Text = "[CONCEPTO]";
            this.btnConcepto.UseVisualStyleBackColor = false;
            this.btnConcepto.Click += new System.EventHandler(this.btnConcepto_Click_1);
            // 
            // btnLinea
            // 
            this.btnLinea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(13)))), ((int)(((byte)(12)))));
            this.btnLinea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLinea.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.btnLinea.ForeColor = System.Drawing.Color.White;
            this.btnLinea.Location = new System.Drawing.Point(30, 114);
            this.btnLinea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLinea.Name = "btnLinea";
            this.btnLinea.Size = new System.Drawing.Size(196, 36);
            this.btnLinea.TabIndex = 7;
            this.btnLinea.Text = "[LINEA DE FLUJO]";
            this.btnLinea.UseVisualStyleBackColor = false;
            this.btnLinea.Click += new System.EventHandler(this.btnLinea_Click);
            // 
            // btnPantalla
            // 
            this.btnPantalla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(13)))), ((int)(((byte)(12)))));
            this.btnPantalla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPantalla.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.btnPantalla.ForeColor = System.Drawing.Color.White;
            this.btnPantalla.Location = new System.Drawing.Point(30, 363);
            this.btnPantalla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPantalla.Name = "btnPantalla";
            this.btnPantalla.Size = new System.Drawing.Size(196, 36);
            this.btnPantalla.TabIndex = 7;
            this.btnPantalla.Text = "[PANTALLA]";
            this.btnPantalla.UseVisualStyleBackColor = false;
            this.btnPantalla.Click += new System.EventHandler(this.btnPantalla_Click);
            // 
            // btnImpresora
            // 
            this.btnImpresora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(13)))), ((int)(((byte)(12)))));
            this.btnImpresora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImpresora.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.btnImpresora.ForeColor = System.Drawing.Color.White;
            this.btnImpresora.Location = new System.Drawing.Point(30, 314);
            this.btnImpresora.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnImpresora.Name = "btnImpresora";
            this.btnImpresora.Size = new System.Drawing.Size(196, 36);
            this.btnImpresora.TabIndex = 7;
            this.btnImpresora.Text = "[IMPRESORA]";
            this.btnImpresora.UseVisualStyleBackColor = false;
            this.btnImpresora.Click += new System.EventHandler(this.btnImpresora_Click);
            // 
            // btnEntredaSalida
            // 
            this.btnEntredaSalida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(13)))), ((int)(((byte)(12)))));
            this.btnEntredaSalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntredaSalida.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.btnEntredaSalida.ForeColor = System.Drawing.Color.White;
            this.btnEntredaSalida.Location = new System.Drawing.Point(30, 214);
            this.btnEntredaSalida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEntredaSalida.Name = "btnEntredaSalida";
            this.btnEntredaSalida.Size = new System.Drawing.Size(196, 36);
            this.btnEntredaSalida.TabIndex = 7;
            this.btnEntredaSalida.Text = "[ENTRADA/SALIDA]";
            this.btnEntredaSalida.UseVisualStyleBackColor = false;
            this.btnEntredaSalida.Click += new System.EventHandler(this.btnEntredaSalida_Click);
            // 
            // btnDecision
            // 
            this.btnDecision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(13)))), ((int)(((byte)(12)))));
            this.btnDecision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecision.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.btnDecision.ForeColor = System.Drawing.Color.White;
            this.btnDecision.Location = new System.Drawing.Point(30, 264);
            this.btnDecision.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDecision.Name = "btnDecision";
            this.btnDecision.Size = new System.Drawing.Size(196, 36);
            this.btnDecision.TabIndex = 7;
            this.btnDecision.Text = "[DECISIÓN]";
            this.btnDecision.UseVisualStyleBackColor = false;
            this.btnDecision.Click += new System.EventHandler(this.btnDecision_Click);
            // 
            // btnProceso
            // 
            this.btnProceso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(13)))), ((int)(((byte)(12)))));
            this.btnProceso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProceso.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.btnProceso.ForeColor = System.Drawing.Color.White;
            this.btnProceso.Location = new System.Drawing.Point(30, 164);
            this.btnProceso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProceso.Name = "btnProceso";
            this.btnProceso.Size = new System.Drawing.Size(196, 36);
            this.btnProceso.TabIndex = 7;
            this.btnProceso.Text = "[PROCESO]";
            this.btnProceso.UseVisualStyleBackColor = false;
            this.btnProceso.Click += new System.EventHandler(this.btnProceso_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(13)))), ((int)(((byte)(12)))));
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.Location = new System.Drawing.Point(30, 64);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(196, 36);
            this.btnInicio.TabIndex = 7;
            this.btnInicio.Text = "[INICIO / FIN]";
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click_1);
            // 
            // picSimbolo
            // 
            this.picSimbolo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.picSimbolo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSimbolo.Cursor = System.Windows.Forms.Cursors.No;
            this.picSimbolo.Image = ((System.Drawing.Image)(resources.GetObject("picSimbolo.Image")));
            this.picSimbolo.Location = new System.Drawing.Point(975, 104);
            this.picSimbolo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picSimbolo.Name = "picSimbolo";
            this.picSimbolo.Size = new System.Drawing.Size(265, 222);
            this.picSimbolo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSimbolo.TabIndex = 5;
            this.picSimbolo.TabStop = false;
            // 
            // btnSubirImagen
            // 
            this.btnSubirImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(34)))));
            this.btnSubirImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubirImagen.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnSubirImagen.ForeColor = System.Drawing.Color.Magenta;
            this.btnSubirImagen.Location = new System.Drawing.Point(1021, 341);
            this.btnSubirImagen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubirImagen.Name = "btnSubirImagen";
            this.btnSubirImagen.Size = new System.Drawing.Size(181, 43);
            this.btnSubirImagen.TabIndex = 6;
            this.btnSubirImagen.Text = "Subir Ejemplo 🖼️";
            this.btnSubirImagen.UseVisualStyleBackColor = false;
            this.btnSubirImagen.Click += new System.EventHandler(this.btnSubirImagen_Click_1);
            // 
            // ProfesorDiagramFlujoForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(16)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1262, 602);
            this.Controls.Add(this.btnSubirImagen);
            this.Controls.Add(this.picSimbolo);
            this.Controls.Add(this.panelAtajos);
            this.Controls.Add(this.btnRegresarMenu);
            this.Controls.Add(this.bGuardarTeoria);
            this.Controls.Add(this.textTeoria);
            this.Controls.Add(this.lblSigcha1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ProfesorDiagramFlujoForm2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProfesorDiagramFlujoForm2";
            this.panelAtajos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSimbolo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
