namespace YesProject
{
    partial class Form1
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
            this.nm = new System.Windows.Forms.TextBox();
            this.eid = new System.Windows.Forms.TextBox();
            this.sal = new System.Windows.Forms.TextBox();
            this.calBtn = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.c1Button1 = new C1.Win.C1Input.C1Button();
            ((System.ComponentModel.ISupportInitialize)(this.c1Button1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(634, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Management system";
            // 
            // nm
            // 
            this.nm.Location = new System.Drawing.Point(221, 122);
            this.nm.Margin = new System.Windows.Forms.Padding(4);
            this.nm.Name = "nm";
            this.nm.Size = new System.Drawing.Size(132, 22);
            this.nm.TabIndex = 1;
            this.nm.Text = "Name";
            // 
            // eid
            // 
            this.eid.Location = new System.Drawing.Point(221, 183);
            this.eid.Margin = new System.Windows.Forms.Padding(4);
            this.eid.Name = "eid";
            this.eid.Size = new System.Drawing.Size(132, 22);
            this.eid.TabIndex = 2;
            this.eid.Text = "Employee Id";
            // 
            // sal
            // 
            this.sal.Location = new System.Drawing.Point(221, 276);
            this.sal.Margin = new System.Windows.Forms.Padding(4);
            this.sal.Name = "sal";
            this.sal.Size = new System.Drawing.Size(132, 22);
            this.sal.TabIndex = 3;
            this.sal.Text = "Salary";
            // 
            // calBtn
            // 
            this.calBtn.Location = new System.Drawing.Point(221, 372);
            this.calBtn.Margin = new System.Windows.Forms.Padding(4);
            this.calBtn.Name = "calBtn";
            this.calBtn.Size = new System.Drawing.Size(100, 28);
            this.calBtn.TabIndex = 4;
            this.calBtn.Text = "calculate";
            this.calBtn.UseVisualStyleBackColor = true;
            this.calBtn.Click += new System.EventHandler(this.calBtn_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(221, 81);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(130, 21);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Faculty Member";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.OnCheckBox1CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(221, 321);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "Type";
            // 
            // c1Button1
            // 
            this.c1Button1.Location = new System.Drawing.Point(442, 376);
            this.c1Button1.Name = "c1Button1";
            this.c1Button1.Size = new System.Drawing.Size(75, 23);
            this.c1Button1.TabIndex = 7;
            this.c1Button1.Text = "Insert";
            this.c1Button1.UseVisualStyleBackColor = true;
            this.c1Button1.Click += new System.EventHandler(this.OnC1Button1Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.c1Button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.calBtn);
            this.Controls.Add(this.sal);
            this.Controls.Add(this.eid);
            this.Controls.Add(this.nm);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.c1Button1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nm;
        private System.Windows.Forms.TextBox eid;
        private System.Windows.Forms.TextBox sal;
        private System.Windows.Forms.Button calBtn;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private C1.Win.C1Input.C1Button c1Button1;
    }
}