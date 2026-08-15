using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaAcademico1
{
    partial class VisorTareasEstudianteDesign
    {
        private System.ComponentModel.IContainer components = null;
        private Panel panelHeader;
        private Panel panelSearch;
        private Panel panelLeft;
        private TabControl tabControlMain;
        private Panel panelBottom;
        private Label lblTitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // VisorTareasEstudianteDesign
            // 
            this.ClientSize = new System.Drawing.Size(1560, 850);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(12, 83, 175);
            this.Name = "VisorTareasEstudianteDesign";

            // 
            // panelHeader
            // 
            this.panelHeader.Dock = DockStyle.Top;
            this.panelHeader.Height = 70;
            this.panelHeader.BackColor = Color.FromArgb(10, 70, 150);
            this.panelHeader.Padding = new Padding(10);
            // Title label
            this.lblTitle.Text = "Mis Tareas - Estudiante";
            this.lblTitle.ForeColor = Color.White;
            this.lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            this.lblTitle.Dock = DockStyle.Fill;
            this.lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            this.panelHeader.Controls.Add(this.lblTitle);

            // 
            // panelSearch
            // 
            this.panelSearch.Dock = DockStyle.Top;
            this.panelSearch.Height = 80;
            this.panelSearch.BackColor = Color.FromArgb(230, 243, 255);
            this.panelSearch.Padding = new Padding(12);

            // 
            // panelLeft
            // 
            this.panelLeft.Dock = DockStyle.Left;
            this.panelLeft.Width = 260;
            this.panelLeft.BackColor = Color.FromArgb(9, 57, 120);

            // 
            // tabControlMain
            // 
            this.tabControlMain.Dock = DockStyle.Fill;
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.Font = new Font("Segoe UI", 10F);

            // 
            // panelBottom
            // 
            this.panelBottom.Dock = DockStyle.Bottom;
            this.panelBottom.Height = 200;
            this.panelBottom.BackColor = Color.FromArgb(230, 243, 255);

            // Add controls to form
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelLeft);

            this.ResumeLayout(false);
        }
    }
}
