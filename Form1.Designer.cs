﻿namespace HiKaPractice
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
            this.button_hiragana = new System.Windows.Forms.Button();
            this.button_katakana = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_hiragana
            // 
            this.button_hiragana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.button_hiragana.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_hiragana.Location = new System.Drawing.Point(325, 100);
            this.button_hiragana.Name = "button_hiragana";
            this.button_hiragana.Size = new System.Drawing.Size(150, 80);
            this.button_hiragana.TabIndex = 0;
            this.button_hiragana.Text = "HIRAGANA\r\nひらがな\r\n";
            this.button_hiragana.UseVisualStyleBackColor = false;
            this.button_hiragana.Click += new System.EventHandler(this.button_hiragana_Click);
            // 
            // button_katakana
            // 
            this.button_katakana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.button_katakana.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_katakana.Location = new System.Drawing.Point(325, 186);
            this.button_katakana.Name = "button_katakana";
            this.button_katakana.Size = new System.Drawing.Size(150, 80);
            this.button_katakana.TabIndex = 1;
            this.button_katakana.Text = "KATAKANA\r\nかたかな\r\n";
            this.button_katakana.UseVisualStyleBackColor = false;
            this.button_katakana.Click += new System.EventHandler(this.button_katakana_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.button_katakana);
            this.Controls.Add(this.button_hiragana);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HiKa Practice";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_hiragana;
        private System.Windows.Forms.Button button_katakana;
    }
}
