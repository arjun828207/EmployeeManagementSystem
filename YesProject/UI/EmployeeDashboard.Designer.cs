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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.c1DateEdit4 = new C1.Win.C1Input.C1DateEdit();
            this.c1DateEdit3 = new C1.Win.C1Input.C1DateEdit();
            this.timeLogin = new System.Windows.Forms.TabPage();
            this.submitBtn = new System.Windows.Forms.Button();
            this.logOutTime = new C1.Win.Calendar.C1DateEdit();
            this.logInTime = new C1.Win.Calendar.C1DateEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.logIn = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.leaveApply.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1DateEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1DateEdit3)).BeginInit();
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
            this.tabControl1.Location = new System.Drawing.Point(2, 1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(598, 364);
            this.tabControl1.TabIndex = 0;
            // 
            // homePage
            // 
            this.homePage.Location = new System.Drawing.Point(4, 22);
            this.homePage.Margin = new System.Windows.Forms.Padding(2);
            this.homePage.Name = "homePage";
            this.homePage.Padding = new System.Windows.Forms.Padding(2);
            this.homePage.Size = new System.Drawing.Size(590, 338);
            this.homePage.TabIndex = 0;
            this.homePage.Text = "Home";
            this.homePage.UseVisualStyleBackColor = true;
            // 
            // leaveApply
            // 
            this.leaveApply.Controls.Add(this.label5);
            this.leaveApply.Controls.Add(this.label4);
            this.leaveApply.Controls.Add(this.label3);
            this.leaveApply.Controls.Add(this.label1);
            this.leaveApply.Controls.Add(this.comboBox1);
            this.leaveApply.Controls.Add(this.richTextBox1);
            this.leaveApply.Controls.Add(this.c1DateEdit4);
            this.leaveApply.Controls.Add(this.c1DateEdit3);
            this.leaveApply.Location = new System.Drawing.Point(4, 22);
            this.leaveApply.Margin = new System.Windows.Forms.Padding(2);
            this.leaveApply.Name = "leaveApply";
            this.leaveApply.Padding = new System.Windows.Forms.Padding(2);
            this.leaveApply.Size = new System.Drawing.Size(590, 338);
            this.leaveApply.TabIndex = 1;
            this.leaveApply.Text = "Leave";
            this.leaveApply.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(327, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Comments";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(67, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(388, 36);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(151, 115);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // c1DateEdit4
            // 
            // 
            // 
            // 
            this.c1DateEdit4.Calendar.DayNameLength = 1;
            this.c1DateEdit4.GapHeight = 0;
            this.c1DateEdit4.ImagePadding = new System.Windows.Forms.Padding(0);
            this.c1DateEdit4.Location = new System.Drawing.Point(67, 133);
            this.c1DateEdit4.Margin = new System.Windows.Forms.Padding(2);
            this.c1DateEdit4.Name = "c1DateEdit4";
            this.c1DateEdit4.Size = new System.Drawing.Size(150, 18);
            this.c1DateEdit4.TabIndex = 1;
            this.c1DateEdit4.Tag = null;
            // 
            // c1DateEdit3
            // 
            // 
            // 
            // 
            this.c1DateEdit3.Calendar.DayNameLength = 1;
            this.c1DateEdit3.GapHeight = 0;
            this.c1DateEdit3.ImagePadding = new System.Windows.Forms.Padding(0);
            this.c1DateEdit3.Location = new System.Drawing.Point(67, 97);
            this.c1DateEdit3.Margin = new System.Windows.Forms.Padding(2);
            this.c1DateEdit3.Name = "c1DateEdit3";
            this.c1DateEdit3.Size = new System.Drawing.Size(150, 18);
            this.c1DateEdit3.TabIndex = 0;
            this.c1DateEdit3.Tag = null;
            // 
            // timeLogin
            // 
            this.timeLogin.Controls.Add(this.submitBtn);
            this.timeLogin.Controls.Add(this.logOutTime);
            this.timeLogin.Controls.Add(this.logInTime);
            this.timeLogin.Controls.Add(this.label2);
            this.timeLogin.Controls.Add(this.logIn);
            this.timeLogin.Location = new System.Drawing.Point(4, 22);
            this.timeLogin.Margin = new System.Windows.Forms.Padding(2);
            this.timeLogin.Name = "timeLogin";
            this.timeLogin.Padding = new System.Windows.Forms.Padding(2);
            this.timeLogin.Size = new System.Drawing.Size(590, 338);
            this.timeLogin.TabIndex = 2;
            this.timeLogin.Text = "Attendance";
            this.timeLogin.UseVisualStyleBackColor = true;
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(21, 221);
            this.submitBtn.Margin = new System.Windows.Forms.Padding(2);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(56, 19);
            this.submitBtn.TabIndex = 4;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            // 
            // logOutTime
            // 
            this.logOutTime.Calendar.RightToLeft = System.Windows.Forms.RightToLeft.Inherit;
            this.logOutTime.GapHeight = 0;
            this.logOutTime.ImagePadding = new System.Windows.Forms.Padding(0);
            this.logOutTime.Location = new System.Drawing.Point(94, 141);
            this.logOutTime.Margin = new System.Windows.Forms.Padding(2);
            this.logOutTime.Name = "logOutTime";
            this.logOutTime.Size = new System.Drawing.Size(150, 18);
            this.logOutTime.TabIndex = 3;
            this.logOutTime.Tag = null;
            // 
            // logInTime
            // 
            this.logInTime.Calendar.RightToLeft = System.Windows.Forms.RightToLeft.Inherit;
            this.logInTime.GapHeight = 0;
            this.logInTime.ImagePadding = new System.Windows.Forms.Padding(0);
            this.logInTime.Location = new System.Drawing.Point(94, 68);
            this.logInTime.Margin = new System.Windows.Forms.Padding(2);
            this.logInTime.Name = "logInTime";
            this.logInTime.Size = new System.Drawing.Size(150, 18);
            this.logInTime.TabIndex = 2;
            this.logInTime.Tag = null;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 141);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Log Out Time";
            // 
            // logIn
            // 
            this.logIn.AutoSize = true;
            this.logIn.Location = new System.Drawing.Point(19, 71);
            this.logIn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.logIn.Name = "logIn";
            this.logIn.Size = new System.Drawing.Size(63, 13);
            this.logIn.TabIndex = 0;
            this.logIn.Text = "Log In Time";
            // 
            // EmployeeDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EmployeeDashboard";
            this.Text = "EmployeeDashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EmployeeDashboard_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.leaveApply.ResumeLayout(false);
            this.leaveApply.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1DateEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1DateEdit3)).EndInit();
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
        private C1.Win.C1Input.C1DateEdit c1DateEdit4;
        private C1.Win.C1Input.C1DateEdit c1DateEdit3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}