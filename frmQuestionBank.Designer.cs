namespace MCQExam
{
    partial class frmQuestionBank
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblOptionA = new System.Windows.Forms.Label();
            this.lblOptionC = new System.Windows.Forms.Label();
            this.lblOptionB = new System.Windows.Forms.Label();
            this.lblOptionD = new System.Windows.Forms.Label();
            this.lblCorrectOption = new System.Windows.Forms.Label();
            this.txtBoxQuestion = new System.Windows.Forms.TextBox();
            this.txtBoxOptionA = new System.Windows.Forms.TextBox();
            this.txtBoxOptionC = new System.Windows.Forms.TextBox();
            this.txtBoxOptionB = new System.Windows.Forms.TextBox();
            this.txtBoxOptionD = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.comboBoxCorrectionOption = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.comboBoxExamName = new System.Windows.Forms.ComboBox();
            this.lblExamName = new System.Windows.Forms.Label();
            this.lblWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(180, 125);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(98, 25);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Question";
            // 
            // lblOptionA
            // 
            this.lblOptionA.AutoSize = true;
            this.lblOptionA.Location = new System.Drawing.Point(180, 259);
            this.lblOptionA.Name = "lblOptionA";
            this.lblOptionA.Size = new System.Drawing.Size(95, 25);
            this.lblOptionA.TabIndex = 1;
            this.lblOptionA.Text = "Option A";
            // 
            // lblOptionC
            // 
            this.lblOptionC.AutoSize = true;
            this.lblOptionC.Location = new System.Drawing.Point(180, 348);
            this.lblOptionC.Name = "lblOptionC";
            this.lblOptionC.Size = new System.Drawing.Size(96, 25);
            this.lblOptionC.TabIndex = 2;
            this.lblOptionC.Text = "Option C";
            // 
            // lblOptionB
            // 
            this.lblOptionB.AutoSize = true;
            this.lblOptionB.Location = new System.Drawing.Point(665, 259);
            this.lblOptionB.Name = "lblOptionB";
            this.lblOptionB.Size = new System.Drawing.Size(95, 25);
            this.lblOptionB.TabIndex = 3;
            this.lblOptionB.Text = "Option B";
            // 
            // lblOptionD
            // 
            this.lblOptionD.AutoSize = true;
            this.lblOptionD.Location = new System.Drawing.Point(665, 339);
            this.lblOptionD.Name = "lblOptionD";
            this.lblOptionD.Size = new System.Drawing.Size(96, 25);
            this.lblOptionD.TabIndex = 4;
            this.lblOptionD.Text = "Option D";
            // 
            // lblCorrectOption
            // 
            this.lblCorrectOption.AutoSize = true;
            this.lblCorrectOption.Location = new System.Drawing.Point(449, 463);
            this.lblCorrectOption.Name = "lblCorrectOption";
            this.lblCorrectOption.Size = new System.Drawing.Size(151, 25);
            this.lblCorrectOption.TabIndex = 5;
            this.lblCorrectOption.Text = "Correct Option";
            // 
            // txtBoxQuestion
            // 
            this.txtBoxQuestion.Location = new System.Drawing.Point(302, 122);
            this.txtBoxQuestion.Name = "txtBoxQuestion";
            this.txtBoxQuestion.Size = new System.Drawing.Size(825, 31);
            this.txtBoxQuestion.TabIndex = 6;
            // 
            // txtBoxOptionA
            // 
            this.txtBoxOptionA.Location = new System.Drawing.Point(313, 259);
            this.txtBoxOptionA.Name = "txtBoxOptionA";
            this.txtBoxOptionA.Size = new System.Drawing.Size(287, 31);
            this.txtBoxOptionA.TabIndex = 7;
            // 
            // txtBoxOptionC
            // 
            this.txtBoxOptionC.Location = new System.Drawing.Point(313, 341);
            this.txtBoxOptionC.Name = "txtBoxOptionC";
            this.txtBoxOptionC.Size = new System.Drawing.Size(287, 31);
            this.txtBoxOptionC.TabIndex = 8;
            // 
            // txtBoxOptionB
            // 
            this.txtBoxOptionB.Location = new System.Drawing.Point(794, 258);
            this.txtBoxOptionB.Name = "txtBoxOptionB";
            this.txtBoxOptionB.Size = new System.Drawing.Size(295, 31);
            this.txtBoxOptionB.TabIndex = 9;
            // 
            // txtBoxOptionD
            // 
            this.txtBoxOptionD.Location = new System.Drawing.Point(794, 339);
            this.txtBoxOptionD.Name = "txtBoxOptionD";
            this.txtBoxOptionD.Size = new System.Drawing.Size(295, 31);
            this.txtBoxOptionD.TabIndex = 10;
            // 
            // comboBoxCorrectionOption
            // 
            this.comboBoxCorrectionOption.FormattingEnabled = true;
            this.comboBoxCorrectionOption.Items.AddRange(new object[] {
            "Option A",
            "Option B",
            "Option C",
            "Option D"});
            this.comboBoxCorrectionOption.Location = new System.Drawing.Point(632, 455);
            this.comboBoxCorrectionOption.Name = "comboBoxCorrectionOption";
            this.comboBoxCorrectionOption.Size = new System.Drawing.Size(221, 33);
            this.comboBoxCorrectionOption.TabIndex = 11;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(313, 556);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(140, 55);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(986, 714);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(141, 55);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(724, 557);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(129, 54);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // comboBoxExamName
            // 
            this.comboBoxExamName.FormattingEnabled = true;
            this.comboBoxExamName.Location = new System.Drawing.Point(302, 38);
            this.comboBoxExamName.Name = "comboBoxExamName";
            this.comboBoxExamName.Size = new System.Drawing.Size(542, 33);
            this.comboBoxExamName.TabIndex = 16;
            // 
            // lblExamName
            // 
            this.lblExamName.AutoSize = true;
            this.lblExamName.Location = new System.Drawing.Point(150, 38);
            this.lblExamName.Name = "lblExamName";
            this.lblExamName.Size = new System.Drawing.Size(128, 25);
            this.lblExamName.TabIndex = 15;
            this.lblExamName.Text = "Exam Name";
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Location = new System.Drawing.Point(789, 683);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(0, 25);
            this.lblWarning.TabIndex = 17;
            // 
            // frmQuestionBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 798);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.comboBoxExamName);
            this.Controls.Add(this.lblExamName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.comboBoxCorrectionOption);
            this.Controls.Add(this.txtBoxOptionD);
            this.Controls.Add(this.txtBoxOptionB);
            this.Controls.Add(this.txtBoxOptionC);
            this.Controls.Add(this.txtBoxOptionA);
            this.Controls.Add(this.txtBoxQuestion);
            this.Controls.Add(this.lblCorrectOption);
            this.Controls.Add(this.lblOptionD);
            this.Controls.Add(this.lblOptionB);
            this.Controls.Add(this.lblOptionC);
            this.Controls.Add(this.lblOptionA);
            this.Controls.Add(this.lblQuestion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmQuestionBank";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "QuestionBank";
            this.Load += new System.EventHandler(this.frmQuestionBank_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblOptionA;
        private System.Windows.Forms.Label lblOptionC;
        private System.Windows.Forms.Label lblOptionB;
        private System.Windows.Forms.Label lblOptionD;
        private System.Windows.Forms.Label lblCorrectOption;
        private System.Windows.Forms.TextBox txtBoxQuestion;
        private System.Windows.Forms.TextBox txtBoxOptionA;
        private System.Windows.Forms.TextBox txtBoxOptionC;
        private System.Windows.Forms.TextBox txtBoxOptionB;
        private System.Windows.Forms.TextBox txtBoxOptionD;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ComboBox comboBoxCorrectionOption;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox comboBoxExamName;
        private System.Windows.Forms.Label lblExamName;
        private System.Windows.Forms.Label lblWarning;
    }
}