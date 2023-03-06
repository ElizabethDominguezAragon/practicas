namespace WindowsFormsApp2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Calcular = new System.Windows.Forms.Button();
            this.Txt_Edad = new System.Windows.Forms.TextBox();
            this.txt_M = new System.Windows.Forms.TextBox();
            this.Cuadro_texto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edad";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "m²";
            // 
            // Calcular
            // 
            this.Calcular.Location = new System.Drawing.Point(163, 209);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(75, 23);
            this.Calcular.TabIndex = 2;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // Txt_Edad
            // 
            this.Txt_Edad.Location = new System.Drawing.Point(145, 35);
            this.Txt_Edad.Name = "Txt_Edad";
            this.Txt_Edad.Size = new System.Drawing.Size(143, 20);
            this.Txt_Edad.TabIndex = 3;
            this.Txt_Edad.TextChanged += new System.EventHandler(this.Txt_Edad_TextChanged);
            // 
            // txt_M
            // 
            this.txt_M.Location = new System.Drawing.Point(145, 84);
            this.txt_M.Name = "txt_M";
            this.txt_M.Size = new System.Drawing.Size(143, 20);
            this.txt_M.TabIndex = 4;
            // 
            // Cuadro_texto
            // 
            this.Cuadro_texto.AutoSize = true;
            this.Cuadro_texto.Location = new System.Drawing.Point(100, 140);
            this.Cuadro_texto.Name = "Cuadro_texto";
            this.Cuadro_texto.Size = new System.Drawing.Size(0, 13);
            this.Cuadro_texto.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Cuadro_texto);
            this.Controls.Add(this.txt_M);
            this.Controls.Add(this.Txt_Edad);
            this.Controls.Add(this.Calcular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.TextBox Txt_Edad;
        private System.Windows.Forms.TextBox txt_M;
        private System.Windows.Forms.Label Cuadro_texto;
    }
}

