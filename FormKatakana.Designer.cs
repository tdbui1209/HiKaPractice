namespace HiKaPractice
{
    partial class Katakana
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
            this.pictureBox_question = new System.Windows.Forms.PictureBox();
            this.textBox_answer = new System.Windows.Forms.TextBox();
            this.button_submit = new System.Windows.Forms.Button();
            this.label_result = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_question)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_question
            // 
            this.pictureBox_question.Location = new System.Drawing.Point(269, 26);
            this.pictureBox_question.Name = "pictureBox_question";
            this.pictureBox_question.Size = new System.Drawing.Size(244, 239);
            this.pictureBox_question.TabIndex = 0;
            this.pictureBox_question.TabStop = false;
            // 
            // textBox_answer
            // 
            this.textBox_answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_answer.Location = new System.Drawing.Point(269, 384);
            this.textBox_answer.Name = "textBox_answer";
            this.textBox_answer.Size = new System.Drawing.Size(159, 30);
            this.textBox_answer.TabIndex = 1;
            // 
            // button_submit
            // 
            this.button_submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_submit.Location = new System.Drawing.Point(434, 386);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(79, 29);
            this.button_submit.TabIndex = 2;
            this.button_submit.Text = "Submit";
            this.button_submit.UseVisualStyleBackColor = true;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_result.Location = new System.Drawing.Point(311, 283);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(161, 32);
            this.label_result.TabIndex = 3;
            this.label_result.Text = "label_result";
            this.label_result.Visible = false;
            // 
            // Katakana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.button_submit);
            this.Controls.Add(this.textBox_answer);
            this.Controls.Add(this.pictureBox_question);
            this.Name = "Katakana";
            this.Text = "FormKatakana";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_question)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_question;
        private System.Windows.Forms.TextBox textBox_answer;
        private System.Windows.Forms.Button button_submit;
        private System.Windows.Forms.Label label_result;
    }
}