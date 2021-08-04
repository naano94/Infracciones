
namespace UI
{
    partial class AgregarVehiculo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textDominio = new System.Windows.Forms.TextBox();
            this.textMarca = new System.Windows.Forms.TextBox();
            this.textModelo = new System.Windows.Forms.TextBox();
            this.textDni = new System.Windows.Forms.TextBox();
            this.radioMoto = new System.Windows.Forms.RadioButton();
            this.radioAuto = new System.Windows.Forms.RadioButton();
            this.radioUtilitario = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dominio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marca";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(395, 24);
            this.menuStrip1.TabIndex = 2;
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
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Modelo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "DNI Titular";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tipo de Vehiculo";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "&Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(282, 275);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "&Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textDominio
            // 
            this.textDominio.Location = new System.Drawing.Point(95, 49);
            this.textDominio.Name = "textDominio";
            this.textDominio.Size = new System.Drawing.Size(262, 20);
            this.textDominio.TabIndex = 11;
            // 
            // textMarca
            // 
            this.textMarca.Location = new System.Drawing.Point(95, 92);
            this.textMarca.Name = "textMarca";
            this.textMarca.Size = new System.Drawing.Size(262, 20);
            this.textMarca.TabIndex = 12;
            // 
            // textModelo
            // 
            this.textModelo.Location = new System.Drawing.Point(95, 132);
            this.textModelo.Name = "textModelo";
            this.textModelo.Size = new System.Drawing.Size(262, 20);
            this.textModelo.TabIndex = 13;
            // 
            // textDni
            // 
            this.textDni.Location = new System.Drawing.Point(95, 181);
            this.textDni.Name = "textDni";
            this.textDni.Size = new System.Drawing.Size(262, 20);
            this.textDni.TabIndex = 14;
            // 
            // radioMoto
            // 
            this.radioMoto.AutoSize = true;
            this.radioMoto.Location = new System.Drawing.Point(105, 225);
            this.radioMoto.Name = "radioMoto";
            this.radioMoto.Size = new System.Drawing.Size(80, 17);
            this.radioMoto.TabIndex = 15;
            this.radioMoto.TabStop = true;
            this.radioMoto.Text = "Motocicleta";
            this.radioMoto.UseVisualStyleBackColor = true;
            // 
            // radioAuto
            // 
            this.radioAuto.AutoSize = true;
            this.radioAuto.Location = new System.Drawing.Point(200, 226);
            this.radioAuto.Name = "radioAuto";
            this.radioAuto.Size = new System.Drawing.Size(71, 17);
            this.radioAuto.TabIndex = 16;
            this.radioAuto.TabStop = true;
            this.radioAuto.Text = "Automovil";
            this.radioAuto.UseVisualStyleBackColor = true;
            // 
            // radioUtilitario
            // 
            this.radioUtilitario.AutoSize = true;
            this.radioUtilitario.Location = new System.Drawing.Point(295, 227);
            this.radioUtilitario.Name = "radioUtilitario";
            this.radioUtilitario.Size = new System.Drawing.Size(62, 17);
            this.radioUtilitario.TabIndex = 17;
            this.radioUtilitario.TabStop = true;
            this.radioUtilitario.Text = "Utilitario";
            this.radioUtilitario.UseVisualStyleBackColor = true;
            // 
            // AgregarVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 310);
            this.Controls.Add(this.radioUtilitario);
            this.Controls.Add(this.radioAuto);
            this.Controls.Add(this.radioMoto);
            this.Controls.Add(this.textDni);
            this.Controls.Add(this.textModelo);
            this.Controls.Add(this.textMarca);
            this.Controls.Add(this.textDominio);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AgregarVehiculo";
            this.Text = "AgregarVehiculo";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textDominio;
        private System.Windows.Forms.TextBox textMarca;
        private System.Windows.Forms.TextBox textModelo;
        private System.Windows.Forms.TextBox textDni;
        private System.Windows.Forms.RadioButton radioMoto;
        private System.Windows.Forms.RadioButton radioAuto;
        private System.Windows.Forms.RadioButton radioUtilitario;
    }
}