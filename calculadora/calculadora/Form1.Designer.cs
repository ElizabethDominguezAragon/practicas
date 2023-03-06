namespace calculadora
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Opciones = new System.Windows.Forms.Label();
            this.cbOperaciones = new System.Windows.Forms.ComboBox();
            this.bCalcular = new System.Windows.Forms.Button();
            this.T = new System.Windows.Forms.Label();
            this.tBResultado = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.Opciones);
            this.panel1.Controls.Add(this.cbOperaciones);
            this.panel1.Controls.Add(this.bCalcular);
            this.panel1.Controls.Add(this.T);
            this.panel1.Controls.Add(this.tBResultado);
            this.panel1.Controls.Add(this.txt2);
            this.panel1.Controls.Add(this.txt1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(541, 237);
            this.panel1.TabIndex = 0;
            // 
            // Opciones
            // 
            this.Opciones.AutoSize = true;
            this.Opciones.Location = new System.Drawing.Point(298, 38);
            this.Opciones.Name = "Opciones";
            this.Opciones.Size = new System.Drawing.Size(54, 13);
            this.Opciones.TabIndex = 8;
            this.Opciones.Text = "operacion";
            this.Opciones.Click += new System.EventHandler(this.Opciones_Click);
            // 
            // cbOperaciones
            // 
            this.cbOperaciones.FormattingEnabled = true;
            this.cbOperaciones.Items.AddRange(new object[] {
            "+",
            "-",
            "* ",
            "/"});
            this.cbOperaciones.Location = new System.Drawing.Point(376, 38);
            this.cbOperaciones.Name = "cbOperaciones";
            this.cbOperaciones.Size = new System.Drawing.Size(121, 21);
            this.cbOperaciones.TabIndex = 7;
            // 
            // bCalcular
            // 
            this.bCalcular.Location = new System.Drawing.Point(352, 150);
            this.bCalcular.Name = "bCalcular";
            this.bCalcular.Size = new System.Drawing.Size(145, 23);
            this.bCalcular.TabIndex = 6;
            this.bCalcular.Text = "calcular";
            this.bCalcular.UseVisualStyleBackColor = true;
            this.bCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // T
            // 
            this.T.AutoSize = true;
            this.T.Location = new System.Drawing.Point(37, 160);
            this.T.Name = "T";
            this.T.Size = new System.Drawing.Size(73, 13);
            this.T.TabIndex = 5;
            this.T.Text = "RESULTADO";
            this.T.Click += new System.EventHandler(this.T_Click);
            // 
            // tBResultado
            // 
            this.tBResultado.Location = new System.Drawing.Point(116, 153);
            this.tBResultado.Name = "tBResultado";
            this.tBResultado.Size = new System.Drawing.Size(100, 20);
            this.tBResultado.TabIndex = 4;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(95, 65);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(100, 20);
            this.txt2.TabIndex = 3;
            this.txt2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(95, 12);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 20);
            this.txt1.TabIndex = 2;
            this.txt1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero 2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(35, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 266);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label T;
        private System.Windows.Forms.TextBox tBResultado;
        private System.Windows.Forms.Label Opciones;
        private System.Windows.Forms.ComboBox cbOperaciones;
        private System.Windows.Forms.Button bCalcular;
    }
}

