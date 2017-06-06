namespace MCQExam
{
    partial class frmAddExam
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
            this.lblExamDate = new System.Windows.Forms.Label();
            this.lblExamLocation = new System.Windows.Forms.Label();
            this.lblExamStatus = new System.Windows.Forms.Label();
            this.txtBoxExamName = new System.Windows.Forms.TextBox();
            this.dateTimePickerExamTime = new System.Windows.Forms.DateTimePicker();
            this.txtBoxExamLocation = new System.Windows.Forms.TextBox();
            this.comboBoxExamStatus = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblExamName
            // 
            this.lblExamName.AutoSize = true;
            this.lblExamName.Location = new System.Drawing.Point(164, 68);
            this.lblExamName.Name = "lblExamName";
            this.lblExamName.Size = new System.Drawing.Size(128, 25);
            this.lblExamName.TabIndex = 0;
            this.lblExamName.Text = "Exam Name";
            this.lblExamName.Click += new System.EventHandler(this.lblExamName_Click);
            // 
            // lblExamDate
            // 
            this.lblExamDate.AutoSize = true;
            this.lblExamDate.Location = new System.Drawing.Point(173, 143);
            this.lblExamDate.Name = "lblExamDate";
            this.lblExamDate.Size = new System.Drawing.Size(117, 25);
            this.lblExamDate.TabIndex = 1;
            this.lblExamDate.Text = "Exam Date";
            // 
            // lblExamLocation
            // 
            this.lblExamLocation.AutoSize = true;
            this.lblExamLocation.Location = new System.Drawing.Point(138, 217);
            this.lblExamLocation.Name = "lblExamLocation";
            this.lblExamLocation.Size = new System.Drawing.Size(154, 25);
            this.lblExamLocation.TabIndex = 2;
            this.lblExamLocation.Text = "Exam Location";
            // 
            // lblExamStatus
            // 
            this.lblExamStatus.AutoSize = true;
            this.lblExamStatus.Location = new System.Drawing.Point(159, 282);
            this.lblExamStatus.Name = "lblExamStatus";
            this.lblExamStatus.Size = new System.Drawing.Size(133, 25);
            this.lblExamStatus.TabIndex = 3;
            this.lblExamStatus.Text = "Exam Status";
            // 
            // txtBoxExamName
            // 
            this.txtBoxExamName.Location = new System.Drawing.Point(349, 68);
            this.txtBoxExamName.Name = "txtBoxExamName";
            this.txtBoxExamName.Size = new System.Drawing.Size(393, 31);
            this.txtBoxExamName.TabIndex = 4;
            // 
            // dateTimePickerExamTime
            // 
            this.dateTimePickerExamTime.Location = new System.Drawing.Point(349, 143);
            this.dateTimePickerExamTime.Name = "dateTimePickerExamTime";
            this.dateTimePickerExamTime.Size = new System.Drawing.Size(393, 31);
            this.dateTimePickerExamTime.TabIndex = 5;
            // 
            // txtBoxExamLocation
            // 
            this.txtBoxExamLocation.Location = new System.Drawing.Point(349, 217);
            this.txtBoxExamLocation.Name = "txtBoxExamLocation";
            this.txtBoxExamLocation.Size = new System.Drawing.Size(393, 31);
            this.txtBoxExamLocation.TabIndex = 6;
            // 
            // comboBoxExamStatus
            // 
            this.comboBoxExamStatus.FormattingEnabled = true;
            this.comboBoxExamStatus.Items.AddRange(new object[] {
            "Active",
            "In Active"});
            this.comboBoxExamStatus.Location = new System.Drawing.Point(349, 282);
            this.comboBoxExamStatus.Name = "comboBoxExamStatus";
            this.comboBoxExamStatus.Size = new System.Drawing.Size(393, 33);
            this.comboBoxExamStatus.TabIndex = 7;
            this.comboBoxExamStatus.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(620, 393);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(129, 54);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(620, 550);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(141, 55);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(169, 393);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(140, 55);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // frmAddExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 697);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.comboBoxExamStatus);
            this.Controls.Add(this.txtBoxExamLocation);
            this.Controls.Add(this.dateTimePickerExamTime);
            this.Controls.Add(this.txtBoxExamName);
            this.Controls.Add(this.lblExamStatus);
            this.Controls.Add(this.lblExamLocation);
            this.Controls.Add(this.lblExamDate);
            this.Controls.Add(this.lblExamName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmAddExam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Exam";
            this.Load += new System.EventHandler(this.frmAddExam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExamName;
        private System.Windows.Forms.Label lblExamDate;
        private System.Windows.Forms.Label lblExamLocation;
        private System.Windows.Forms.Label lblExamStatus;
        private System.Windows.Forms.TextBox txtBoxExamName;
        private System.Windows.Forms.DateTimePicker dateTimePickerExamTime;
        private System.Windows.Forms.TextBox txtBoxExamLocation;
        private System.Windows.Forms.ComboBox comboBoxExamStatus;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnReset;
    }
}