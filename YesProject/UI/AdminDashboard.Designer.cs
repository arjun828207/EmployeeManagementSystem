using System.Windows.Forms;

namespace YesProject.UI
{
    partial class AdminDashboard
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
            this.createRecordTab = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.userPassword = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.TextBox();
            this.userPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboType = new C1.Win.C1Input.C1ComboBox();
            this.txtId = new C1.Win.C1Input.C1TextBox();
            this.txtSalary = new C1.Win.C1Input.C1TextBox();
            this.checkFaculty = new C1.Win.C1Input.C1CheckBox();
            this.txtName = new C1.Win.C1Input.C1TextBox();
            this.employeeRecordView = new System.Windows.Forms.DataGridView();
            this.c1Button4 = new C1.Win.C1Input.C1Button();
            this.c1Button3 = new C1.Win.C1Input.C1Button();
            this.c1Button2 = new C1.Win.C1Input.C1Button();
            this.c1Button1 = new C1.Win.C1Input.C1Button();
            this.leaveTab = new System.Windows.Forms.TabPage();
            this.timeRecord = new System.Windows.Forms.TabPage();
            this.leaveGridView = new System.Windows.Forms.DataGridView();
            this.timeRecordView = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.createRecordTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkFaculty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeRecordView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Button4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Button3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Button2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Button1)).BeginInit();
            this.leaveTab.SuspendLayout();
            this.timeRecord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leaveGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeRecordView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.createRecordTab);
            this.tabControl1.Controls.Add(this.leaveTab);
            this.tabControl1.Controls.Add(this.timeRecord);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(989, 588);
            this.tabControl1.TabIndex = 0;
            // 
            // createRecordTab
            // 
            this.createRecordTab.Controls.Add(this.label7);
            this.createRecordTab.Controls.Add(this.userPassword);
            this.createRecordTab.Controls.Add(this.userName);
            this.createRecordTab.Controls.Add(this.userPass);
            this.createRecordTab.Controls.Add(this.label5);
            this.createRecordTab.Controls.Add(this.label4);
            this.createRecordTab.Controls.Add(this.label3);
            this.createRecordTab.Controls.Add(this.label2);
            this.createRecordTab.Controls.Add(this.label1);
            this.createRecordTab.Controls.Add(this.comboType);
            this.createRecordTab.Controls.Add(this.txtId);
            this.createRecordTab.Controls.Add(this.txtSalary);
            this.createRecordTab.Controls.Add(this.checkFaculty);
            this.createRecordTab.Controls.Add(this.txtName);
            this.createRecordTab.Controls.Add(this.employeeRecordView);
            this.createRecordTab.Controls.Add(this.c1Button4);
            this.createRecordTab.Controls.Add(this.c1Button3);
            this.createRecordTab.Controls.Add(this.c1Button2);
            this.createRecordTab.Controls.Add(this.c1Button1);
            this.createRecordTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createRecordTab.Location = new System.Drawing.Point(4, 25);
            this.createRecordTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createRecordTab.Name = "createRecordTab";
            this.createRecordTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createRecordTab.Size = new System.Drawing.Size(981, 559);
            this.createRecordTab.TabIndex = 0;
            this.createRecordTab.Text = "Employee Record";
            this.createRecordTab.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(341, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "User Name";
            // 
            // userPassword
            // 
            this.userPassword.AutoSize = true;
            this.userPassword.Location = new System.Drawing.Point(352, 117);
            this.userPassword.Name = "userPassword";
            this.userPassword.Size = new System.Drawing.Size(69, 17);
            this.userPassword.TabIndex = 19;
            this.userPassword.Text = "Password";
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(440, 69);
            this.userName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(132, 22);
            this.userName.TabIndex = 18;
            // 
            // userPass
            // 
            this.userPass.Location = new System.Drawing.Point(440, 108);
            this.userPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userPass.Name = "userPass";
            this.userPass.Size = new System.Drawing.Size(132, 22);
            this.userPass.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Salary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(328, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Type of Work";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Employee Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Employee Name";
            // 
            // comboType
            // 
            this.comboType.AllowSpinLoop = false;
            this.comboType.GapHeight = 0;
            this.comboType.ImagePadding = new System.Windows.Forms.Padding(0);
            this.comboType.Location = new System.Drawing.Point(440, 27);
            this.comboType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(132, 20);
            this.comboType.TabIndex = 11;
            this.comboType.Tag = null;
            this.comboType.VisualStyle = C1.Win.C1Input.VisualStyle.System;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(124, 70);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(133, 20);
            this.txtId.TabIndex = 10;
            this.txtId.Tag = null;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(124, 111);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(133, 20);
            this.txtSalary.TabIndex = 9;
            this.txtSalary.Tag = null;
            // 
            // checkFaculty
            // 
            this.checkFaculty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkFaculty.Location = new System.Drawing.Point(621, 27);
            this.checkFaculty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkFaculty.Name = "checkFaculty";
            this.checkFaculty.Size = new System.Drawing.Size(139, 30);
            this.checkFaculty.TabIndex = 7;
            this.checkFaculty.Text = "Faculty Member";
            this.checkFaculty.UseVisualStyleBackColor = false;
            this.checkFaculty.Value = null;
            this.checkFaculty.CheckedChanged += new System.EventHandler(this.checkFaculty_CheckedChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(124, 22);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(133, 20);
            this.txtName.TabIndex = 3;
            this.txtName.Tag = null;
            // 
            // employeeRecordView
            // 
            this.employeeRecordView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.employeeRecordView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.employeeRecordView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeRecordView.Location = new System.Drawing.Point(3, 222);
            this.employeeRecordView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.employeeRecordView.Name = "employeeRecordView";
            this.employeeRecordView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employeeRecordView.Size = new System.Drawing.Size(787, 334);
            this.employeeRecordView.TabIndex = 2;
            this.employeeRecordView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeeRecordView_CellClick);
            // 
            // c1Button4
            // 
            this.c1Button4.Location = new System.Drawing.Point(491, 159);
            this.c1Button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.c1Button4.Name = "c1Button4";
            this.c1Button4.Size = new System.Drawing.Size(135, 41);
            this.c1Button4.TabIndex = 0;
            this.c1Button4.Text = "Reset";
            this.c1Button4.UseVisualStyleBackColor = true;
            this.c1Button4.Click += new System.EventHandler(this.OnResetClick);
            // 
            // c1Button3
            // 
            this.c1Button3.Location = new System.Drawing.Point(331, 159);
            this.c1Button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.c1Button3.Name = "c1Button3";
            this.c1Button3.Size = new System.Drawing.Size(135, 41);
            this.c1Button3.TabIndex = 0;
            this.c1Button3.Text = "Delete";
            this.c1Button3.UseVisualStyleBackColor = true;
            this.c1Button3.Click += new System.EventHandler(this.c1Button3_Click);
            // 
            // c1Button2
            // 
            this.c1Button2.Location = new System.Drawing.Point(171, 159);
            this.c1Button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.c1Button2.Name = "c1Button2";
            this.c1Button2.Size = new System.Drawing.Size(135, 41);
            this.c1Button2.TabIndex = 0;
            this.c1Button2.Text = "Update";
            this.c1Button2.UseVisualStyleBackColor = true;
            this.c1Button2.Click += new System.EventHandler(this.c1Button2_Click);
            // 
            // c1Button1
            // 
            this.c1Button1.Location = new System.Drawing.Point(11, 159);
            this.c1Button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.c1Button1.Name = "c1Button1";
            this.c1Button1.Size = new System.Drawing.Size(135, 41);
            this.c1Button1.TabIndex = 0;
            this.c1Button1.Text = "Insert";
            this.c1Button1.UseVisualStyleBackColor = true;
            this.c1Button1.Click += new System.EventHandler(this.c1Button1_Click);
            // 
            // leaveTab
            // 
            this.leaveTab.Controls.Add(this.leaveGridView);
            this.leaveTab.Location = new System.Drawing.Point(4, 25);
            this.leaveTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.leaveTab.Name = "leaveTab";
            this.leaveTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.leaveTab.Size = new System.Drawing.Size(981, 559);
            this.leaveTab.TabIndex = 1;
            this.leaveTab.Text = "Leave Record";
            this.leaveTab.UseVisualStyleBackColor = true;
            // 
            // timeRecord
            // 
            this.timeRecord.Controls.Add(this.timeRecordView);
            this.timeRecord.Location = new System.Drawing.Point(4, 25);
            this.timeRecord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.timeRecord.Name = "timeRecord";
            this.timeRecord.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.timeRecord.Size = new System.Drawing.Size(981, 559);
            this.timeRecord.TabIndex = 2;
            this.timeRecord.Text = "Time Record";
            this.timeRecord.UseVisualStyleBackColor = true;
            // 
            // leaveGridView
            // 
            this.leaveGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.leaveGridView.Location = new System.Drawing.Point(19, 97);
            this.leaveGridView.Name = "leaveGridView";
            this.leaveGridView.RowTemplate.Height = 24;
            this.leaveGridView.Size = new System.Drawing.Size(930, 434);
            this.leaveGridView.TabIndex = 0;
            // 
            // timeRecordView
            // 
            this.timeRecordView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.timeRecordView.Location = new System.Drawing.Point(33, 182);
            this.timeRecordView.Name = "timeRecordView";
            this.timeRecordView.RowTemplate.Height = 24;
            this.timeRecordView.Size = new System.Drawing.Size(897, 342);
            this.timeRecordView.TabIndex = 0;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 588);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminDashboard_FormClosed);
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.tabControl1.ResumeLayout(false);
            this.createRecordTab.ResumeLayout(false);
            this.createRecordTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkFaculty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeRecordView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Button4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Button3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Button2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Button1)).EndInit();
            this.leaveTab.ResumeLayout(false);
            this.timeRecord.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.leaveGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeRecordView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage createRecordTab;
        private System.Windows.Forms.TabPage leaveTab;
        private System.Windows.Forms.TabPage timeRecord;
        private C1.Win.C1Input.C1TextBox txtName;
        private System.Windows.Forms.DataGridView employeeRecordView;
        private C1.Win.C1Input.C1Button c1Button4;
        private C1.Win.C1Input.C1Button c1Button3;
        private C1.Win.C1Input.C1Button c1Button2;
        private C1.Win.C1Input.C1Button c1Button1;
        private C1.Win.C1Input.C1CheckBox checkFaculty;
        private C1.Win.C1Input.C1TextBox txtId;
        private C1.Win.C1Input.C1TextBox txtSalary;
        private C1.Win.C1Input.C1ComboBox comboType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label userPassword;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox userPass;
        private DataGridView leaveGridView;
        private DataGridView timeRecordView;
    }
}