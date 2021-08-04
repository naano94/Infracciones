
namespace UI
{
    partial class ModificarTipoInfraccion
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
            this.textCosto = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textCodigo = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radioLeve = new System.Windows.Forms.RadioButton();
            this.radioGrave = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textCosto
            // 
            this.textCosto.Location = new System.Drawing.Point(135, 139);
            this.textCosto.Name = "textCosto";
            this.textCosto.Size = new System.Drawing.Size(240, 20);
            this.textCosto.TabIndex = 22;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(135, 96);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(240, 20);
            this.textNombre.TabIndex = 21;
            // 
            // textCodigo
            // 
            this.textCodigo.Location = new System.Drawing.Point(135, 48);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.ReadOnly = true;
            this.textCodigo.Size = new System.Drawing.Size(240, 20);
            this.textCodigo.TabIndex = 20;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(300, 250);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "&Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "&Modificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Categoría";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Costo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Código";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(417, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.cerrarToolStripMenuItem.Text = "&Cerrar";
            // 
            // radioLeve
            // 
            this.radioLeve.AutoSize = true;
            this.radioLeve.Location = new System.Drawing.Point(135, 190);
            this.radioLeve.Name = "radioLeve";
            this.radioLeve.Size = new System.Drawing.Size(99, 17);
            this.radioLeve.TabIndex = 24;
            this.radioLeve.TabStop = true;
            this.radioLeve.Text = "Infracción Leve";
            this.radioLeve.UseVisualStyleBackColor = true;
            // 
            // radioGrave
            // 
            this.radioGrave.AutoSize = true;
            this.radioGrave.Location = new System.Drawing.Point(271, 190);
            this.radioGrave.Name = "radioGrave";
            this.radioGrave.Size = new System.Drawing.Size(104, 17);
            this.radioGrave.TabIndex = 25;
            this.radioGrave.TabStop = true;
            this.radioGrave.Text = "Infracción Grave";
            this.radioGrave.UseVisualStyleBackColor = true;
            // 
            // ModificarTipoInfraccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 290);
            this.Controls.Add(this.radioGrave);
            this.Controls.Add(this.radioLeve);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.textCosto);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.textCodigo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ModificarTipoInfraccion";
            this.Text = "Modificar Tipo de Infraccion";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textCosto;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textCodigo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.RadioButton radioLeve;
        private System.Windows.Forms.RadioButton radioGrave;
    }
}