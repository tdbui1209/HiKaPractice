namespace HiKaPractice
{
    partial class FormResult
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
            this.label_correct_num = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_correct_percent = new System.Windows.Forms.Label();
            this.listView_result = new System.Windows.Forms.ListView();
            this.columnHeader_Question = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_CorrectAnswer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Answer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(323, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "KẾT QUẢ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(285, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số câu đúng:";
            // 
            // label_correct_num
            // 
            this.label_correct_num.AutoSize = true;
            this.label_correct_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_correct_num.Location = new System.Drawing.Point(437, 150);
            this.label_correct_num.Name = "label_correct_num";
            this.label_correct_num.Size = new System.Drawing.Size(64, 25);
            this.label_correct_num.TabIndex = 2;
            this.label_correct_num.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(285, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tỉ lệ đúng:";
            // 
            // label_correct_percent
            // 
            this.label_correct_percent.AutoSize = true;
            this.label_correct_percent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_correct_percent.Location = new System.Drawing.Point(437, 191);
            this.label_correct_percent.Name = "label_correct_percent";
            this.label_correct_percent.Size = new System.Drawing.Size(64, 25);
            this.label_correct_percent.TabIndex = 4;
            this.label_correct_percent.Text = "label5";
            // 
            // listView_result
            // 
            this.listView_result.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_Question,
            this.columnHeader_CorrectAnswer,
            this.columnHeader_Answer});
            this.listView_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_result.HideSelection = false;
            this.listView_result.Location = new System.Drawing.Point(12, 241);
            this.listView_result.Name = "listView_result";
            this.listView_result.Size = new System.Drawing.Size(758, 300);
            this.listView_result.TabIndex = 5;
            this.listView_result.UseCompatibleStateImageBehavior = false;
            this.listView_result.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_Question
            // 
            this.columnHeader_Question.Text = "Câu hỏi";
            this.columnHeader_Question.Width = 74;
            // 
            // columnHeader_CorrectAnswer
            // 
            this.columnHeader_CorrectAnswer.Text = "Kết quả đúng";
            this.columnHeader_CorrectAnswer.Width = 119;
            // 
            // columnHeader_Answer
            // 
            this.columnHeader_Answer.Text = "Trả lời";
            this.columnHeader_Answer.Width = 561;
            // 
            // FormResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.listView_result);
            this.Controls.Add(this.label_correct_percent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_correct_num);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormResult";
            this.Text = "Kết quả";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_correct_num;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_correct_percent;
        private System.Windows.Forms.ListView listView_result;
        private System.Windows.Forms.ColumnHeader columnHeader_Question;
        private System.Windows.Forms.ColumnHeader columnHeader_Answer;
        private System.Windows.Forms.ColumnHeader columnHeader_CorrectAnswer;
    }
}