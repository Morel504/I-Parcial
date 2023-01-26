namespace IParcial
{
    partial class Ejercicio1
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
            this.Numero1textBox1 = new System.Windows.Forms.TextBox();
            this.Numero2textBox2 = new System.Windows.Forms.TextBox();
            this.Sumabutton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero 2:";
            // 
            // Numero1textBox1
            // 
            this.Numero1textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.Numero1textBox1.Location = new System.Drawing.Point(313, 102);
            this.Numero1textBox1.Name = "Numero1textBox1";
            this.Numero1textBox1.Size = new System.Drawing.Size(209, 29);
            this.Numero1textBox1.TabIndex = 2;
            // 
            // Numero2textBox2
            // 
            this.Numero2textBox2.Location = new System.Drawing.Point(313, 174);
            this.Numero2textBox2.Name = "Numero2textBox2";
            this.Numero2textBox2.Size = new System.Drawing.Size(209, 29);
            this.Numero2textBox2.TabIndex = 3;
            // 
            // Sumabutton1
            // 
            this.Sumabutton1.Location = new System.Drawing.Point(313, 256);
            this.Sumabutton1.Name = "Sumabutton1";
            this.Sumabutton1.Size = new System.Drawing.Size(209, 39);
            this.Sumabutton1.TabIndex = 4;
            this.Sumabutton1.Text = "sumar";
            this.Sumabutton1.UseVisualStyleBackColor = true;
            this.Sumabutton1.Click += new System.EventHandler(this.Sumabutton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 408);
            this.Controls.Add(this.Sumabutton1);
            this.Controls.Add(this.Numero2textBox2);
            this.Controls.Add(this.Numero1textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Numero1textBox1;
        private System.Windows.Forms.TextBox Numero2textBox2;
        private System.Windows.Forms.Button Sumabutton1;
    }
}

