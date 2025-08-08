namespace SIM
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
            this.components = new System.ComponentModel.Container();
            this.Btn_1 = new System.Windows.Forms.Button();
            this.Btn_2 = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Btn_0 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Btn_4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_3 = new System.Windows.Forms.Button();
            this.Btn_5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_1
            // 
            this.Btn_1.Location = new System.Drawing.Point(12, 426);
            this.Btn_1.Name = "Btn_1";
            this.Btn_1.Size = new System.Drawing.Size(75, 27);
            this.Btn_1.TabIndex = 0;
            this.Btn_1.Text = "Start";
            this.Btn_1.UseVisualStyleBackColor = true;
            this.Btn_1.Click += new System.EventHandler(this.Btn_1_Click);
            // 
            // Btn_2
            // 
            this.Btn_2.Location = new System.Drawing.Point(93, 426);
            this.Btn_2.Name = "Btn_2";
            this.Btn_2.Size = new System.Drawing.Size(75, 27);
            this.Btn_2.TabIndex = 1;
            this.Btn_2.Text = "Stop";
            this.Btn_2.UseVisualStyleBackColor = true;
            this.Btn_2.Click += new System.EventHandler(this.Btn_2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 399);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // Btn_0
            // 
            this.Btn_0.Location = new System.Drawing.Point(697, 430);
            this.Btn_0.Name = "Btn_0";
            this.Btn_0.Size = new System.Drawing.Size(75, 23);
            this.Btn_0.TabIndex = 9;
            this.Btn_0.Text = "Exit";
            this.Btn_0.UseVisualStyleBackColor = true;
            this.Btn_0.Click += new System.EventHandler(this.Btn_0_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(74, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(79, 20);
            this.textBox1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Hz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "tiempo (s)";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(74, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(79, 20);
            this.textBox2.TabIndex = 14;
            // 
            // Btn_4
            // 
            this.Btn_4.AccessibleName = "Conectar";
            this.Btn_4.Image = global::SIM.Properties.Resources.transferencia_de_datos;
            this.Btn_4.Location = new System.Drawing.Point(104, 366);
            this.Btn_4.Name = "Btn_4";
            this.Btn_4.Size = new System.Drawing.Size(29, 27);
            this.Btn_4.TabIndex = 15;
            this.Btn_4.Tag = "Conectar";
            this.Btn_4.UseVisualStyleBackColor = true;
            this.Btn_4.Click += new System.EventHandler(this.Btn_4_ClickAsync);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(191, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(581, 408);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // Btn_3
            // 
            this.Btn_3.AccessibleName = "Actualizar";
            this.Btn_3.Image = global::SIM.Properties.Resources.actualizar;
            this.Btn_3.Location = new System.Drawing.Point(12, 366);
            this.Btn_3.Name = "Btn_3";
            this.Btn_3.Size = new System.Drawing.Size(33, 27);
            this.Btn_3.TabIndex = 8;
            this.Btn_3.Tag = "Actualizar";
            this.Btn_3.UseVisualStyleBackColor = true;
            this.Btn_3.Click += new System.EventHandler(this.Btn_3_Click);
            // 
            // Btn_5
            // 
            this.Btn_5.AccessibleName = "Desconectar";
            this.Btn_5.Image = global::SIM.Properties.Resources.transferencia_de_datos;
            this.Btn_5.Location = new System.Drawing.Point(139, 366);
            this.Btn_5.Name = "Btn_5";
            this.Btn_5.Size = new System.Drawing.Size(29, 27);
            this.Btn_5.TabIndex = 16;
            this.Btn_5.Tag = "Desconectar";
            this.Btn_5.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.ControlBox = false;
            this.Controls.Add(this.Btn_5);
            this.Controls.Add(this.Btn_4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Btn_0);
            this.Controls.Add(this.Btn_3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Btn_2);
            this.Controls.Add(this.Btn_1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_1;
        private System.Windows.Forms.Button Btn_2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Btn_3;
        private System.Windows.Forms.Button Btn_0;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Btn_4;
        private System.Windows.Forms.Button Btn_5;
    }
}