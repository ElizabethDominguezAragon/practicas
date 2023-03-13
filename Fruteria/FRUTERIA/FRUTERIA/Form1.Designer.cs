namespace FRUTERIA
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
            this.Fruta = new System.Windows.Forms.ComboBox();
            this.label = new System.Windows.Forms.Label();
            this.CuadrodeTexto = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Peso = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fruta";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Fruta
            // 
            this.Fruta.BackColor = System.Drawing.SystemColors.Info;
            this.Fruta.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fruta.FormattingEnabled = true;
            this.Fruta.Items.AddRange(new object[] {
            "Mango",
            "Manzana",
            "Uvas",
            "Pera"});
            this.Fruta.Location = new System.Drawing.Point(117, 26);
            this.Fruta.Name = "Fruta";
            this.Fruta.Size = new System.Drawing.Size(121, 27);
            this.Fruta.TabIndex = 2;
            this.Fruta.SelectedIndexChanged += new System.EventHandler(this.Fruta_SelectedIndexChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(51, 99);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(39, 19);
            this.label.TabIndex = 3;
            this.label.Text = "Peso";
            this.label.Click += new System.EventHandler(this.Peso_Click);
            // 
            // CuadrodeTexto
            // 
            this.CuadrodeTexto.AutoSize = true;
            this.CuadrodeTexto.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CuadrodeTexto.Location = new System.Drawing.Point(31, 161);
            this.CuadrodeTexto.Name = "CuadrodeTexto";
            this.CuadrodeTexto.Size = new System.Drawing.Size(0, 19);
            this.CuadrodeTexto.TabIndex = 4;
            this.CuadrodeTexto.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(415, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Peso
            // 
            this.Peso.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Peso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Peso.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Peso.Location = new System.Drawing.Point(117, 92);
            this.Peso.Multiline = true;
            this.Peso.Name = "Peso";
            this.Peso.Size = new System.Drawing.Size(121, 26);
            this.Peso.TabIndex = 6;
            this.Peso.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(658, 345);
            this.Controls.Add(this.Peso);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CuadrodeTexto);
            this.Controls.Add(this.label);
            this.Controls.Add(this.Fruta);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Fruteria";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Fruta;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label CuadrodeTexto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Peso;
    }
}

