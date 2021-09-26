namespace Persona1.Vistas
{
    partial class MenuAplicacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivpoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formularioEstudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formularioProfesorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivpoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(509, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivpoToolStripMenuItem
            // 
            this.archivpoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formularioEstudianteToolStripMenuItem,
            this.formularioProfesorToolStripMenuItem1});
            this.archivpoToolStripMenuItem.Name = "archivpoToolStripMenuItem";
            this.archivpoToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.archivpoToolStripMenuItem.Text = "Archivpo";
            // 
            // formularioEstudianteToolStripMenuItem
            // 
            this.formularioEstudianteToolStripMenuItem.Name = "formularioEstudianteToolStripMenuItem";
            this.formularioEstudianteToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.formularioEstudianteToolStripMenuItem.Text = "FormularioEstudiante";
            this.formularioEstudianteToolStripMenuItem.Click += new System.EventHandler(this.formularioEstudianteToolStripMenuItem_Click);
            // 
            // formularioProfesorToolStripMenuItem1
            // 
            this.formularioProfesorToolStripMenuItem1.Name = "formularioProfesorToolStripMenuItem1";
            this.formularioProfesorToolStripMenuItem1.Size = new System.Drawing.Size(187, 22);
            this.formularioProfesorToolStripMenuItem1.Text = "FormularioProfesor";
            // 
            // MenuAplicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 297);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuAplicacion";
            this.Text = "MenuAplicacion";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivpoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formularioEstudianteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formularioProfesorToolStripMenuItem1;
    }
}