
namespace UI
{
    partial class AbonarPago
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textFecha = new System.Windows.Forms.TextBox();
            this.textNro = new System.Windows.Forms.TextBox();
            this.textDominio = new System.Windows.Forms.TextBox();
            this.textDni = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textTitular = new System.Windows.Forms.TextBox();
            this.textTipo = new System.Windows.Forms.TextBox();
            this.textImporte = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "&Abonar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(238, 278);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "&Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nro Infracción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dominio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Dni Titular";
            // 
            // textFecha
            // 
            this.textFecha.Location = new System.Drawing.Point(142, 24);
            this.textFecha.Name = "textFecha";
            this.textFecha.ReadOnly = true;
            this.textFecha.Size = new System.Drawing.Size(145, 20);
            this.textFecha.TabIndex = 6;
            // 
            // textNro
            // 
            this.textNro.Location = new System.Drawing.Point(142, 54);
            this.textNro.Name = "textNro";
            this.textNro.ReadOnly = true;
            this.textNro.Size = new System.Drawing.Size(145, 20);
            this.textNro.TabIndex = 7;
            // 
            // textDominio
            // 
            this.textDominio.Location = new System.Drawing.Point(142, 88);
            this.textDominio.Name = "textDominio";
            this.textDominio.ReadOnly = true;
            this.textDominio.Size = new System.Drawing.Size(145, 20);
            this.textDominio.TabIndex = 8;
            // 
            // textDni
            // 
            this.textDni.Location = new System.Drawing.Point(142, 125);
            this.textDni.Name = "textDni";
            this.textDni.ReadOnly = true;
            this.textDni.Size = new System.Drawing.Size(145, 20);
            this.textDni.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nombre del Titular";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tipo de Infraccion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Importe";
            // 
            // textTitular
            // 
            this.textTitular.Location = new System.Drawing.Point(141, 159);
            this.textTitular.Name = "textTitular";
            this.textTitular.ReadOnly = true;
            this.textTitular.Size = new System.Drawing.Size(145, 20);
            this.textTitular.TabIndex = 13;
            // 
            // textTipo
            // 
            this.textTipo.Location = new System.Drawing.Point(141, 195);
            this.textTipo.Name = "textTipo";
            this.textTipo.ReadOnly = true;
            this.textTipo.Size = new System.Drawing.Size(145, 20);
            this.textTipo.TabIndex = 14;
            // 
            // textImporte
            // 
            this.textImporte.Location = new System.Drawing.Point(141, 230);
            this.textImporte.Name = "textImporte";
            this.textImporte.ReadOnly = true;
            this.textImporte.Size = new System.Drawing.Size(145, 20);
            this.textImporte.TabIndex = 15;
            // 
            // AbonarPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 322);
            this.Controls.Add(this.textImporte);
            this.Controls.Add(this.textTipo);
            this.Controls.Add(this.textTitular);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textDni);
            this.Controls.Add(this.textDominio);
            this.Controls.Add(this.textNro);
            this.Controls.Add(this.textFecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "AbonarPago";
            this.Text = "AbonarPago";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textFecha;
        private System.Windows.Forms.TextBox textNro;
        private System.Windows.Forms.TextBox textDominio;
        private System.Windows.Forms.TextBox textDni;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textTitular;
        private System.Windows.Forms.TextBox textTipo;
        private System.Windows.Forms.TextBox textImporte;
    }
}