using System.Drawing;

namespace YesProject.UI
{
    partial class EmployeeDashboard
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.homePage = new System.Windows.Forms.TabPage();
            this.leaveApply = new System.Windows.Forms.TabPage();
            this.approvalStatus = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.leaveType = new System.Windows.Forms.ComboBox();
            this.commentBox = new System.Windows.Forms.RichTextBox();
            this.endDate = new C1.Win.C1Input.C1DateEdit();
            this.startDate = new C1.Win.C1Input.C1DateEdit();
            this.timeLogin = new System.Windows.Forms.TabPage();
            this.submitBtn = new System.Windows.Forms.Button();
            this.logOutTime = new C1.Win.Calendar.C1DateEdit();
            this.logInTime = new C1.Win.Calendar.C1DateEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.logIn = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.leaveApply.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.endDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDate)).BeginInit();
            this.timeLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logOutTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logInTime)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.homePage);
            this.tabControl1.Controls.Add(this.leaveApply);
            this.tabControl1.Controls.Add(this.timeLogin);
            this.tabControl1.Location = new System.Drawing.Point(3, 1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(797, 448);
            this.tabControl1.TabIndex = 0;
            // 
            // homePage
            // 
            this.homePage.Location = new System.Drawing.Point(4, 25);
            this.homePage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.homePage.Name = "homePage";
            this.homePage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.homePage.Size = new System.Drawing.Size(789, 419);
            this.homePage.TabIndex = 0;
            this.homePage.Text = "Home";
            this.homePage.UseVisualStyleBackColor = true;
            // 
            // leaveApply
            // 
            this.leaveApply.Controls.Add(this.approvalStatus);
            this.leaveApply.Controls.Add(this.button1);
            this.leaveApply.Controls.Add(this.label6);
            this.leaveApply.Controls.Add(this.label5);
            this.leaveApply.Controls.Add(this.label4);
            this.leaveApply.Controls.Add(this.label3);
            this.leaveApply.Controls.Add(this.label1);
            this.leaveApply.Controls.Add(this.leaveType);
            this.leaveApply.Controls.Add(this.commentBox);
            this.leaveApply.Controls.Add(this.endDate);
            this.leaveApply.Controls.Add(this.startDate);
            this.leaveApply.Location = new System.Drawing.Point(4, 25);
            this.leaveApply.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.leaveApply.Name = "leaveApply";
            this.leaveApply.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.leaveApply.Size = new System.Drawing.Size(789, 419);
            this.leaveApply.TabIndex = 1;
            this.leaveApply.Text = "Leave";
            this.leaveApply.UseVisualStyleBackColor = true;
            // 
            // approvalStatus
            // 
            this.approvalStatus.AutoSize = true;
            this.approvalStatus.ForeColor = System.Drawing.Color.Red;
            this.approvalStatus.Location = new System.Drawing.Point(680, 11);
            this.approvalStatus.Name = "approvalStatus";
            this.approvalStatus.Size = new System.Drawing.Size(60, 17);
            this.approvalStatus.TabIndex = 10;
            this.approvalStatus.Text = "Pending";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(683, 42);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 9;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-4, 69);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Leave Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(376, 59);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Comments";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 170);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "From";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 4;
            // 
            // leaveType
            // 
            this.leaveType.FormattingEnabled = true;
            this.leaveType.Location = new System.Drawing.Point(89, 59);
            this.leaveType.Margin = new System.Windows.Forms.Padding(4);
            this.leaveType.Name = "leaveType";
            this.leaveType.Size = new System.Drawing.Size(199, 24);
            this.leaveType.TabIndex = 3;
            // 
            // commentBox
            // 
            this.commentBox.Location = new System.Drawing.Point(475, 44);
            this.commentBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.commentBox.Name = "commentBox";
            this.commentBox.Size = new System.Drawing.Size(200, 141);
            this.commentBox.TabIndex = 2;
            this.commentBox.Text = "";
            // 
            // endDate
            // 
            // 
            // 
            // 
            this.endDate.Calendar.DayNameLength = 1;
            this.endDate.GapHeight = 0;
            this.endDate.ImagePadding = new System.Windows.Forms.Padding(0);
            this.endDate.Location = new System.Drawing.Point(89, 164);
            this.endDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(200, 20);
            this.endDate.TabIndex = 1;
            this.endDate.Tag = null;
            // 
            // startDate
            // 
            // 
            // 
            // 
            this.startDate.Calendar.DayNameLength = 1;
            this.startDate.GapHeight = 0;
            this.startDate.ImagePadding = new System.Windows.Forms.Padding(0);
            this.startDate.Location = new System.Drawing.Point(89, 119);
            this.startDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(200, 20);
            this.startDate.TabIndex = 0;
            this.startDate.Tag = null;
            // 
            // timeLogin
            // 
            this.timeLogin.Controls.Add(this.submitBtn);
            this.timeLogin.Controls.Add(this.logOutTime);
            this.timeLogin.Controls.Add(this.logInTime);
            this.timeLogin.Controls.Add(this.label2);
            this.timeLogin.Controls.Add(this.logIn);
            this.timeLogin.Location = new System.Drawing.Point(4, 25);
            this.timeLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.timeLogin.Name = "timeLogin";
            this.timeLogin.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.timeLogin.Size = new System.Drawing.Size(789, 419);
            this.timeLogin.TabIndex = 2;
            this.timeLogin.Text = "Attendance";
            this.timeLogin.UseVisualStyleBackColor = true;
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(28, 272);
            this.submitBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 23);
            this.submitBtn.TabIndex = 4;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // logOutTime
            // 
            this.logOutTime.Calendar.RightToLeft = System.Windows.Forms.RightToLeft.Inherit;
            this.logOutTime.GapHeight = 0;
            this.logOutTime.ImagePadding = new System.Windows.Forms.Padding(0);
            this.logOutTime.Location = new System.Drawing.Point(125, 174);
            this.logOutTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logOutTime.Name = "logOutTime";
            this.logOutTime.Size = new System.Drawing.Size(200, 20);
            this.logOutTime.TabIndex = 3;
            this.logOutTime.Tag = null;
            // 
            // logInTime
            // 
            this.logInTime.Calendar.RightToLeft = System.Windows.Forms.RightToLeft.Inherit;
            this.logInTime.GapHeight = 0;
            this.logInTime.ImagePadding = new System.Windows.Forms.Padding(0);
            this.logInTime.Location = new System.Drawing.Point(125, 84);
            this.logInTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logInTime.Name = "logInTime";
            this.logInTime.Size = new System.Drawing.Size(200, 20);
            this.logInTime.TabIndex = 2;
            this.logInTime.Tag = null;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Log Out Time";
            // 
            // logIn
            // 
            this.logIn.AutoSize = true;
            this.logIn.Location = new System.Drawing.Point(25, 87);
            this.logIn.Name = "logIn";
            this.logIn.Size = new System.Drawing.Size(82, 17);
            this.logIn.TabIndex = 0;
            this.logIn.Text = "Log In Time";
            // 
            // EmployeeDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EmployeeDashboard";
            this.Text = "EmployeeDashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EmployeeDashboard_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.leaveApply.ResumeLayout(false);
            this.leaveApply.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.endDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDate)).EndInit();
            this.timeLogin.ResumeLayout(false);
            this.timeLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logOutTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logInTime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage homePage;
        private System.Windows.Forms.TabPage leaveApply;
        private System.Windows.Forms.TabPage timeLogin;
        private C1.Win.Calendar.C1DateEdit logOutTime;
        private C1.Win.Calendar.C1DateEdit logInTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label logIn;
        private System.Windows.Forms.Button submitBtn;
        private C1.Win.C1Input.C1DateEdit endDate;
        private C1.Win.C1Input.C1DateEdit startDate;
        private System.Windows.Forms.RichTextBox commentBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox leaveType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label approvalStatus;
    }
}