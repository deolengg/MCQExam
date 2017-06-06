namespace MCQExam
{
    partial class frmforChangeInQuestionBank
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
            this.lblExamName = new System.Windows.Forms.Label();
            this.comboBoxExamName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxQuestionName = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.comboBoxCorrectionOption = new System.Windows.Forms.ComboBox();
            this.txtBoxOptionD = new System.Windows.Forms.TextBox();
            this.txtBoxOptionB = new System.Windows.Forms.TextBox();
            this.txtBoxOptionC = new System.Windows.Forms.TextBox();
            this.txtBoxOptionA = new System.Windows.Forms.TextBox();
            this.lblCorrectOption = new System.Windows.Forms.Label();
            this.lblOptionD = new System.Windows.Forms.Label();
            this.lblOptionB = new System.Windows.Forms.Label();
            this.lblOptionC = new System.Windows.Forms.Label();
            this.lblOptionA = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.txtBoxQuestion = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblExamName
            // 
            this.lblExamName.AutoSize = true;
            this.lblExamName.Location = new System.Drawing.Point(233, 69);
            this.lblExamName.Name = "lblExamName";
            this.lblExamName.Size = new System.Drawing.Size(128, 25);
            this.lblExamName.TabIndex = 0;
            this.lblExamName.Text = "Exam Name";
            // 
            // comboBoxExamName
            // 
            this.comboBoxExamName.FormattingEnabled = true;
            this.comboBoxExamName.Location = new System.Drawing.Point(425, 69);
            this.comboBoxExamName.Name = "comboBoxExamName";
            this.comboBoxExamName.Size = new System.Drawing.Size(542, 33);
            this.comboBoxExamName.TabIndex = 1;
            this.comboBoxExamName.SelectedIndexChanged += new System.EventHandler(this.comboBoxExamName_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Question Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBoxQuestionName
            // 
            this.comboBoxQuestionName.FormattingEnabled = true;
            this.comboBoxQuestionName.Location = new System.Drawing.Point(425, 136);
            this.comboBoxQuestionName.Name = "comboBoxQuestionName";
            this.comboBoxQuestionName.Size = new System.Drawing.Size(1198, 33);
            this.comboBoxQuestionName.TabIndex = 3;
            this.comboBoxQuestionName.SelectedIndexChanged += new System.EventHandler(this.comboBoxQuestionName_SelectedIndexChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(931, 760);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(129, 54);
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(275, 759);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(140, 55);
            this.btnReset.TabIndex = 25;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // comboBoxCorrectionOption
            // 
            this.comboBoxCorrectionOption.FormattingEnabled = true;
            this.comboBoxCorrectionOption.Items.AddRange(new object[] {
            "Option A",
            "Option B",
            "Option C",
            "Option D"});
            this.comboBoxCorrectionOption.Location = new System.Drawing.Point(839, 567);
            this.comboBoxCorrectionOption.Name = "comboBoxCorrectionOption";
            this.comboBoxCorrectionOption.Size = new System.Drawing.Size(221, 33);
            this.comboBoxCorrectionOption.TabIndex = 24;
            // 
            // txtBoxOptionD
            // 
            this.txtBoxOptionD.Location = new System.Drawing.Point(1020, 442);
            this.txtBoxOptionD.Name = "txtBoxOptionD";
            this.txtBoxOptionD.Size = new System.Drawing.Size(295, 31);
            this.txtBoxOptionD.TabIndex = 23;
            // 
            // txtBoxOptionB
            // 
            this.txtBoxOptionB.Location = new System.Drawing.Point(1020, 336);
            this.txtBoxOptionB.Name = "txtBoxOptionB";
            this.txtBoxOptionB.Size = new System.Drawing.Size(295, 31);
            this.txtBoxOptionB.TabIndex = 22;
            // 
            // txtBoxOptionC
            // 
            this.txtBoxOptionC.Location = new System.Drawing.Point(425, 445);
            this.txtBoxOptionC.Name = "txtBoxOptionC";
            this.txtBoxOptionC.Size = new System.Drawing.Size(287, 31);
            this.txtBoxOptionC.TabIndex = 21;
            // 
            // txtBoxOptionA
            // 
            this.txtBoxOptionA.Location = new System.Drawing.Point(425, 339);
            this.txtBoxOptionA.Name = "txtBoxOptionA";
            this.txtBoxOptionA.Size = new System.Drawing.Size(287, 31);
            this.txtBoxOptionA.TabIndex = 20;
            this.txtBoxOptionA.TextChanged += new System.EventHandler(this.txtBoxOptionA_TextChanged);
            // 
            // lblCorrectOption
            // 
            this.lblCorrectOption.AutoSize = true;
            this.lblCorrectOption.Location = new System.Drawing.Point(635, 570);
            this.lblCorrectOption.Name = "lblCorrectOption";
            this.lblCorrectOption.Size = new System.Drawing.Size(151, 25);
            this.lblCorrectOption.TabIndex = 19;
            this.lblCorrectOption.Text = "Correct Option";
            // 
            // lblOptionD
            // 
            this.lblOptionD.AutoSize = true;
            this.lblOptionD.Location = new System.Drawing.Point(875, 442);
            this.lblOptionD.Name = "lblOptionD";
            this.lblOptionD.Size = new System.Drawing.Size(96, 25);
            this.lblOptionD.TabIndex = 18;
            this.lblOptionD.Text = "Option D";
            // 
            // lblOptionB
            // 
            this.lblOptionB.AutoSize = true;
            this.lblOptionB.Location = new System.Drawing.Point(876, 339);
            this.lblOptionB.Name = "lblOptionB";
            this.lblOptionB.Size = new System.Drawing.Size(95, 25);
            this.lblOptionB.TabIndex = 17;
            this.lblOptionB.Text = "Option B";
            // 
            // lblOptionC
            // 
            this.lblOptionC.AutoSize = true;
            this.lblOptionC.Location = new System.Drawing.Point(265, 448);
            this.lblOptionC.Name = "lblOptionC";
            this.lblOptionC.Size = new System.Drawing.Size(96, 25);
            this.lblOptionC.TabIndex = 16;
            this.lblOptionC.Text = "Option C";
            // 
            // lblOptionA
            // 
            this.lblOptionA.AutoSize = true;
            this.lblOptionA.Location = new System.Drawing.Point(266, 336);
            this.lblOptionA.Name = "lblOptionA";
            this.lblOptionA.Size = new System.Drawing.Size(95, 25);
            this.lblOptionA.TabIndex = 15;
            this.lblOptionA.Text = "Option A";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(270, 245);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(98, 25);
            this.lblQuestion.TabIndex = 27;
            this.lblQuestion.Text = "Question";
            // 
            // txtBoxQuestion
            // 
            this.txtBoxQuestion.Location = new System.Drawing.Point(425, 245);
            this.txtBoxQuestion.Name = "txtBoxQuestion";
            this.txtBoxQuestion.Size = new System.Drawing.Size(1198, 31);
            this.txtBoxQuestion.TabIndex = 28;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(660, 760);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(142, 54);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1478, 822);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 51);
            this.button1.TabIndex = 30;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmforChangeInQuestionBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1974, 929);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtBoxQuestion);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.comboBoxCorrectionOption);
            this.Controls.Add(this.txtBoxOptionD);
            this.Controls.Add(this.txtBoxOptionB);
            this.Controls.Add(this.txtBoxOptionC);
            this.Controls.Add(this.txtBoxOptionA);
            this.Controls.Add(this.lblCorrectOption);
            this.Controls.Add(this.lblOptionD);
            this.Controls.Add(this.lblOptionB);
            this.Controls.Add(this.lblOptionC);
            this.Controls.Add(this.lblOptionA);
            this.Controls.Add(this.comboBoxQuestionName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxExamName);
            this.Controls.Add(this.lblExamName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmforChangeInQuestionBank";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit / Update MCQ\'s";
            this.Load += new System.EventHandler(this.forChangeInQuestionBank_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExamName;
        private System.Windows.Forms.ComboBox comboBoxExamName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxQuestionName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox comboBoxCorrectionOption;
        private System.Windows.Forms.TextBox txtBoxOptionD;
        private System.Windows.Forms.TextBox txtBoxOptionB;
        private System.Windows.Forms.TextBox txtBoxOptionC;
        private System.Windows.Forms.TextBox txtBoxOptionA;
        private System.Windows.Forms.Label lblCorrectOption;
        private System.Windows.Forms.Label lblOptionD;
        private System.Windows.Forms.Label lblOptionB;
        private System.Windows.Forms.Label lblOptionC;
        private System.Windows.Forms.Label lblOptionA;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.TextBox txtBoxQuestion;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button button1;
    }
}