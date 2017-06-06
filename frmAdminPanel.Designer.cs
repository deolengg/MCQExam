namespace MCQExam
{
    partial class frmAdminPanel
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.examToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addExamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createExamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMCQsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMCQsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editDeleteMCQsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewResultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentToolStripMenuItem,
            this.examToolStripMenuItem,
            this.adminToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1872, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createStudentToolStripMenuItem,
            this.changePasswordToolStripMenuItem});
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(111, 36);
            this.studentToolStripMenuItem.Text = "Student";
            // 
            // createStudentToolStripMenuItem
            // 
            this.createStudentToolStripMenuItem.Name = "createStudentToolStripMenuItem";
            this.createStudentToolStripMenuItem.Size = new System.Drawing.Size(302, 38);
            this.createStudentToolStripMenuItem.Text = "Create Student";
            this.createStudentToolStripMenuItem.Click += new System.EventHandler(this.createStudentToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(302, 38);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // examToolStripMenuItem
            // 
            this.examToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addExamToolStripMenuItem,
            this.addMCQsToolStripMenuItem,
            this.resultToolStripMenuItem});
            this.examToolStripMenuItem.Name = "examToolStripMenuItem";
            this.examToolStripMenuItem.Size = new System.Drawing.Size(83, 36);
            this.examToolStripMenuItem.Text = "Exam";
            // 
            // addExamToolStripMenuItem
            // 
            this.addExamToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createExamToolStripMenuItem});
            this.addExamToolStripMenuItem.Name = "addExamToolStripMenuItem";
            this.addExamToolStripMenuItem.Size = new System.Drawing.Size(186, 38);
            this.addExamToolStripMenuItem.Text = "Exam";
            this.addExamToolStripMenuItem.Click += new System.EventHandler(this.addExamToolStripMenuItem_Click);
            // 
            // createExamToolStripMenuItem
            // 
            this.createExamToolStripMenuItem.Name = "createExamToolStripMenuItem";
            this.createExamToolStripMenuItem.Size = new System.Drawing.Size(247, 38);
            this.createExamToolStripMenuItem.Text = "Create Exam";
            this.createExamToolStripMenuItem.Click += new System.EventHandler(this.createExamToolStripMenuItem_Click);
            // 
            // addMCQsToolStripMenuItem
            // 
            this.addMCQsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMCQsToolStripMenuItem1,
            this.editDeleteMCQsToolStripMenuItem});
            this.addMCQsToolStripMenuItem.Name = "addMCQsToolStripMenuItem";
            this.addMCQsToolStripMenuItem.Size = new System.Drawing.Size(186, 38);
            this.addMCQsToolStripMenuItem.Text = "MCQ\'s";
            // 
            // addMCQsToolStripMenuItem1
            // 
            this.addMCQsToolStripMenuItem1.Name = "addMCQsToolStripMenuItem1";
            this.addMCQsToolStripMenuItem1.Size = new System.Drawing.Size(326, 38);
            this.addMCQsToolStripMenuItem1.Text = "Add MCQ\'s";
            this.addMCQsToolStripMenuItem1.Click += new System.EventHandler(this.addMCQsToolStripMenuItem1_Click);
            // 
            // editDeleteMCQsToolStripMenuItem
            // 
            this.editDeleteMCQsToolStripMenuItem.Name = "editDeleteMCQsToolStripMenuItem";
            this.editDeleteMCQsToolStripMenuItem.Size = new System.Drawing.Size(326, 38);
            this.editDeleteMCQsToolStripMenuItem.Text = "Edit / Delete MCQ\'s";
            this.editDeleteMCQsToolStripMenuItem.Click += new System.EventHandler(this.editDeleteMCQsToolStripMenuItem_Click);
            // 
            // resultToolStripMenuItem
            // 
            this.resultToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewResultToolStripMenuItem});
            this.resultToolStripMenuItem.Name = "resultToolStripMenuItem";
            this.resultToolStripMenuItem.Size = new System.Drawing.Size(186, 38);
            this.resultToolStripMenuItem.Text = "Result";
            // 
            // viewResultToolStripMenuItem
            // 
            this.viewResultToolStripMenuItem.Name = "viewResultToolStripMenuItem";
            this.viewResultToolStripMenuItem.Size = new System.Drawing.Size(238, 38);
            this.viewResultToolStripMenuItem.Text = "View Result";
            this.viewResultToolStripMenuItem.Click += new System.EventHandler(this.viewResultToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordToolStripMenuItem1,
            this.signOutToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(97, 36);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // changePasswordToolStripMenuItem1
            // 
            this.changePasswordToolStripMenuItem1.Name = "changePasswordToolStripMenuItem1";
            this.changePasswordToolStripMenuItem1.Size = new System.Drawing.Size(302, 38);
            this.changePasswordToolStripMenuItem1.Text = "Change Password";
            this.changePasswordToolStripMenuItem1.Click += new System.EventHandler(this.changePasswordToolStripMenuItem1_Click);
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(302, 38);
            this.signOutToolStripMenuItem.Text = "Sign out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // frmAdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1872, 987);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adminstrator Panel";
            this.Load += new System.EventHandler(this.frmAdminPanel_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem examToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addExamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMCQsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMCQsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editDeleteMCQsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewResultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem createExamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
    }
}