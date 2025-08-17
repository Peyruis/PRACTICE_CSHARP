namespace Ejm_1
{
    partial class Form2
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
            this.chkMonitor = new System.Windows.Forms.CheckBox();
            this.chkDiscoDuro = new System.Windows.Forms.CheckBox();
            this.chkLaptop = new System.Windows.Forms.CheckBox();
            this.chkImpresora = new System.Windows.Forms.CheckBox();
            this.chkCamara = new System.Windows.Forms.CheckBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtIgv = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.pbMonitor = new System.Windows.Forms.PictureBox();
            this.pbLaptop = new System.Windows.Forms.PictureBox();
            this.pbDisco = new System.Windows.Forms.PictureBox();
            this.pbImpresora = new System.Windows.Forms.PictureBox();
            this.pbCamara = new System.Windows.Forms.PictureBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbMonitor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLaptop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDisco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImpresora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCamara)).BeginInit();
            this.SuspendLayout();
            // 
            // chkMonitor
            // 
            this.chkMonitor.AutoSize = true;
            this.chkMonitor.Location = new System.Drawing.Point(89, 190);
            this.chkMonitor.Name = "chkMonitor";
            this.chkMonitor.Size = new System.Drawing.Size(71, 19);
            this.chkMonitor.TabIndex = 0;
            this.chkMonitor.Text = "Monitor";
            this.chkMonitor.UseVisualStyleBackColor = true;
            // 
            // chkDiscoDuro
            // 
            this.chkDiscoDuro.AutoSize = true;
            this.chkDiscoDuro.Location = new System.Drawing.Point(89, 223);
            this.chkDiscoDuro.Name = "chkDiscoDuro";
            this.chkDiscoDuro.Size = new System.Drawing.Size(90, 19);
            this.chkDiscoDuro.TabIndex = 1;
            this.chkDiscoDuro.Text = "Disco Duro";
            this.chkDiscoDuro.UseVisualStyleBackColor = true;
            // 
            // chkLaptop
            // 
            this.chkLaptop.AutoSize = true;
            this.chkLaptop.Location = new System.Drawing.Point(89, 258);
            this.chkLaptop.Name = "chkLaptop";
            this.chkLaptop.Size = new System.Drawing.Size(67, 19);
            this.chkLaptop.TabIndex = 2;
            this.chkLaptop.Text = "Laptop";
            this.chkLaptop.UseVisualStyleBackColor = true;
            // 
            // chkImpresora
            // 
            this.chkImpresora.AutoSize = true;
            this.chkImpresora.Location = new System.Drawing.Point(89, 293);
            this.chkImpresora.Name = "chkImpresora";
            this.chkImpresora.Size = new System.Drawing.Size(85, 19);
            this.chkImpresora.TabIndex = 3;
            this.chkImpresora.Text = "Impresora";
            this.chkImpresora.UseVisualStyleBackColor = true;
            // 
            // chkCamara
            // 
            this.chkCamara.AutoSize = true;
            this.chkCamara.Location = new System.Drawing.Point(89, 329);
            this.chkCamara.Name = "chkCamara";
            this.chkCamara.Size = new System.Drawing.Size(73, 19);
            this.chkCamara.TabIndex = 4;
            this.chkCamara.Text = "Camara";
            this.chkCamara.UseVisualStyleBackColor = true;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(745, 193);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubtotal.TabIndex = 5;
            // 
            // txtIgv
            // 
            this.txtIgv.Location = new System.Drawing.Point(745, 228);
            this.txtIgv.Name = "txtIgv";
            this.txtIgv.Size = new System.Drawing.Size(100, 20);
            this.txtIgv.TabIndex = 6;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(745, 266);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 7;
            // 
            // pbMonitor
            // 
            this.pbMonitor.Image = global::Ejm_1.Properties.Resources.pngimg_com___laptop_PNG101796;
            this.pbMonitor.Location = new System.Drawing.Point(265, 266);
            this.pbMonitor.Name = "pbMonitor";
            this.pbMonitor.Size = new System.Drawing.Size(135, 98);
            this.pbMonitor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMonitor.TabIndex = 8;
            this.pbMonitor.TabStop = false;
            this.pbMonitor.Click += new System.EventHandler(this.pbMonitor_Click);
            // 
            // pbLaptop
            // 
            this.pbLaptop.Image = global::Ejm_1.Properties.Resources.pngimg_com___laptop_PNG101796;
            this.pbLaptop.Location = new System.Drawing.Point(443, 262);
            this.pbLaptop.Name = "pbLaptop";
            this.pbLaptop.Size = new System.Drawing.Size(137, 102);
            this.pbLaptop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLaptop.TabIndex = 9;
            this.pbLaptop.TabStop = false;
            this.pbLaptop.Click += new System.EventHandler(this.pbLaptop_Click);
            // 
            // pbDisco
            // 
            this.pbDisco.Image = global::Ejm_1.Properties.Resources.pngimg_com___laptop_PNG101796;
            this.pbDisco.Location = new System.Drawing.Point(344, 165);
            this.pbDisco.Name = "pbDisco";
            this.pbDisco.Size = new System.Drawing.Size(150, 83);
            this.pbDisco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDisco.TabIndex = 10;
            this.pbDisco.TabStop = false;
            this.pbDisco.Click += new System.EventHandler(this.pbDisco_Click);
            // 
            // pbImpresora
            // 
            this.pbImpresora.Image = global::Ejm_1.Properties.Resources.pngimg_com___laptop_PNG101796;
            this.pbImpresora.Location = new System.Drawing.Point(265, 375);
            this.pbImpresora.Name = "pbImpresora";
            this.pbImpresora.Size = new System.Drawing.Size(138, 104);
            this.pbImpresora.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImpresora.TabIndex = 11;
            this.pbImpresora.TabStop = false;
            this.pbImpresora.Click += new System.EventHandler(this.pbImpresora_Click);
            // 
            // pbCamara
            // 
            this.pbCamara.Image = global::Ejm_1.Properties.Resources.pngimg_com___laptop_PNG101796;
            this.pbCamara.Location = new System.Drawing.Point(443, 380);
            this.pbCamara.Name = "pbCamara";
            this.pbCamara.Size = new System.Drawing.Size(137, 99);
            this.pbCamara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCamara.TabIndex = 12;
            this.pbCamara.TabStop = false;
            this.pbCamara.Click += new System.EventHandler(this.pbCamara_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(932, 188);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(80, 29);
            this.btnCalcular.TabIndex = 13;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(932, 223);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(80, 29);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(932, 262);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(80, 29);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(654, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Subtotal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(654, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "IGV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(654, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "TOTAL";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1357, 747);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.pbCamara);
            this.Controls.Add(this.pbImpresora);
            this.Controls.Add(this.pbDisco);
            this.Controls.Add(this.pbLaptop);
            this.Controls.Add(this.pbMonitor);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtIgv);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.chkCamara);
            this.Controls.Add(this.chkImpresora);
            this.Controls.Add(this.chkLaptop);
            this.Controls.Add(this.chkDiscoDuro);
            this.Controls.Add(this.chkMonitor);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMonitor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLaptop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDisco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImpresora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCamara)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkMonitor;
        private System.Windows.Forms.CheckBox chkDiscoDuro;
        private System.Windows.Forms.CheckBox chkLaptop;
        private System.Windows.Forms.CheckBox chkImpresora;
        private System.Windows.Forms.CheckBox chkCamara;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtIgv;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.PictureBox pbMonitor;
        private System.Windows.Forms.PictureBox pbLaptop;
        private System.Windows.Forms.PictureBox pbDisco;
        private System.Windows.Forms.PictureBox pbImpresora;
        private System.Windows.Forms.PictureBox pbCamara;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}