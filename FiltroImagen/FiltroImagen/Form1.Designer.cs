
namespace FiltroImagen
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirImagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarImagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtrosBasicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negativoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtroDeColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tonosDeGrisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colonizarGradianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brilloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.filtrosBasicosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1137, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirImagenToolStripMenuItem,
            this.guardarImagenToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirImagenToolStripMenuItem
            // 
            this.abrirImagenToolStripMenuItem.Name = "abrirImagenToolStripMenuItem";
            this.abrirImagenToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.abrirImagenToolStripMenuItem.Text = "Abrir Imagen";
            this.abrirImagenToolStripMenuItem.Click += new System.EventHandler(this.abrirImagenToolStripMenuItem_Click);
            // 
            // guardarImagenToolStripMenuItem
            // 
            this.guardarImagenToolStripMenuItem.Name = "guardarImagenToolStripMenuItem";
            this.guardarImagenToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.guardarImagenToolStripMenuItem.Text = "Guardar Imagen";
            this.guardarImagenToolStripMenuItem.Click += new System.EventHandler(this.guardarImagenToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // filtrosBasicosToolStripMenuItem
            // 
            this.filtrosBasicosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem,
            this.negativoToolStripMenuItem,
            this.filtroDeColorToolStripMenuItem,
            this.toolStripMenuItem2,
            this.tonosDeGrisToolStripMenuItem,
            this.colorizarToolStripMenuItem,
            this.colonizarGradianteToolStripMenuItem,
            this.brilloToolStripMenuItem});
            this.filtrosBasicosToolStripMenuItem.Name = "filtrosBasicosToolStripMenuItem";
            this.filtrosBasicosToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.filtrosBasicosToolStripMenuItem.Text = "FIltros";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.testToolStripMenuItem.Text = "Test";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // negativoToolStripMenuItem
            // 
            this.negativoToolStripMenuItem.Name = "negativoToolStripMenuItem";
            this.negativoToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.negativoToolStripMenuItem.Text = "Negativo";
            this.negativoToolStripMenuItem.Click += new System.EventHandler(this.negativoToolStripMenuItem_Click);
            // 
            // filtroDeColorToolStripMenuItem
            // 
            this.filtroDeColorToolStripMenuItem.Name = "filtroDeColorToolStripMenuItem";
            this.filtroDeColorToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.filtroDeColorToolStripMenuItem.Text = "Filtro de color rojo";
            this.filtroDeColorToolStripMenuItem.Click += new System.EventHandler(this.filtroDeColorToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(193, 22);
            this.toolStripMenuItem2.Text = " Aberracion Cromatica";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // tonosDeGrisToolStripMenuItem
            // 
            this.tonosDeGrisToolStripMenuItem.Name = "tonosDeGrisToolStripMenuItem";
            this.tonosDeGrisToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.tonosDeGrisToolStripMenuItem.Text = "Tonos de gris";
            this.tonosDeGrisToolStripMenuItem.Click += new System.EventHandler(this.tonosDeGrisToolStripMenuItem_Click);
            // 
            // colorizarToolStripMenuItem
            // 
            this.colorizarToolStripMenuItem.Name = "colorizarToolStripMenuItem";
            this.colorizarToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.colorizarToolStripMenuItem.Text = "Colorizar";
            this.colorizarToolStripMenuItem.Click += new System.EventHandler(this.colorizarToolStripMenuItem_Click);
            // 
            // colonizarGradianteToolStripMenuItem
            // 
            this.colonizarGradianteToolStripMenuItem.Name = "colonizarGradianteToolStripMenuItem";
            this.colonizarGradianteToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.colonizarGradianteToolStripMenuItem.Text = "Colonizar Gradiante";
            this.colonizarGradianteToolStripMenuItem.Click += new System.EventHandler(this.colonizarGradianteToolStripMenuItem_Click);
            // 
            // brilloToolStripMenuItem
            // 
            this.brilloToolStripMenuItem.Name = "brilloToolStripMenuItem";
            this.brilloToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.brilloToolStripMenuItem.Text = "Brillo ";
            this.brilloToolStripMenuItem.Click += new System.EventHandler(this.brilloToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Imagenes PNG|*.png|Imagenes BitMap|*.bmp";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Imagenes PNG|*.png";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 762);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Aplicador de filtros";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirImagenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarImagenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtrosBasicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem negativoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtroDeColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tonosDeGrisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colonizarGradianteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brilloToolStripMenuItem;
    }
}

