namespace IParcial
{
    partial class Ejercicio5
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
            this.HornearButton = new System.Windows.Forms.Button();
            this.HornearAzincronoButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Numero1textBox = new System.Windows.Forms.TextBox();
            this.Numero2textBox = new System.Windows.Forms.TextBox();
            this.CalcularButton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HornearButton
            // 
            this.HornearButton.Location = new System.Drawing.Point(97, 49);
            this.HornearButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HornearButton.Name = "HornearButton";
            this.HornearButton.Size = new System.Drawing.Size(224, 59);
            this.HornearButton.TabIndex = 0;
            this.HornearButton.Text = "Hornear Pizza";
            this.HornearButton.UseVisualStyleBackColor = true;
            this.HornearButton.Click += new System.EventHandler(this.HornearButton_Click);
            // 
            // HornearAzincronoButton
            // 
            this.HornearAzincronoButton.Location = new System.Drawing.Point(369, 49);
            this.HornearAzincronoButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HornearAzincronoButton.Name = "HornearAzincronoButton";
            this.HornearAzincronoButton.Size = new System.Drawing.Size(224, 59);
            this.HornearAzincronoButton.TabIndex = 1;
            this.HornearAzincronoButton.Text = "Hornear Pizza asin";
            this.HornearAzincronoButton.UseVisualStyleBackColor = true;
            this.HornearAzincronoButton.Click += new System.EventHandler(this.HornearAzincronoButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numero1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numero2";
            // 
            // Numero1textBox
            // 
            this.Numero1textBox.Location = new System.Drawing.Point(221, 154);
            this.Numero1textBox.Name = "Numero1textBox";
            this.Numero1textBox.Size = new System.Drawing.Size(100, 26);
            this.Numero1textBox.TabIndex = 4;
            // 
            // Numero2textBox
            // 
            this.Numero2textBox.Location = new System.Drawing.Point(221, 196);
            this.Numero2textBox.Name = "Numero2textBox";
            this.Numero2textBox.Size = new System.Drawing.Size(100, 26);
            this.Numero2textBox.TabIndex = 5;
            // 
            // CalcularButton1
            // 
            this.CalcularButton1.Location = new System.Drawing.Point(369, 151);
            this.CalcularButton1.Name = "CalcularButton1";
            this.CalcularButton1.Size = new System.Drawing.Size(170, 71);
            this.CalcularButton1.TabIndex = 6;
            this.CalcularButton1.Text = "Calcular";
            this.CalcularButton1.UseVisualStyleBackColor = true;
            this.CalcularButton1.Click += new System.EventHandler(this.CalcularButton1_Click);
            // 
            // Ejercicio5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 422);
            this.Controls.Add(this.CalcularButton1);
            this.Controls.Add(this.Numero2textBox);
            this.Controls.Add(this.Numero1textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HornearAzincronoButton);
            this.Controls.Add(this.HornearButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Ejercicio5";
            this.Text = "Ejercicio5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button HornearButton;
        private System.Windows.Forms.Button HornearAzincronoButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Numero1textBox;
        private System.Windows.Forms.TextBox Numero2textBox;
        private System.Windows.Forms.Button CalcularButton1;
    }
}