namespace PL.Views
{
    partial class Formulario
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.Paterno = new System.Windows.Forms.TextBox();
            this.Materno = new System.Windows.Forms.TextBox();
            this.RFC = new System.Windows.Forms.TextBox();
            this.Sueldo = new System.Windows.Forms.TextBox();
            this.Guardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IdEmpleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido Paterno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "ApellidoMaterno";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "RFC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sueldo";
            // 
            // Id
            // 
            this.Id.Location = new System.Drawing.Point(113, 39);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(104, 20);
            this.Id.TabIndex = 6;
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(97, 91);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(139, 20);
            this.Nombre.TabIndex = 7;
            // 
            // Paterno
            // 
            this.Paterno.Location = new System.Drawing.Point(127, 117);
            this.Paterno.Name = "Paterno";
            this.Paterno.Size = new System.Drawing.Size(139, 20);
            this.Paterno.TabIndex = 8;
            // 
            // Materno
            // 
            this.Materno.Location = new System.Drawing.Point(127, 147);
            this.Materno.Name = "Materno";
            this.Materno.Size = new System.Drawing.Size(139, 20);
            this.Materno.TabIndex = 9;
            // 
            // RFC
            // 
            this.RFC.Location = new System.Drawing.Point(79, 172);
            this.RFC.Name = "RFC";
            this.RFC.Size = new System.Drawing.Size(152, 20);
            this.RFC.TabIndex = 10;
            // 
            // Sueldo
            // 
            this.Sueldo.Location = new System.Drawing.Point(90, 198);
            this.Sueldo.Name = "Sueldo";
            this.Sueldo.Size = new System.Drawing.Size(100, 20);
            this.Sueldo.TabIndex = 11;
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(113, 257);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(139, 45);
            this.Guardar.TabIndex = 12;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 327);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.Sueldo);
            this.Controls.Add(this.RFC);
            this.Controls.Add(this.Materno);
            this.Controls.Add(this.Paterno);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Formulario";
            this.Text = "Formulario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Id;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.TextBox Paterno;
        private System.Windows.Forms.TextBox Materno;
        private System.Windows.Forms.TextBox RFC;
        private System.Windows.Forms.TextBox Sueldo;
        private System.Windows.Forms.Button Guardar;
    }
}