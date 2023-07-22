namespace HiKaPractice
{
    partial class FormQuiz
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
            this.textBox_answer = new System.Windows.Forms.TextBox();
            this.button_submit = new System.Windows.Forms.Button();
            this.label_result = new System.Windows.Forms.Label();
            this.label_question_remaining = new System.Windows.Forms.Label();
            this.label_question = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_answer
            // 
            this.textBox_answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_answer.Location = new System.Drawing.Point(269, 384);
            this.textBox_answer.Name = "textBox_answer";
            this.textBox_answer.Size = new System.Drawing.Size(159, 30);
            this.textBox_answer.TabIndex = 1;
            this.textBox_answer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_answer_KeyDown);
            // 
            // button_submit
            // 
            this.button_submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.label_result.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_result.Location = new System.Drawing.Point(0, 53);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(782, 500);
            this.label_result.TabIndex = 3;
            this.label_result.Text = "label_result";
            this.label_result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_result.Visible = false;
            // 
            // label_question_remaining
            // 
            this.label_question_remaining.AutoSize = true;
            this.label_question_remaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_question_remaining.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_question_remaining.Location = new System.Drawing.Point(12, 9);
            this.label_question_remaining.Name = "label_question_remaining";
            this.label_question_remaining.Size = new System.Drawing.Size(234, 25);
            this.label_question_remaining.TabIndex = 4;
            this.label_question_remaining.Text = "label_question_remaining";
            // 
            // label_question
            // 
            this.label_question.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_question.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_question.Location = new System.Drawing.Point(0, 0);
            this.label_question.Name = "label_question";
            this.label_question.Size = new System.Drawing.Size(742, 154);
            this.label_question.TabIndex = 5;
            this.label_question.Text = "label_ques";
            this.label_question.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_question);
            this.panel1.Location = new System.Drawing.Point(20, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(742, 154);
            this.panel1.TabIndex = 6;
            // 
            // FormQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_question_remaining);
            this.Controls.Add(this.button_submit);
            this.Controls.Add(this.textBox_answer);
            this.Controls.Add(this.label_result);
            this.Name = "FormQuiz";
            this.Text = "FormKatakana";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_answer;
        private System.Windows.Forms.Button button_submit;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.Label label_question_remaining;
        private System.Windows.Forms.Label label_question;
        private System.Windows.Forms.Panel panel1;
    }
}