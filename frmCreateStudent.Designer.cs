namespace MCQExam
{
    partial class frmCreateStudent
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
            this.lblStudentName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtBoxStudentName = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtBoxUserName = new System.Windows.Forms.TextBox();
            this.lblEmailId = new System.Windows.Forms.Label();
            this.txtBoxEmailId = new System.Windows.Forms.TextBox();
            this.lblStudentPassword = new System.Windows.Forms.Label();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(136, 83);
            this.lblStudentName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(154, 25);
            this.lblStudentName.TabIndex = 0;
            this.lblStudentName.Text = "Student Name:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(488, 395);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 44);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtBoxStudentName
            // 
            this.txtBoxStudentName.Location = new System.Drawing.Point(310, 83);
            this.txtBoxStudentName.Margin = new System.Windows.Forms.Padding(6);
            this.txtBoxStudentName.Name = "txtBoxStudentName";
            this.txtBoxStudentName.Size = new System.Drawing.Size(328, 31);
            this.txtBoxStudentName.TabIndex = 3;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(146, 395);
            this.btnReset.Margin = new System.Windows.Forms.Padding(6);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(150, 44);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(488, 552);
            this.btnBack.Margin = new System.Windows.Forms.Padding(6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(150, 44);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(171, 153);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(125, 25);
            this.lblUserName.TabIndex = 8;
            this.lblUserName.Text = "User Name:";
            // 
            // txtBoxUserName
            // 
            this.txtBoxUserName.Location = new System.Drawing.Point(310, 153);
            this.txtBoxUserName.Name = "txtBoxUserName";
            this.txtBoxUserName.Size = new System.Drawing.Size(328, 31);
            this.txtBoxUserName.TabIndex = 9;
            // 
            // lblEmailId
            // 
            this.lblEmailId.AutoSize = true;
            this.lblEmailId.Location = new System.Drawing.Point(202, 298);
            this.lblEmailId.Name = "lblEmailId";
            this.lblEmailId.Size = new System.Drawing.Size(94, 25);
            this.lblEmailId.TabIndex = 10;
            this.lblEmailId.Text = "Email Id:";
            // 
            // txtBoxEmailId
            // 
            this.txtBoxEmailId.Location = new System.Drawing.Point(310, 298);
            this.txtBoxEmailId.Name = "txtBoxEmailId";
            this.txtBoxEmailId.Size = new System.Drawing.Size(328, 31);
            this.txtBoxEmailId.TabIndex = 11;
            // 
            // lblStudentPassword
            // 
            this.lblStudentPassword.AutoSize = true;
            this.lblStudentPassword.Location = new System.Drawing.Point(178, 228);
            this.lblStudentPassword.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblStudentPassword.Name = "lblStudentPassword";
            this.lblStudentPassword.Size = new System.Drawing.Size(112, 25);
            this.lblStudentPassword.TabIndex = 1;
            this.lblStudentPassword.Text = "Password:";
            this.lblStudentPassword.Click += new System.EventHandler(this.lblStudentPassword_Click);
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Location = new System.Drawing.Point(310, 228);
            this.txtBoxPassword.Margin = new System.Windows.Forms.Padding(6);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(328, 31);
            this.txtBoxPassword.TabIndex = 4;
            // 
            // frmCreateStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 678);
            this.Controls.Add(this.txtBoxEmailId);
            this.Controls.Add(this.lblEmailId);
            this.Controls.Add(this.txtBoxUserName);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.txtBoxStudentName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblStudentPassword);
            this.Controls.Add(this.lblStudentName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmCreateStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create Student";
            this.Load += new System.EventHandler(this.createStd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtBoxStudentName;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtBoxUserName;
        private System.Windows.Forms.Label lblEmailId;
        private System.Windows.Forms.TextBox txtBoxEmailId;
        private System.Windows.Forms.Label lblStudentPassword;
        private System.Windows.Forms.TextBox txtBoxPassword;
    }
}