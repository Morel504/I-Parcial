﻿namespace IParcial
{
    partial class Ejercicio4
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
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EjecutarButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DiaTextBox = new System.Windows.Forms.TextBox();
            this.MesTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AñoTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SemanaTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDateTimePicker.Location = new System.Drawing.Point(244, 22);
            this.FechaDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(184, 26);
            this.FechaDateTimePicker.TabIndex = 0;
            // 
            // EjecutarButton
            // 
            this.EjecutarButton.Location = new System.Drawing.Point(458, 20);
            this.EjecutarButton.Name = "EjecutarButton";
            this.EjecutarButton.Size = new System.Drawing.Size(137, 34);
            this.EjecutarButton.TabIndex = 1;
            this.EjecutarButton.Text = "Ejecutar";
            this.EjecutarButton.UseVisualStyleBackColor = true;
            this.EjecutarButton.Click += new System.EventHandler(this.EjecutarButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Día:";
            // 
            // DiaTextBox
            // 
            this.DiaTextBox.Location = new System.Drawing.Point(273, 101);
            this.DiaTextBox.Name = "DiaTextBox";
            this.DiaTextBox.Size = new System.Drawing.Size(155, 26);
            this.DiaTextBox.TabIndex = 3;
            // 
            // MesTextBox
            // 
            this.MesTextBox.Location = new System.Drawing.Point(273, 133);
            this.MesTextBox.Name = "MesTextBox";
            this.MesTextBox.Size = new System.Drawing.Size(155, 26);
            this.MesTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mes:";
            // 
            // AñoTextBox
            // 
            this.AñoTextBox.Location = new System.Drawing.Point(273, 165);
            this.AñoTextBox.Name = "AñoTextBox";
            this.AñoTextBox.Size = new System.Drawing.Size(155, 26);
            this.AñoTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Año:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // SemanaTextBox
            // 
            this.SemanaTextBox.Location = new System.Drawing.Point(273, 197);
            this.SemanaTextBox.Name = "SemanaTextBox";
            this.SemanaTextBox.Size = new System.Drawing.Size(155, 26);
            this.SemanaTextBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(172, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sermana:";
            // 
            // Ejercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 414);
            this.Controls.Add(this.SemanaTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AñoTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MesTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DiaTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EjecutarButton);
            this.Controls.Add(this.FechaDateTimePicker);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Ejercicio4";
            this.Text = "Ejercicio4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker FechaDateTimePicker;
        private System.Windows.Forms.Button EjecutarButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DiaTextBox;
        private System.Windows.Forms.TextBox MesTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AñoTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SemanaTextBox;
        private System.Windows.Forms.Label label4;
    }
}