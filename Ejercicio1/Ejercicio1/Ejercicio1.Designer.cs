using System;

namespace Ejercicio1
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
            this.Numero1textBox = new System.Windows.Forms.TextBox();
            this.Numero2textBox = new System.Windows.Forms.TextBox();
            this.Sumabutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Numero1textBox
            // 
            this.Numero1textBox.Location = new System.Drawing.Point(198, 65);
            this.Numero1textBox.Name = "Numero1textBox";
            this.Numero1textBox.Size = new System.Drawing.Size(147, 20);
            this.Numero1textBox.TabIndex = 0;
            // 
            // Numero2textBox
            // 
            this.Numero2textBox.Location = new System.Drawing.Point(198, 120);
            this.Numero2textBox.Name = "Numero2textBox";
            this.Numero2textBox.Size = new System.Drawing.Size(147, 20);
            this.Numero2textBox.TabIndex = 1;
            // 
            // Sumabutton
            // 
            this.Sumabutton.Location = new System.Drawing.Point(199, 162);
            this.Sumabutton.Name = "Sumabutton";
            this.Sumabutton.Size = new System.Drawing.Size(145, 22);
            this.Sumabutton.TabIndex = 2;
            this.Sumabutton.Text = "Sumar";
            this.Sumabutton.UseVisualStyleBackColor = true;
            this.Sumabutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ejercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Sumabutton);
            this.Controls.Add(this.Numero2textBox);
            this.Controls.Add(this.Numero1textBox);
            this.Name = "Ejercicio1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TextBox Numero1textBox;
        private System.Windows.Forms.TextBox Numero2textBox;
        private System.Windows.Forms.Button Sumabutton;
    }
}

