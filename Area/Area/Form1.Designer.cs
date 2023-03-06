namespace Area
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.R_Cuadrado = new System.Windows.Forms.Label();
            this.R_Triangulo = new System.Windows.Forms.Label();
            this.R_Circulo = new System.Windows.Forms.Label();
            this.Lado = new System.Windows.Forms.TextBox();
            this.Base = new System.Windows.Forms.TextBox();
            this.Altura = new System.Windows.Forms.TextBox();
            this.Radio = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Lado);
            this.groupBox1.Controls.Add(this.R_Cuadrado);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 164);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cuadrado";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Altura);
            this.groupBox2.Controls.Add(this.Base);
            this.groupBox2.Controls.Add(this.R_Triangulo);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(218, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 164);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Triangulo";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Radio);
            this.groupBox3.Controls.Add(this.R_Circulo);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(424, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 164);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Circulo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Base";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Altura";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Radio";
            // 
            // R_Cuadrado
            // 
            this.R_Cuadrado.AutoSize = true;
            this.R_Cuadrado.Location = new System.Drawing.Point(62, 110);
            this.R_Cuadrado.Name = "R_Cuadrado";
            this.R_Cuadrado.Size = new System.Drawing.Size(0, 13);
            this.R_Cuadrado.TabIndex = 1;
            // 
            // R_Triangulo
            // 
            this.R_Triangulo.AutoSize = true;
            this.R_Triangulo.Location = new System.Drawing.Point(7, 110);
            this.R_Triangulo.Name = "R_Triangulo";
            this.R_Triangulo.Size = new System.Drawing.Size(0, 13);
            this.R_Triangulo.TabIndex = 2;
            // 
            // R_Circulo
            // 
            this.R_Circulo.AutoSize = true;
            this.R_Circulo.Location = new System.Drawing.Point(6, 110);
            this.R_Circulo.Name = "R_Circulo";
            this.R_Circulo.Size = new System.Drawing.Size(0, 13);
            this.R_Circulo.TabIndex = 3;
            // 
            // Lado
            // 
            this.Lado.Location = new System.Drawing.Point(65, 25);
            this.Lado.Name = "Lado";
            this.Lado.Size = new System.Drawing.Size(100, 20);
            this.Lado.TabIndex = 2;
            // 
            // Base
            // 
            this.Base.Location = new System.Drawing.Point(44, 22);
            this.Base.Name = "Base";
            this.Base.Size = new System.Drawing.Size(100, 20);
            this.Base.TabIndex = 3;
            this.Base.TextChanged += new System.EventHandler(this.Base_TextChanged);
            // 
            // Altura
            // 
            this.Altura.Location = new System.Drawing.Point(44, 45);
            this.Altura.Name = "Altura";
            this.Altura.Size = new System.Drawing.Size(100, 20);
            this.Altura.TabIndex = 4;
            this.Altura.TextChanged += new System.EventHandler(this.Altura_TextChanged);
            // 
            // Radio
            // 
            this.Radio.Location = new System.Drawing.Point(47, 25);
            this.Radio.Name = "Radio";
            this.Radio.Size = new System.Drawing.Size(100, 20);
            this.Radio.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(496, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Lado;
        private System.Windows.Forms.Label R_Cuadrado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Altura;
        private System.Windows.Forms.TextBox Base;
        private System.Windows.Forms.Label R_Triangulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label R_Circulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Radio;
        private System.Windows.Forms.Button button1;
    }
}

