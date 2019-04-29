namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.calcularpico_placa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Ingrese_Placa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Numero_Horas = new System.Windows.Forms.NumericUpDown();
            this.Numero_Minutos = new System.Windows.Forms.NumericUpDown();
            this.ampm = new System.Windows.Forms.ComboBox();
            this.calendario = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mensaje = new System.Windows.Forms.Label();
            this.borrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Numero_Horas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numero_Minutos)).BeginInit();
            this.SuspendLayout();
            // 
            // calcularpico_placa
            // 
            this.calcularpico_placa.Location = new System.Drawing.Point(27, 203);
            this.calcularpico_placa.Name = "calcularpico_placa";
            this.calcularpico_placa.Size = new System.Drawing.Size(387, 43);
            this.calcularpico_placa.TabIndex = 0;
            this.calcularpico_placa.Text = "CALCULAR PICO/PLACA";
            this.calcularpico_placa.UseVisualStyleBackColor = true;
            this.calcularpico_placa.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "VEHICULO EN CARRETERA :";
            // 
            // Ingrese_Placa
            // 
            this.Ingrese_Placa.Location = new System.Drawing.Point(27, 66);
            this.Ingrese_Placa.Name = "Ingrese_Placa";
            this.Ingrese_Placa.Size = new System.Drawing.Size(126, 20);
            this.Ingrese_Placa.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "NUMERO DE PLACA";
            // 
            // Numero_Horas
            // 
            this.Numero_Horas.Location = new System.Drawing.Point(33, 157);
            this.Numero_Horas.Name = "Numero_Horas";
            this.Numero_Horas.Size = new System.Drawing.Size(120, 20);
            this.Numero_Horas.TabIndex = 7;
            // 
            // Numero_Minutos
            // 
            this.Numero_Minutos.Location = new System.Drawing.Point(170, 157);
            this.Numero_Minutos.Name = "Numero_Minutos";
            this.Numero_Minutos.Size = new System.Drawing.Size(120, 20);
            this.Numero_Minutos.TabIndex = 7;
            // 
            // ampm
            // 
            this.ampm.FormattingEnabled = true;
            this.ampm.Items.AddRange(new object[] {
            "A.M.",
            "P.M."});
            this.ampm.Location = new System.Drawing.Point(308, 157);
            this.ampm.Name = "ampm";
            this.ampm.Size = new System.Drawing.Size(121, 21);
            this.ampm.TabIndex = 8;
            this.ampm.Text = "HORARIO";
            // 
            // calendario
            // 
            this.calendario.Location = new System.Drawing.Point(204, 66);
            this.calendario.Name = "calendario";
            this.calendario.Size = new System.Drawing.Size(200, 20);
            this.calendario.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "FECHA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "HORAS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(180, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "MINUTOS";
            // 
            // mensaje
            // 
            this.mensaje.AutoSize = true;
            this.mensaje.Location = new System.Drawing.Point(27, 319);
            this.mensaje.Name = "mensaje";
            this.mensaje.Size = new System.Drawing.Size(0, 13);
            this.mensaje.TabIndex = 10;
            // 
            // borrar
            // 
            this.borrar.Location = new System.Drawing.Point(231, 273);
            this.borrar.Name = "borrar";
            this.borrar.Size = new System.Drawing.Size(137, 23);
            this.borrar.TabIndex = 11;
            this.borrar.Text = "NUEVA PLACA";
            this.borrar.UseVisualStyleBackColor = true;
            this.borrar.Click += new System.EventHandler(this.borrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 358);
            this.Controls.Add(this.borrar);
            this.Controls.Add(this.mensaje);
            this.Controls.Add(this.calendario);
            this.Controls.Add(this.ampm);
            this.Controls.Add(this.Numero_Minutos);
            this.Controls.Add(this.Numero_Horas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Ingrese_Placa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calcularpico_placa);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Numero_Horas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numero_Minutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calcularpico_placa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Ingrese_Placa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown Numero_Horas;
        private System.Windows.Forms.NumericUpDown Numero_Minutos;
        private System.Windows.Forms.ComboBox ampm;
        private System.Windows.Forms.DateTimePicker calendario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label mensaje;
        private System.Windows.Forms.Button borrar;
    }

}


