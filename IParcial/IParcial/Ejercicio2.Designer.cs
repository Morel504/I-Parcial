namespace IParcial
{
    partial class Ejercicio2
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
            this.Numero1label1 = new System.Windows.Forms.Label();
            this.Numero2label2 = new System.Windows.Forms.Label();
            this.Numero1textBox1 = new System.Windows.Forms.TextBox();
            this.Numero2textBox2 = new System.Windows.Forms.TextBox();
            this.OperacionescomboBox1 = new System.Windows.Forms.ComboBox();
            this.Ejecutarbutton1 = new System.Windows.Forms.Button();
            this.Resultadolabel = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Numero1label1
            // 
            this.Numero1label1.AutoSize = true;
            this.Numero1label1.Location = new System.Drawing.Point(148, 61);
            this.Numero1label1.Name = "Numero1label1";
            this.Numero1label1.Size = new System.Drawing.Size(99, 24);
            this.Numero1label1.TabIndex = 0;
            this.Numero1label1.Text = "Numero 1:";
            // 
            // Numero2label2
            // 
            this.Numero2label2.AutoSize = true;
            this.Numero2label2.Location = new System.Drawing.Point(148, 123);
            this.Numero2label2.Name = "Numero2label2";
            this.Numero2label2.Size = new System.Drawing.Size(99, 24);
            this.Numero2label2.TabIndex = 1;
            this.Numero2label2.Text = "Numero 2:";
            // 
            // Numero1textBox1
            // 
            this.Numero1textBox1.Location = new System.Drawing.Point(259, 58);
            this.Numero1textBox1.Name = "Numero1textBox1";
            this.Numero1textBox1.Size = new System.Drawing.Size(208, 29);
            this.Numero1textBox1.TabIndex = 2;
            // 
            // Numero2textBox2
            // 
            this.Numero2textBox2.Location = new System.Drawing.Point(259, 123);
            this.Numero2textBox2.Name = "Numero2textBox2";
            this.Numero2textBox2.Size = new System.Drawing.Size(208, 29);
            this.Numero2textBox2.TabIndex = 3;
            // 
            // OperacionescomboBox1
            // 
            this.OperacionescomboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OperacionescomboBox1.FormattingEnabled = true;
            this.OperacionescomboBox1.Items.AddRange(new object[] {
            "Suma",
            "Resta",
            "Division",
            "Multiplicacion"});
            this.OperacionescomboBox1.Location = new System.Drawing.Point(264, 184);
            this.OperacionescomboBox1.Name = "OperacionescomboBox1";
            this.OperacionescomboBox1.Size = new System.Drawing.Size(208, 32);
            this.OperacionescomboBox1.TabIndex = 4;
            // 
            // Ejecutarbutton1
            // 
            this.Ejecutarbutton1.Location = new System.Drawing.Point(259, 240);
            this.Ejecutarbutton1.Name = "Ejecutarbutton1";
            this.Ejecutarbutton1.Size = new System.Drawing.Size(208, 43);
            this.Ejecutarbutton1.TabIndex = 5;
            this.Ejecutarbutton1.Text = "Ejecutar";
            this.Ejecutarbutton1.UseVisualStyleBackColor = true;
            this.Ejecutarbutton1.Click += new System.EventHandler(this.Ejecutarbutton1_Click);
            // 
            // Resultadolabel
            // 
            this.Resultadolabel.AutoSize = true;
            this.Resultadolabel.Location = new System.Drawing.Point(262, 317);
            this.Resultadolabel.Name = "Resultadolabel";
            this.Resultadolabel.Size = new System.Drawing.Size(60, 24);
            this.Resultadolabel.TabIndex = 6;
            this.Resultadolabel.Text = "label1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Ejercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 449);
            this.Controls.Add(this.Resultadolabel);
            this.Controls.Add(this.Ejecutarbutton1);
            this.Controls.Add(this.OperacionescomboBox1);
            this.Controls.Add(this.Numero2textBox2);
            this.Controls.Add(this.Numero1textBox1);
            this.Controls.Add(this.Numero2label2);
            this.Controls.Add(this.Numero1label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Ejercicio2";
            this.Text = "Ejercicio2";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Numero1label1;
        private System.Windows.Forms.Label Numero2label2;
        private System.Windows.Forms.TextBox Numero1textBox1;
        private System.Windows.Forms.TextBox Numero2textBox2;
        private System.Windows.Forms.ComboBox OperacionescomboBox1;
        private System.Windows.Forms.Button Ejecutarbutton1;
        private System.Windows.Forms.Label Resultadolabel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}